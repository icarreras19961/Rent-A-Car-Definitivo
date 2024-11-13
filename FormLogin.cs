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
    public partial class FormLogin : Form
    {
        int Intentos = 0;
        

        public FormLogin()
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

            
            //Aqui es donde ira el comprobador de si se ha pasado validacion de usuario
            if (reader.HasRows)
            {
                //Para utilizar los valores de la query como datos normales
                reader.Read();
                //Los datos se extraen de la manera que pone el if
                if (reader.GetBoolean(5).ToString()=="True")
                {
                    MessageBox.Show("El Usuario "+user_login+" esta bloqueado");
                }
                else
                {
                    //Si el user no esta bloqueado
                    globales.userlogin = user_login;
                    DialogResult = DialogResult.OK;
                }
                
            }
            else
            {
                //Cuando el user falla 
                textBox2.Text = "";
                Intentos++;
                label4.Text = " Contraseña incorrectos\nIntentos: " + Intentos+" / 3";
                if (Intentos == 3)
                {
                    //Antes de hacer una query nueva, se cierra la anterior
                    reader.Close();
                    String sql2 = $"UPDATE users SET bloq_user = 'True' WHERE nombre='{tbUser.Text}'";
                    SqlCommand com = new SqlCommand(sql2, conn);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Usuario Bloqueado");
                }           
                
            }
            reader.Close();
        }
    }
}