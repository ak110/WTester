namespace WTester {
    partial class MainForm {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.winRateControl1 = new WTester.WinRateControl();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // winRateControl1
            // 
            this.winRateControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.winRateControl1.Location = new System.Drawing.Point(0, 84);
            this.winRateControl1.Name = "winRateControl1";
            this.winRateControl1.Size = new System.Drawing.Size(708, 237);
            this.winRateControl1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 72);
            this.label1.TabIndex = 2;
            this.label1.Text = "勝敗数を入力すると、横に勝率等を算出して表示します。\r\n\r\n　勝率：引き分けは0.5勝・0.5敗扱いでの勝率。\r\n　R差：勝率からBradley-Terry モデ" +
    "ルでレーティングの差を算出したもの。\r\n　95%信頼区間：信頼水準95%での勝率の信頼区間。引き分けは無視します。\r\n　有意確率：相手に対して統計的に有意に強い" +
    "と言えない確率。引き分けは無視します。";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.winRateControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "勝率計算機";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinRateControl winRateControl1;
        private System.Windows.Forms.Label label1;


    }
}

