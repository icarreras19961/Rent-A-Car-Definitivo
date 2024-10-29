using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_A_Car_Definitivo
{
    public partial class menuPrincipal : Form
    {
        Boolean pequeno = false;
        Boolean arrastrar=false;
        public menuPrincipal()
        {
            InitializeComponent();
        }

        //El panelapp
        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCambiarTamaño_Click(object sender, EventArgs e)
        {
            if (pequeno)
            {
                WindowState = FormWindowState.Maximized;
                pequeno = false;
                buttonCambiarTamaño.Text = "◳";
            }
            else
            {
                WindowState = FormWindowState.Normal;
                pequeno = true;
                buttonCambiarTamaño.Text = "□";

            }
        }

        private void buttonMinimizar_Click(object sender, EventArgs e)
        {
             this.WindowState = FormWindowState.Minimized;
        }

        private void panelApp_MouseMove(object sender, MouseEventArgs e)
        {
            if (arrastrar)
            {
                this.Location = MousePosition;
            }
        }

        private void panelApp_MouseUp(object sender, MouseEventArgs e)
        {
            arrastrar = false;
        }

        private void panelApp_MouseDown(object sender, MouseEventArgs e)
        {
            arrastrar = true;
        }

        //Los botones de menu
        private void AbrirFormhijo(object formhijo)
        {
            if (this.panelContenido.Controls.Count > 0)
                this.panelContenido.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenido.Controls.Add(fh);
            this.panelContenido.Tag = fh;
            fh.Show();
        }
        private void buttonVehiculos_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new FormVehiculos());
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new FormCliente());
        }

        private void buttonReservas_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new FormReserva());
        }

        private void buttonCargos_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new FormContrato());
        }

        private void buttonUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new FormUsuarios());
        }
    }
}
