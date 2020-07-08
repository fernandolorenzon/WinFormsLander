using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsLander.Classes;

namespace WinFormsLander.Forms
{
    public partial class FormClear : WinFormsLander.Forms.FormBase
    {
        public FormClear()
        {
            InitializeComponent();
        }

        private void FormClear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)System.Windows.Forms.Keys.Return)
            {
                this.labelMessage1.Text = "";
                this.labelMessage2.Text = "";
                this.labelMessage3.Text = "";

                Globals.FormMain.Visible = true;
                this.Visible = false;
            }
        }
    }
}
