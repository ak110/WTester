using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WTester {
    /// <summary>
    /// 勝率コントロール
    /// </summary>
    public partial class WinRateControl : UserControl {
        public WinRateControl() {
            InitializeComponent();
            LoadData();
        }

        private void winRateLineControl1_ValueChanged(object sender, EventArgs e) {
            OnValueChanged();
        }

        private void winRateLineControl2_ValueChanged(object sender, EventArgs e) {
            OnValueChanged();
        }

        private void winRateLineControl3_ValueChanged(object sender, EventArgs e) {
            OnValueChanged();
        }

        /// <summary>
        /// 値が変わった
        /// </summary>
        private void OnValueChanged() {
            winRateLineControl4.WinCount =
                winRateLineControl1.WinCount +
                winRateLineControl2.WinCount +
                winRateLineControl3.WinCount;
            winRateLineControl4.DrawCount =
                winRateLineControl1.DrawCount +
                winRateLineControl2.DrawCount +
                winRateLineControl3.DrawCount;
            winRateLineControl4.LoseCount =
                winRateLineControl1.LoseCount +
                winRateLineControl2.LoseCount +
                winRateLineControl3.LoseCount;
        }

        /// <summary>
        /// ①へコピー
        /// </summary>
        private void button1_Click(object sender, EventArgs e) {
            winRateLineControl1.IndirectText = winRateLineControl4.IndirectText;
            winRateLineControl2.Clear();
            winRateLineControl3.Clear();
        }

        /// <summary>
        /// データの読み込み
        /// </summary>
        private void LoadData() {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data.dat");
            Data data = Data.Deserialize(path);
            // データの反映
            comboBox1.BeginUpdate();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(data.Entries.ToArray()); // DataEntryをそのまま突っ込んじゃう
            if (0 < comboBox1.Items.Count) {
                comboBox1.SelectedIndex = 0;
            }
            comboBox1.EndUpdate();
        }

        /// <summary>
        /// 保存
        /// </summary>
        private void SaveData() {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data.dat");
            Data data = new Data();
            foreach (object item in comboBox1.Items) {
                data.Entries.Add((DataEntry)item);
            }
            data.Serialize(path);
        }

        /// <summary>
        /// 保存ボタン
        /// </summary>
        private void button2_Click(object sender, EventArgs e) {
            string name = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(name)) {
                MessageBox.Show(this, "保存名を入力してください");
                return;
            }
            // 同じ名前があれば確認後上書き
            foreach (object item in comboBox1.Items) {
                DataEntry ent = (DataEntry)item;
                if (ent.Name == name) {
                    if (MessageBox.Show(this,
                        "保存名 '" + name + "' は既に存在します。上書きしますか?",
                        "確認", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                        // 上書き
                        ent.Text1 = winRateLineControl1.IndirectText;
                        ent.Text2 = winRateLineControl2.IndirectText;
                        ent.Text3 = winRateLineControl3.IndirectText;
                        SaveData();
                    }
                    return;
                }
            }
            // 無ければ追加
            comboBox1.SelectedIndex = comboBox1.Items.Add(new DataEntry() {
                Name = name,
                Text1 = winRateLineControl1.IndirectText,
                Text2 = winRateLineControl2.IndirectText,
                Text3 = winRateLineControl3.IndirectText,
            });
            SaveData();
        }

        /// <summary>
        /// 読み込みボタン
        /// </summary>
        private void button3_Click(object sender, EventArgs e) {
            DataEntry ent = comboBox1.SelectedItem as DataEntry;
            if (ent != null) {
                textBox1.Text = ent.Name;
                winRateLineControl1.IndirectText = ent.Text1;
                winRateLineControl2.IndirectText = ent.Text2;
                winRateLineControl3.IndirectText = ent.Text3;
            }
        }

        /// <summary>
        /// 削除ボタン
        /// </summary>
        private void button4_Click(object sender, EventArgs e) {
            DataEntry ent = comboBox1.SelectedItem as DataEntry;
            if (ent != null) {
                if (MessageBox.Show(this, "'" + ent.Name + "' を削除します",
                    "確認", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                    comboBox1.Items.Remove(ent);
                    SaveData();
                }
            }
        }
    }
}
