namespace Rent_A_Car_Definitivo
{
    partial class PantallaNavCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dniLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label cognomLabel;
            System.Windows.Forms.Label direccioLabel;
            System.Windows.Forms.Label poblacioLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonPrimero = new System.Windows.Forms.Button();
            this.buttonPrevio = new System.Windows.Forms.Button();
            this.buttonSiguiente = new System.Windows.Forms.Button();
            this.buttonUltimo = new System.Windows.Forms.Button();
            this.rentACarDataSet = new Rent_A_Car_Definitivo.RentACarDataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Rent_A_Car_Definitivo.RentACarDataSetTableAdapters.clientTableAdapter();
            this.tableAdapterManager = new Rent_A_Car_Definitivo.RentACarDataSetTableAdapters.TableAdapterManager();
            this.clientDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.cognomTextBox = new System.Windows.Forms.TextBox();
            this.direccioTextBox = new System.Windows.Forms.TextBox();
            this.poblacioTextBox = new System.Windows.Forms.TextBox();
            dniLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            cognomLabel = new System.Windows.Forms.Label();
            direccioLabel = new System.Windows.Forms.Label();
            poblacioLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentACarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 379);
            this.panel4.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.AutoScroll = true;
            this.panel8.Controls.Add(this.clientDataGridView);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(281, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(519, 379);
            this.panel8.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(poblacioLabel);
            this.panel7.Controls.Add(this.poblacioTextBox);
            this.panel7.Controls.Add(direccioLabel);
            this.panel7.Controls.Add(this.direccioTextBox);
            this.panel7.Controls.Add(cognomLabel);
            this.panel7.Controls.Add(this.cognomTextBox);
            this.panel7.Controls.Add(nomLabel);
            this.panel7.Controls.Add(this.nomTextBox);
            this.panel7.Controls.Add(dniLabel);
            this.panel7.Controls.Add(this.dniTextBox);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(281, 379);
            this.panel7.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 414);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 36);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonCancel);
            this.panel5.Controls.Add(this.buttonAccept);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(635, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(165, 36);
            this.panel5.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(95, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(33, 30);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "X";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(33, 3);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(33, 30);
            this.buttonAccept.TabIndex = 0;
            this.buttonAccept.Text = "✓";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 35);
            this.panel2.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.buttonModificar);
            this.panel6.Controls.Add(this.buttonDelete);
            this.panel6.Controls.Add(this.buttonInsert);
            this.panel6.Controls.Add(this.buttonPrimero);
            this.panel6.Controls.Add(this.buttonPrevio);
            this.panel6.Controls.Add(this.buttonSiguiente);
            this.panel6.Controls.Add(this.buttonUltimo);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(354, 35);
            this.panel6.TabIndex = 0;
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(245, 2);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(33, 30);
            this.buttonModificar.TabIndex = 9;
            this.buttonModificar.Text = "∑";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(285, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(33, 30);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "⌀";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(206, 2);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(33, 30);
            this.buttonInsert.TabIndex = 7;
            this.buttonInsert.Text = "+";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonPrimero
            // 
            this.buttonPrimero.Location = new System.Drawing.Point(19, 2);
            this.buttonPrimero.Name = "buttonPrimero";
            this.buttonPrimero.Size = new System.Drawing.Size(33, 30);
            this.buttonPrimero.TabIndex = 6;
            this.buttonPrimero.Text = "⟪";
            this.buttonPrimero.UseVisualStyleBackColor = true;
            this.buttonPrimero.Click += new System.EventHandler(this.buttonPrimero_Click);
            // 
            // buttonPrevio
            // 
            this.buttonPrevio.Location = new System.Drawing.Point(58, 2);
            this.buttonPrevio.Name = "buttonPrevio";
            this.buttonPrevio.Size = new System.Drawing.Size(33, 30);
            this.buttonPrevio.TabIndex = 5;
            this.buttonPrevio.Text = "<";
            this.buttonPrevio.UseVisualStyleBackColor = true;
            this.buttonPrevio.Click += new System.EventHandler(this.buttonPrevio_Click);
            // 
            // buttonSiguiente
            // 
            this.buttonSiguiente.Location = new System.Drawing.Point(97, 2);
            this.buttonSiguiente.Name = "buttonSiguiente";
            this.buttonSiguiente.Size = new System.Drawing.Size(33, 30);
            this.buttonSiguiente.TabIndex = 4;
            this.buttonSiguiente.Text = ">";
            this.buttonSiguiente.UseVisualStyleBackColor = true;
            this.buttonSiguiente.Click += new System.EventHandler(this.buttonSiguiente_Click);
            // 
            // buttonUltimo
            // 
            this.buttonUltimo.Location = new System.Drawing.Point(136, 2);
            this.buttonUltimo.Name = "buttonUltimo";
            this.buttonUltimo.Size = new System.Drawing.Size(33, 30);
            this.buttonUltimo.TabIndex = 1;
            this.buttonUltimo.Text = "⟫";
            this.buttonUltimo.UseVisualStyleBackColor = true;
            this.buttonUltimo.Click += new System.EventHandler(this.buttonUltimo_Click);
            // 
            // rentACarDataSet
            // 
            this.rentACarDataSet.DataSetName = "RentACarDataSet";
            this.rentACarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.rentACarDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.carrecsTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.contracteTableAdapter = null;
            this.tableAdapterManager.reservaTableAdapter = null;
            this.tableAdapterManager.restriccionesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Rent_A_Car_Definitivo.RentACarDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            this.tableAdapterManager.vehicleTableAdapter = null;
            // 
            // clientDataGridView
            // 
            this.clientDataGridView.AutoGenerateColumns = false;
            this.clientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.clientDataGridView.DataSource = this.clientBindingSource;
            this.clientDataGridView.Location = new System.Drawing.Point(6, 6);
            this.clientDataGridView.Name = "clientDataGridView";
            this.clientDataGridView.Size = new System.Drawing.Size(501, 370);
            this.clientDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "dni";
            this.dataGridViewTextBoxColumn1.HeaderText = "dni";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nom";
            this.dataGridViewTextBoxColumn2.HeaderText = "nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cognom";
            this.dataGridViewTextBoxColumn3.HeaderText = "cognom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "direccio";
            this.dataGridViewTextBoxColumn4.HeaderText = "direccio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "poblacio";
            this.dataGridViewTextBoxColumn5.HeaderText = "poblacio";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dniLabel
            // 
            dniLabel.AutoSize = true;
            dniLabel.Location = new System.Drawing.Point(67, 100);
            dniLabel.Name = "dniLabel";
            dniLabel.Size = new System.Drawing.Size(24, 13);
            dniLabel.TabIndex = 0;
            dniLabel.Text = "dni:";
            // 
            // dniTextBox
            // 
            this.dniTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "dni", true));
            this.dniTextBox.Location = new System.Drawing.Point(97, 97);
            this.dniTextBox.Name = "dniTextBox";
            this.dniTextBox.Size = new System.Drawing.Size(100, 20);
            this.dniTextBox.TabIndex = 1;
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(61, 126);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(30, 13);
            nomLabel.TabIndex = 2;
            nomLabel.Text = "nom:";
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "nom", true));
            this.nomTextBox.Location = new System.Drawing.Point(97, 123);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomTextBox.TabIndex = 3;
            // 
            // cognomLabel
            // 
            cognomLabel.AutoSize = true;
            cognomLabel.Location = new System.Drawing.Point(43, 152);
            cognomLabel.Name = "cognomLabel";
            cognomLabel.Size = new System.Drawing.Size(48, 13);
            cognomLabel.TabIndex = 4;
            cognomLabel.Text = "cognom:";
            // 
            // cognomTextBox
            // 
            this.cognomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "cognom", true));
            this.cognomTextBox.Location = new System.Drawing.Point(97, 149);
            this.cognomTextBox.Name = "cognomTextBox";
            this.cognomTextBox.Size = new System.Drawing.Size(100, 20);
            this.cognomTextBox.TabIndex = 5;
            // 
            // direccioLabel
            // 
            direccioLabel.AutoSize = true;
            direccioLabel.Location = new System.Drawing.Point(44, 178);
            direccioLabel.Name = "direccioLabel";
            direccioLabel.Size = new System.Drawing.Size(47, 13);
            direccioLabel.TabIndex = 6;
            direccioLabel.Text = "direccio:";
            // 
            // direccioTextBox
            // 
            this.direccioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "direccio", true));
            this.direccioTextBox.Location = new System.Drawing.Point(97, 175);
            this.direccioTextBox.Name = "direccioTextBox";
            this.direccioTextBox.Size = new System.Drawing.Size(100, 20);
            this.direccioTextBox.TabIndex = 7;
            // 
            // poblacioLabel
            // 
            poblacioLabel.AutoSize = true;
            poblacioLabel.Location = new System.Drawing.Point(41, 204);
            poblacioLabel.Name = "poblacioLabel";
            poblacioLabel.Size = new System.Drawing.Size(50, 13);
            poblacioLabel.TabIndex = 8;
            poblacioLabel.Text = "poblacio:";
            // 
            // poblacioTextBox
            // 
            this.poblacioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "poblacio", true));
            this.poblacioTextBox.Location = new System.Drawing.Point(97, 201);
            this.poblacioTextBox.Name = "poblacioTextBox";
            this.poblacioTextBox.Size = new System.Drawing.Size(100, 20);
            this.poblacioTextBox.TabIndex = 9;
            // 
            // PantallaNavCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "PantallaNavCliente";
            this.Text = "PantallaNavegacion";
            this.Load += new System.EventHandler(this.PantallaNavCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rentACarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonPrimero;
        private System.Windows.Forms.Button buttonPrevio;
        private System.Windows.Forms.Button buttonSiguiente;
        private System.Windows.Forms.Button buttonUltimo;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonModificar;
        private RentACarDataSet rentACarDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private RentACarDataSetTableAdapters.clientTableAdapter clientTableAdapter;
        private RentACarDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView clientDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox poblacioTextBox;
        private System.Windows.Forms.TextBox direccioTextBox;
        private System.Windows.Forms.TextBox cognomTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox dniTextBox;
    }
}