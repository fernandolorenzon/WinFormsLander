using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinFormsLander.Forms;

namespace WinFormsLander
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormMain stage = new FormMain();
            //FormTest test = new FormTest();
            Application.Run(stage);
        }
    }
}
