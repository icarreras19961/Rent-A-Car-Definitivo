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
    public partial class PantallaNavVehiculo : Form
    {
        public PantallaNavVehiculo()
        {
            InitializeComponent();

        }

        private void vehicleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vehicleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rentACarDataSet);
            modoEdicion(false);
        }

        private void PantallaNavVehiculo_Load(object sender, EventArgs e)
        {
            
            // TODO: esta línea de código carga datos en la tabla 'rentACarDataSet.models' Puede moverla o quitarla según sea necesario.
            this.modelsTableAdapter.Fill(this.rentACarDataSet.models);
            // TODO: esta línea de código carga datos en la tabla 'rentACarDataSet.marcas' Puede moverla o quitarla según sea necesario.
            this.marcasTableAdapter.Fill(this.rentACarDataSet.marcas);
            // TODO: esta línea de código carga datos en la tabla 'rentACarDataSet.tipologias' Puede moverla o quitarla según sea necesario.
            this.tipologiasTableAdapter.Fill(this.rentACarDataSet.tipologias);
            // TODO: esta línea de código carga datos en la tabla 'rentACarDataSet.vehicle' Puede moverla o quitarla según sea necesario.
            this.vehicleTableAdapter.Fill(this.rentACarDataSet.vehicle);
            // TODO: esta línea de código carga datos en la tabla 'rentACarDataSet.tipologias' Puede moverla o quitarla según sea necesario.
            this.vehicleTableAdapter.Fill(this.rentACarDataSet.vehicle);

            modoEdicion(false);
        }

        private void buttonPrimero_Click(object sender, EventArgs e)
        {
            this.vehicleBindingSource.MoveFirst();
        }

        private void buttonPrevio_Click(object sender, EventArgs e)
        {
            this.vehicleBindingSource.MovePrevious();
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            this.vehicleBindingSource.MoveNext();
        }

        private void buttonUltimo_Click(object sender, EventArgs e)
        {
            this.vehicleBindingSource.MoveLast();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            this.vehicleBindingSource.AddNew();
            modoEdicion(true);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            MessageBox.Show("¿Estás seguro de que quieres borrar este registro?", "Borrar registro", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
                this.vehicleBindingSource.RemoveCurrent();
            }
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            //Validar datos
            this.Validate(); //valida el contenido del campo actual

            //"cerrar" los text
            this.vehicleBindingSource.EndEdit();

            //Actualizar datos
            this.tableAdapterManager.UpdateAll(this.rentACarDataSet);

            modoEdicion(false);

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

            this.vehicleBindingSource.CancelEdit();
            matriculaTextBox.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            colorTextBox.Text = "";

            modoEdicion(false);

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            modoEdicion(true);

        }
        public void modoEdicion(bool estaEditanto)
        {
            //Habilitar los botones de navegacion
            foreach (Control item in panel5.Controls)
            {
                item.Enabled = !estaEditanto;
            }
            //Habilitar los campos de texto del panel central
            foreach (Control item in panel4.Controls)
            {
                item.Enabled = estaEditanto;
            }

            //habilitar botones de aceptar y cancelar
            foreach (Control item in panel6.Controls)
            {
                item.Enabled = estaEditanto;
            }

        }

        private void vehicleBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.vehicleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rentACarDataSet);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.modelsBindingSource.Filter = "tipologia = '" + comboBox1.Text + "'";
            this.marcasBindingSource.Filter = "tipologia = '" + comboBox1.Text + "'";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.modelsBindingSource.Filter = "marca = '" + comboBox2.Text + "' AND tipologia = '" + comboBox1.Text + "'";

        }

    }
}
