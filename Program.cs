using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_A_Car_Definitivo
{



    static class globales
    {
        public static string userlogin;
    }
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Form7 form7 = new Form7();
            if (form7.ShowDialog() ==DialogResult.OK)
            {
                Application.EnableVisualStyles();
                // con esto explota -> Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());

            }
          

        }
    }
}
