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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void contracteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contracteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rentACarDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rentACarDataSet.contracte' Puede moverla o quitarla según sea necesario.
            this.contracteTableAdapter.Fill(this.rentACarDataSet.contracte);

        }
    }
}
