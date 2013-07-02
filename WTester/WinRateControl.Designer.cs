namespace WTester {
	partial class WinRateControl {
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

		#region コンポーネント デザイナで生成されたコード

		/// <summary> 
		/// デザイナ サポートに必要なメソッドです。このメソッドの内容を 
		/// コード エディタで変更しないでください。
		/// </summary>
		private void InitializeComponent() {
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.winRateLineControl4 = new WTester.WinRateLineControl();
			this.winRateLineControl3 = new WTester.WinRateLineControl();
			this.winRateLineControl2 = new WTester.WinRateLineControl();
			this.winRateLineControl1 = new WTester.WinRateLineControl();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(126, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "勝敗数(勝ち-分け-負け)";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(56, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(17, 12);
			this.label3.TabIndex = 5;
			this.label3.Text = "＋";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(56, 88);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(17, 12);
			this.label7.TabIndex = 9;
			this.label7.Text = "＋";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(64, 128);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(11, 12);
			this.label10.TabIndex = 13;
			this.label10.Text = "||";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(160, 8);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(317, 12);
			this.label13.TabIndex = 3;
			this.label13.Text = "勝敗数/合計　　　　　　勝率　　 95%信頼区間 有意確率　　R差";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(17, 12);
			this.label2.TabIndex = 17;
			this.label2.Text = "①";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(16, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(17, 12);
			this.label4.TabIndex = 17;
			this.label4.Text = "②";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(16, 112);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(17, 12);
			this.label5.TabIndex = 17;
			this.label5.Text = "③";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(8, 152);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(29, 12);
			this.label6.TabIndex = 17;
			this.label6.Text = "合計";
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(496, 144);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(72, 23);
			this.button1.TabIndex = 18;
			this.button1.Text = "①へコピー";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(592, 16);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(47, 12);
			this.label8.TabIndex = 19;
			this.label8.Text = "保存名：";
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Location = new System.Drawing.Point(592, 32);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 19);
			this.textBox1.TabIndex = 20;
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.Location = new System.Drawing.Point(616, 56);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 21;
			this.button2.Text = "保存(&S)";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(568, 96);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 20);
			this.comboBox1.Sorted = true;
			this.comboBox1.TabIndex = 22;
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button3.Location = new System.Drawing.Point(616, 120);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 23;
			this.button3.Text = "読み込み(&L)";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button4.Location = new System.Drawing.Point(616, 144);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 24;
			this.button4.Text = "削除(&D)";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// winRateLineControl4
			// 
			this.winRateLineControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.winRateLineControl4.CountReadOnly = true;
			this.winRateLineControl4.IndirectText = "0-0-0";
			this.winRateLineControl4.Location = new System.Drawing.Point(40, 144);
			this.winRateLineControl4.Name = "winRateLineControl4";
			this.winRateLineControl4.Size = new System.Drawing.Size(512, 23);
			this.winRateLineControl4.TabIndex = 16;
			// 
			// winRateLineControl3
			// 
			this.winRateLineControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.winRateLineControl3.CountReadOnly = false;
			this.winRateLineControl3.IndirectText = "0-0-0";
			this.winRateLineControl3.Location = new System.Drawing.Point(40, 104);
			this.winRateLineControl3.Name = "winRateLineControl3";
			this.winRateLineControl3.Size = new System.Drawing.Size(514, 23);
			this.winRateLineControl3.TabIndex = 12;
			this.winRateLineControl3.ValueChanged += new System.EventHandler(this.winRateLineControl3_ValueChanged);
			// 
			// winRateLineControl2
			// 
			this.winRateLineControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.winRateLineControl2.CountReadOnly = false;
			this.winRateLineControl2.IndirectText = "0-0-0";
			this.winRateLineControl2.Location = new System.Drawing.Point(40, 64);
			this.winRateLineControl2.Name = "winRateLineControl2";
			this.winRateLineControl2.Size = new System.Drawing.Size(514, 23);
			this.winRateLineControl2.TabIndex = 8;
			this.winRateLineControl2.ValueChanged += new System.EventHandler(this.winRateLineControl2_ValueChanged);
			// 
			// winRateLineControl1
			// 
			this.winRateLineControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.winRateLineControl1.CountReadOnly = false;
			this.winRateLineControl1.IndirectText = "0-0-0";
			this.winRateLineControl1.Location = new System.Drawing.Point(40, 24);
			this.winRateLineControl1.Name = "winRateLineControl1";
			this.winRateLineControl1.Size = new System.Drawing.Size(514, 23);
			this.winRateLineControl1.TabIndex = 4;
			this.winRateLineControl1.ValueChanged += new System.EventHandler(this.winRateLineControl1_ValueChanged);
			// 
			// WinRateControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.winRateLineControl4);
			this.Controls.Add(this.winRateLineControl3);
			this.Controls.Add(this.winRateLineControl2);
			this.Controls.Add(this.winRateLineControl1);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Name = "WinRateControl";
			this.Size = new System.Drawing.Size(704, 184);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label13;
		private WinRateLineControl winRateLineControl1;
		private WinRateLineControl winRateLineControl2;
		private WinRateLineControl winRateLineControl3;
		private WinRateLineControl winRateLineControl4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
	}
}
