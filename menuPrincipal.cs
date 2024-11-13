using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Rent_A_Car_Definitivo
{
    public partial class menuPrincipal : Form
    {
        Boolean pequeno = false;
        Boolean arrastrar = false;
        public menuPrincipal()
        {
            InitializeComponent();

        }
        //Los permisos de los usuarios con los botones
        private void menuPrincipal_Load(object sender, EventArgs e)
        {
            String nombre = globales.userlogin;

            SqlConnection conn = new SqlConnection("Server=localhost\\SQLEXPRESS;DATABASE=RentACar;User id=RentACar_user;password=1234;trusted_Connection=true;TrustServerCertificate=true");
            conn.Open();

            String sql = $"SELECT * FROM dbo.users WHERE nombre='{nombre}'";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    String rol = reader.GetString(4);
                    if (rol == "admin")
                    {
                        //El admin ve todos los botones
                    }
                    else if (rol == "empleado")
                    {
                        //El empleado no ve los botones de usuarios y cargos
                        buttonUsuarios.Visible = false;
                        buttonCargos.Visible = false;
                    }
                    else if (rol == "cliente")
                    {
                        //El cliente no puede ver todos los usuarios, los cargos ni los clientes de la app
                        buttonUsuarios.Visible = false;
                        buttonCargos.Visible = false;
                        buttonClientes.Visible = false;

                    }
                }
            }
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
            AbrirFormhijo(new PantallaNavCliente());
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

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            //cierra la ventana y reinicia la app
            this.Close();
            Application.Restart();
            Environment.Exit(0);//apaga la app a lo bruto
        }
    }
}
