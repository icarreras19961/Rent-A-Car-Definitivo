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
            this.Validate(); //valida el contenido del campo actual

            //"cerrar" los text
            this.clientBindingSource.EndEdit();

            //Actualizar datos
            this.tableAdapterManager.UpdateAll(this.rentACarDataSet);
            //rehacer el origen de datos por 23 vez

            modoEdicion(false);

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
    }
}
