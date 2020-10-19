using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Construja.App.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;

namespace Construja.App
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
            Application.Run(new Main());
        }
    }
}
