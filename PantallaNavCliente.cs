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
    public partial class PantallaNavCliente : Form
    {
        public PantallaNavCliente()
        {
            InitializeComponent();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rentACarDataSet);

        }

        private void clientBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rentACarDataSet);

        }

        private void PantallaNavCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rentACarDataSet.client' Puede moverla o quitarla según sea necesario.
            this.clientTableAdapter.Fill(this.rentACarDataSet.client);
            // TODO: esta línea de código carga datos en la tabla 'rentACarDataSet.client' Puede moverla o quitarla según sea necesario.
            this.clientTableAdapter.Fill(this.rentACarDataSet.client);
           
            modoEdicion(false);

        }

        private void buttonPrimero_Click(object sender, EventArgs e)
        {
            this.clientBindingSource.MoveFirst();
        }

        private void buttonPrevio_Click(object sender, EventArgs e)
        {
            this.clientBindingSource.MovePrevious();
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            this.clientBindingSource.MoveNext();
        }

        private void buttonUltimo_Click(object sender, EventArgs e)
        {
            this.clientBindingSource.MoveLast();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            this.clientBindingSource.AddNew();
            modoEdicion(true);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
          
            MessageBox.Show("¿Estás seguro de que quieres borrar este registro?", "Borrar registro", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
                this.clientBindingSource.RemoveCurrent();
            }
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            //Validar datos
            if (validadorIdentificador())
            {

                this.Validate(); //valida el contenido del campo actual

                //"cerrar" los text
                this.clientBindingSource.EndEdit();

                //Actualizar datos
                this.tableAdapterManager.UpdateAll(this.rentACarDataSet);
                //rehacer el origen de datos por 23 vez

                modoEdicion(false);
            }
            else
            {
                MessageBox.Show("El identificador no es correcto");
                dniTextBox.Focus();
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

            this.clientBindingSource.CancelEdit();
            dniTextBox.Text = "";
            nomTextBox.Text = "";
            cognomTextBox.Text = "";
            dniTextBox.Text = "";
            poblacioTextBox.Text = "";

            modoEdicion(false);

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
          modoEdicion(true);

        }

        //una funcion que detecte cuando entras en modo edicion y mediante un foreach se habiliten los botones de aceptar y cancelar
        //ademas de desabilitar los botones de navegacion, ademas de esto se comprobara si la base de datos esta vacia y si lo esta 
        //no se podran utilizar los botones eliminar y modificar

        public void modoEdicion(bool estaEditanto)
        {
            //Habilitar los botones de navegacion
            foreach (Control item in panel6.Controls)
            {
                item.Enabled = !estaEditanto; 
            }
            //Habilitar los campos de texto del panel central
            foreach (Control item in panel7.Controls)
            {
                item.Enabled = estaEditanto;
            }

            //habilitar botones de aceptar y cancelar
            foreach (Control item in panel5.Controls)
            {
                item.Enabled = estaEditanto;
            }
            
        }

        private void clientBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rentACarDataSet);

        }

        private Boolean validadorIdentificador()
        {
            String identificador = dniTextBox.Text.ToUpper();
            char[] chars = identificador.ToCharArray();
            char[] letras = "TRWAGMYFPDXBNJZSQVHLCKE".ToCharArray();
            if (chars[0]== 'X'|| chars[0] == 'Y'|| chars[0] == 'Z')
            {
                char[] nif = new char[chars.Length+1];
                switch (chars[0])
                {
                    case 'X':
                        
                        nif[0] = '0';
                        break;
                    case 'Y':
                        
                        nif[0] = '1';
                        break;
                    case 'Z':
                        
                        nif[0] = '2';
                        break;
                }
                for (int i = 1; i <= chars.Length-1; i++)
                {
                    try
                    {
                    if (Char.IsDigit(chars[i])) 
                    {
                    nif[i] = chars[i]; 
                        
                    }

                    }catch (Exception e)
                    {
                        MessageBox.Show("Me he pasado");
                        break;
                    }
                }
                String nifString = new string(nif).TrimEnd('\0');

                int numero = Convert.ToInt32(nifString);
                int resto = numero % 23;
                char letra;
                letra = letras[resto];
                
                nifString += letra;

                char[] nifChar = nifString.ToCharArray();
                
                switch (nifChar[0])
                {
                    case '0':

                        nifChar[0] = 'X';
                        break;
                    case '1':

                        nifChar[0] = 'Y';
                        break;
                    case '2':

                        nifChar[0] = 'Z';
                        break;
                }
                String nifDef = new string(nifChar);
                MessageBox.Show(identificador + "" + nifDef);

                if(!identificador.Equals(nifDef))
                {
                    return false;
                    
                }
                return true;

            }
            else if (Char.IsDigit(chars[0]))
            {
                char[] nif = new char[chars.Length];

                for (int i = 0; i <= chars.Length-2; i++)
                {
                    nif[i] = chars[i];
                }

                String nifString = new string(nif).TrimEnd('\0');
                int numero = Convert.ToInt32(nifString);
                int resto = numero % 23;
                char letra;
                letra = letras[resto];
                nifString += letra;
                char[] nifChar = nifString.ToCharArray();
                String nifDef = new string(nifChar);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            validadorIdentificador();
        }
}
}
