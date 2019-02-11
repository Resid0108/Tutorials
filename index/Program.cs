using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestSslWebServices
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

            //Application.Run(new InvokeGenericWS());
            //Application.Run(new InvokeStarlimsWS());

            Application.Run(new Form1());
        }
    }
}