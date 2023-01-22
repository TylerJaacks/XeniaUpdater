﻿using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace XeniaUpdater
{
    public partial class AboutDialog : Form
    {
        //KEEP \N AT THE END. GITHUB RETURNS TEXT FILES WITH THIS FOR SOME REASON
        //UPDATE CHECK WILL NOT WORK IF REMOVED.
        public string buildDate = "Build date: 08/10/2021 2110 GMT\n";
        public AboutDialog()
        {
            InitializeComponent();
            label3.Text = buildDate;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Process.Start("https://xenia.jp");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/xenia-project");
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.com/invite/Q9mxZf9");
        }
    }
}