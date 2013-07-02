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
			this.SuspendLayout();
			// 
			// winRateControl1
			// 
			this.winRateControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.winRateControl1.Location = new System.Drawing.Point(0, 0);
			this.winRateControl1.Name = "winRateControl1";
			this.winRateControl1.Size = new System.Drawing.Size(708, 180);
			this.winRateControl1.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(708, 180);
			this.Controls.Add(this.winRateControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "勝率計算機";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm1_FormClosing);
			this.ResumeLayout(false);

		}

		#endregion

		private WinRateControl winRateControl1;


	}
}

