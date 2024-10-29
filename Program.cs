using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_A_Car_Definitivo
{



    public static class globales
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
            //Para probar el menu principal
            Application.EnableVisualStyles();
            
            //La app aki Funciona
            FormLogin form7 = new FormLogin();
            if (form7.ShowDialog() == DialogResult.OK)
            {
                menuPrincipal formprincipal = new menuPrincipal();
                Application.Run(formprincipal);

                //Antes del nuevo entorno grafico
                //Application.EnableVisualStyles();
                //// con esto explota -> Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new PantallaPrincipal());

            }


        }
    }
}
