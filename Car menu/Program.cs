using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_menu
{
    /*
     * Finalize the Objects attributes
     * Create a new class (with main) to create all relevant vehicles (objects) and write the to a file (serialize) 
     * load the objects (deserialize) from the file(s) in the relevant forms.
     */
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
            Application.Run(new Form1());
            //Application.Run(new Form3());

        }
    }
}
