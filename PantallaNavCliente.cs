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
            buttonAccept.Enabled = false;
            buttonCancel.Enabled = false;

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
            buttonAccept.Enabled = true;
            buttonCancel.Enabled = true;
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

            //insertar datos
            this.tableAdapterManager.UpdateAll(this.rentACarDataSet);

            //this.clientTableAdapter.Update(this.rentACarDataSet.client);

            buttonAccept.Enabled = false;
            buttonCancel.Enabled = false;

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.clientBindingSource.CancelEdit();
            buttonAccept.Enabled = false;
            buttonCancel.Enabled = false;
        }
    }
}
