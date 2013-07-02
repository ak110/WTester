using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WTester {
    public partial class MainForm : Form {
        /// <summary>
        /// 初期化。
        /// </summary>
        public MainForm() {
            InitializeComponent();

            int build = System.Diagnostics.Process.GetCurrentProcess()
                .MainModule.FileVersionInfo.FileBuildPart;
            Text = "勝率計算機 build-" + build;
        }

        /// <summary>
        /// 後始末。
        /// </summary>
        private void MainForm1_FormClosing(object sender, FormClosingEventArgs e) {

        }
    }
}