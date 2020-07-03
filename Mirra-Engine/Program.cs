using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mirra_Engine
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

            // Entry Point.. 
            // TODO: 
            // Abstract out Engine class
            // ... 
            // ... 
            // ----> Login ---> New Project/Open Project --> Engine Window 
            Application.Run(new Engine());
        }
    }
}
