using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Rent_A_Car_Definitivo
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user_login = tbUser.Text;

            SqlConnection conn = new SqlConnection("Server=localhost\\SQLEXPRESS;DATABASE=RentACar;User id=RentACar_user;password=1234;trusted_Connection=true;TrustServerCertificate=true");

            conn.Open();

            String sql = $"SELECT * FROM users WHERE nombre='{tbUser.Text}' AND pwd = '{textBox2.Text}'";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                String line = reader.ReadLine();
                MessageBox.Show(line);
                //user_login = reader.GetString(1);
                MessageBox.Show("Bienvenido " + user_login);
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

       
    }
}
