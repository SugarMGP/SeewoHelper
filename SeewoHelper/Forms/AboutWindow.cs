﻿using System;
using System.Windows.Forms;

namespace Console.Forms
{
    public partial class AboutWindow : Form
    {
        public AboutWindow()
        {
            InitializeComponent();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Mo-Ink");
        }

        private void AboutWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
