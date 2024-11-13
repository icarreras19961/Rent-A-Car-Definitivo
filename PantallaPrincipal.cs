using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Rent_A_Car_Definitivo
{
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVehiculos form2 = new FormVehiculos();
            form2.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente form3 = new FormCliente();
            form3.ShowDialog();
        }

        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReserva form4 = new FormReserva();
            form4.ShowDialog();
        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormContrato form5 = new FormContrato();
            form5.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuarios form6 = new FormUsuarios();
            form6.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String nombre = globales.userlogin;

            SqlConnection conn = new SqlConnection("Server=localhost\\SQLEXPRESS;DATABASE=RentACar;User id=RentACar_user;password=1234;trusted_Connection=true;TrustServerCertificate=true");
            conn.Open();

            String sql = $"SELECT * FROM dbo.restricciones WHERE nombreUser='{nombre}'";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                    {
                        String restriccion = reader.GetString(1);

                        foreach (ToolStripMenuItem item in menuStrip1.Items)
                        {
                            if (restriccion.Equals(item.Text))
                            {
                                item.Visible = false;
                            }
                        }
                    }
                }
            }
        }
    }
}
