namespace Rent_A_Car_Definitivo
{
    partial class menuPrincipal
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
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonCerrarSesion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonUsuarios = new System.Windows.Forms.Button();
            this.buttonCargos = new System.Windows.Forms.Button();
            this.buttonReservas = new System.Windows.Forms.Button();
            this.buttonClientes = new System.Windows.Forms.Button();
            this.buttonVehiculos = new System.Windows.Forms.Button();
            this.panelApp = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonCambiarTamaño = new System.Windows.Forms.Button();
            this.buttonMinimizar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panelPrincipal.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelApp.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(135)))));
            this.panelPrincipal.Controls.Add(this.panelContenido);
            this.panelPrincipal.Controls.Add(this.panelMenu);
            this.panelPrincipal.Cursor = System.Windows.Forms.Cursors.No;
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(800, 450);
            this.panelPrincipal.TabIndex = 2;
            // 
            // panelContenido
            // 
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(127, 0);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(673, 450);
            this.panelContenido.TabIndex = 4;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(88)))));
            this.panelMenu.Controls.Add(this.buttonCerrarSesion);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.buttonUsuarios);
            this.panelMenu.Controls.Add(this.buttonCargos);
            this.panelMenu.Controls.Add(this.buttonReservas);
            this.panelMenu.Controls.Add(this.buttonClientes);
            this.panelMenu.Controls.Add(this.buttonVehiculos);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(127, 450);
            this.panelMenu.TabIndex = 3;
            // 
            // buttonCerrarSesion
            // 
            this.buttonCerrarSesion.Location = new System.Drawing.Point(26, 415);
            this.buttonCerrarSesion.Name = "buttonCerrarSesion";
            this.buttonCerrarSesion.Size = new System.Drawing.Size(75, 23);
            this.buttonCerrarSesion.TabIndex = 6;
            this.buttonCerrarSesion.Text = "Log out";
            this.buttonCerrarSesion.UseVisualStyleBackColor = true;
            this.buttonCerrarSesion.Click += new System.EventHandler(this.buttonCerrarSesion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rent_A_Car_Definitivo.Properties.Resources.logo_rent_a_car2;
            this.pictureBox1.Location = new System.Drawing.Point(15, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // buttonUsuarios
            // 
            this.buttonUsuarios.Location = new System.Drawing.Point(10, 311);
            this.buttonUsuarios.Name = "buttonUsuarios";
            this.buttonUsuarios.Size = new System.Drawing.Size(105, 40);
            this.buttonUsuarios.TabIndex = 4;
            this.buttonUsuarios.Text = "Usuarios";
            this.buttonUsuarios.UseVisualStyleBackColor = true;
            this.buttonUsuarios.Click += new System.EventHandler(this.buttonUsuarios_Click);
            // 
            // buttonCargos
            // 
            this.buttonCargos.Location = new System.Drawing.Point(10, 265);
            this.buttonCargos.Name = "buttonCargos";
            this.buttonCargos.Size = new System.Drawing.Size(105, 40);
            this.buttonCargos.TabIndex = 3;
            this.buttonCargos.Text = "Cargos";
            this.buttonCargos.UseVisualStyleBackColor = true;
            this.buttonCargos.Click += new System.EventHandler(this.buttonCargos_Click);
            // 
            // buttonReservas
            // 
            this.buttonReservas.Location = new System.Drawing.Point(10, 219);
            this.buttonReservas.Name = "buttonReservas";
            this.buttonReservas.Size = new System.Drawing.Size(105, 40);
            this.buttonReservas.TabIndex = 2;
            this.buttonReservas.Text = "Reserva";
            this.buttonReservas.UseVisualStyleBackColor = true;
            this.buttonReservas.Click += new System.EventHandler(this.buttonReservas_Click);
            // 
            // buttonClientes
            // 
            this.buttonClientes.Location = new System.Drawing.Point(10, 173);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Size = new System.Drawing.Size(103, 40);
            this.buttonClientes.TabIndex = 1;
            this.buttonClientes.Text = "Clientes";
            this.buttonClientes.UseVisualStyleBackColor = true;
            this.buttonClientes.Click += new System.EventHandler(this.buttonClientes_Click);
            // 
            // buttonVehiculos
            // 
            this.buttonVehiculos.Location = new System.Drawing.Point(10, 127);
            this.buttonVehiculos.Name = "buttonVehiculos";
            this.buttonVehiculos.Size = new System.Drawing.Size(103, 40);
            this.buttonVehiculos.TabIndex = 0;
            this.buttonVehiculos.Text = "Vehiculos";
            this.buttonVehiculos.UseVisualStyleBackColor = true;
            this.buttonVehiculos.Click += new System.EventHandler(this.buttonVehiculos_Click);
            // 
            // panelApp
            // 
            this.panelApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.panelApp.Controls.Add(this.flowLayoutPanel1);
            this.panelApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelApp.Location = new System.Drawing.Point(0, 0);
            this.panelApp.Name = "panelApp";
            this.panelApp.Size = new System.Drawing.Size(800, 33);
            this.panelApp.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonCerrar);
            this.flowLayoutPanel1.Controls.Add(this.buttonCambiarTamaño);
            this.flowLayoutPanel1.Controls.Add(this.buttonMinimizar);
            this.flowLayoutPanel1.Controls.Add(this.dateTimePicker1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 33);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelApp_MouseDown);
            this.flowLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelApp_MouseMove);
            this.flowLayoutPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelApp_MouseUp);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCerrar.Location = new System.Drawing.Point(771, 3);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(26, 20);
            this.buttonCerrar.TabIndex = 8;
            this.buttonCerrar.Text = "X";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // buttonCambiarTamaño
            // 
            this.buttonCambiarTamaño.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCambiarTamaño.Location = new System.Drawing.Point(741, 3);
            this.buttonCambiarTamaño.Name = "buttonCambiarTamaño";
            this.buttonCambiarTamaño.Size = new System.Drawing.Size(24, 20);
            this.buttonCambiarTamaño.TabIndex = 9;
            this.buttonCambiarTamaño.Text = "▢";
            this.buttonCambiarTamaño.UseVisualStyleBackColor = true;
            this.buttonCambiarTamaño.Click += new System.EventHandler(this.buttonCambiarTamaño_Click);
            // 
            // buttonMinimizar
            // 
            this.buttonMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMinimizar.Location = new System.Drawing.Point(706, 3);
            this.buttonMinimizar.Name = "buttonMinimizar";
            this.buttonMinimizar.Size = new System.Drawing.Size(29, 20);
            this.buttonMinimizar.TabIndex = 10;
            this.buttonMinimizar.Text = "—";
            this.buttonMinimizar.UseVisualStyleBackColor = true;
            this.buttonMinimizar.Click += new System.EventHandler(this.buttonMinimizar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(500, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // menuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelApp);
            this.Controls.Add(this.panelPrincipal);
            this.Name = "menuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menuPrincipal";
            this.Load += new System.EventHandler(this.menuPrincipal_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelApp.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonUsuarios;
        private System.Windows.Forms.Button buttonCargos;
        private System.Windows.Forms.Button buttonReservas;
        private System.Windows.Forms.Button buttonClientes;
        private System.Windows.Forms.Button buttonVehiculos;
        private System.Windows.Forms.Panel panelApp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonCambiarTamaño;
        private System.Windows.Forms.Button buttonMinimizar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Button buttonCerrarSesion;
    }
}