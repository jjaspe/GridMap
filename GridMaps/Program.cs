using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GridMaps
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
            GridMapsView view=new GridMapsView();
            view.Start();
        }
    }
}
