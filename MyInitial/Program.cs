
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyNameSpace
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //this is my modification on the sample feature branch
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new JuiceBarForm());
        }
    }
}