using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using ShogiCore;

namespace WTester {
    public partial class WinRateLineControl : UserControl {
        double significanceLevel = 0.05;

        /// <summary>
        /// 有意水準（既定値：0.05(5%)）
        /// </summary>
        public double SignificanceLevel {
            get { return significanceLevel; }
            set { significanceLevel = value; ResetTextBox2(); }
        }

        public WinRateLineControl() {
            InitializeComponent();
            // 最初に1回読んどく。
            OnChangeValue();
        }

        /// <summary>
        /// 読み書き可能かどうか。
        /// </summary>
        public bool CountReadOnly {
            get { return textBox1.ReadOnly; }
            set {
                textBox1.ReadOnly = value;
                button1.Visible = !value;
            }
        }

        [Browsable(false)]
        [DefaultValue("")]
        public string IndirectText {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        [Browsable(false)]
        [DefaultValue(0)]
        public int WinCount {
            get { return ParseValue()[0]; }
            set {
                var c = ParseValue();
                c[0] = value;
                textBox1.Text = c[0].ToString() + "-" + c[1].ToString() + "-" + c[2].ToString();
            }
        }
        [Browsable(false)]
        [DefaultValue(0)]
        public int DrawCount {
            get { return ParseValue()[1]; }
            set {
                var c = ParseValue();
                c[1] = value;
                textBox1.Text = c[0].ToString() + "-" + c[1].ToString() + "-" + c[2].ToString();
            }
        }

        [Browsable(false)]
        [DefaultValue(0)]
        public int LoseCount {
            get { return ParseValue()[2]; }
            set {
                var c = ParseValue();
                c[2] = value;
                textBox1.Text = c[0].ToString() + "-" + c[1].ToString() + "-" + c[2].ToString();
            }
        }

        static Regex countRegex = new Regex(@"^\s*(\d+)\s*-\s*(\d+)\s*-\s*(\d+)\s*(/\d+\s*)?(:.*)?$", RegexOptions.Compiled);
        /// <summary>
        /// textBox1の値をparseして返す
        /// </summary>
        private int[] ParseValue() {
            Match m = countRegex.Match(textBox1.Text);
            if (m.Success) {
                try {
                    return new int[] {
						int.Parse(m.Groups[1].Value),
						int.Parse(m.Groups[2].Value),
						int.Parse(m.Groups[3].Value),
					};
                } catch {
                    // 面倒なので黙殺
                }
            }
            return new int[3];
        }

        /// <summary>
        /// 値が何かしら変わった時のイベント
        /// </summary>
        public event EventHandler ValueChanged;

        /// <summary>
        /// 値が変わった
        /// </summary>
        private void textBox1_TextChanged(object sender, EventArgs e) {
            OnChangeValue();
        }

        /// <summary>
        /// 値が変わったので再計算したりイベントったり
        /// </summary>
        private void OnChangeValue() {
            ResetTextBox2();
            // イベント
            var ValueChanged = this.ValueChanged;
            if (ValueChanged != null) {
                ValueChanged(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// 表示の更新
        /// </summary>
        private void ResetTextBox2() {
            // 勝敗数
            int[] c = ParseValue();
            int win = c[0];
            int draw = c[1];
            int lose = c[2];
            // 再設定
            string text = win.ToString() + "-" + draw.ToString() + "-" + lose.ToString();
            if (!textBox1.Focused && textBox1.Text != text) {
                textBox1.Text = text;
                return;
            }
            int N = win + lose;
            // 勝率 (引き分けは0.5勝扱い)
            int NN = N + draw;
            double wr = NN <= 0 ? 0 : (win + draw * 0.5) * 100.0 / NN;
            // R差 (引き分けは0.5勝扱い)
            double rating = N <= 0 ? 0 : MathUtility.WinRateToRatingDiff(wr / 100.0);
            // 勝率の信頼区間 (引き分けは除く)
            double wL, wH;
            if (N <= 0) {
                wL = wH = 0.0; // 仮
            } else {
                MathUtility.GetWinConfidence(win, lose, significanceLevel, out wL, out wH);
                wL *= 100.0;
                wH *= 100.0;
            }
            // 有意確率 (引き分けは除く)
            double wp = MathUtility.SignTest(win, lose) * 100.0;

            // 表示の更新
            textBox2.Text =
                (text + "/" + (win + lose).ToString()).PadRight(15)
                + ": " + wr.ToString("0.0").PadLeft(5)
                + ", " + rating.ToString("+0.0;-0.0;+0.0").PadLeft(5)
                + ", " + (wL.ToString("0.0") + " - " + wH.ToString("0.0")).PadLeft(13)
                + ", " + wp.ToString("0.0").PadLeft(5)
                ;
        }

        /// <summary>
        /// クリアボタン
        /// </summary>
        private void button1_Click(object sender, EventArgs e) {
            Clear();
        }

        /// <summary>
        /// クリア
        /// </summary>
        public void Clear() {
            textBox1.Clear();
        }

        /// <summary>
        /// フォーカス外れる時
        /// </summary>
        private void textBox1_Leave(object sender, EventArgs e) {
            // 次の時の為に、全部選択した状態にする
            textBox1.SelectAll();
            // 一応再計算
            ResetTextBox2();
        }
        /// <summary>
        /// フォーカス外れる時
        /// </summary>
        private void textBox2_Leave(object sender, EventArgs e) {
            ResetTextBox2();
            // 次の時の為に、全部選択した状態にする
            textBox2.SelectAll();
        }
        /// <summary>
        /// フォーカス入る時
        /// </summary>
        private void textBox2_Enter(object sender, EventArgs e) {
            textBox2.Text = Regex.Replace(textBox2.Text, @"\s\s+", " ");
            textBox2.SelectAll(); // ←これ上手く行ってない？
        }
    }
}
