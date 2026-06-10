namespace ProyPapeleta_GUI
{
    partial class InfraccionMan03
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
            dtgInfraccion = new DataGridView();
            label1 = new Label();
            txtFiltro = new TextBox();
            btnRefrescar = new Button();
            btnInsertar = new Button();
            btnEliminar = new Button();
            label3 = new Label();
            lblRegistros = new Label();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgInfraccion).BeginInit();
            SuspendLayout();
            // 
            // dtgInfraccion
            // 
            dtgInfraccion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgInfraccion.Location = new Point(121, 166);
            dtgInfraccion.Margin = new Padding(6);
            dtgInfraccion.Name = "dtgInfraccion";
            dtgInfraccion.RowHeadersWidth = 82;
            dtgInfraccion.Size = new Size(1218, 538);
            dtgInfraccion.TabIndex = 0;
            dtgInfraccion.CellContentClick += dtgInfraccion_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 68);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(317, 32);
            label1.TabIndex = 7;
            label1.Text = "Ingrese codigo de infraccion";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(446, 62);
            txtFiltro.Margin = new Padding(6, 4, 6, 4);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(767, 39);
            txtFiltro.TabIndex = 8;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new Point(121, 753);
            btnRefrescar.Margin = new Padding(6, 4, 6, 4);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(193, 73);
            btnRefrescar.TabIndex = 31;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(400, 753);
            btnInsertar.Margin = new Padding(6, 4, 6, 4);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(228, 73);
            btnInsertar.TabIndex = 32;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(720, 753);
            btnEliminar.Margin = new Padding(6, 4, 6, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(243, 73);
            btnEliminar.TabIndex = 34;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1021, 753);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(115, 32);
            label3.TabIndex = 35;
            label3.Text = "Registros:";
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(1140, 732);
            lblRegistros.Margin = new Padding(6, 0, 6, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(197, 72);
            lblRegistros.TabIndex = 36;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1162, 821);
            btnSalir.Margin = new Padding(6, 4, 6, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(152, 73);
            btnSalir.TabIndex = 37;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // InfraccionMan03
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1447, 907);
            Controls.Add(btnSalir);
            Controls.Add(lblRegistros);
            Controls.Add(label3);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(btnRefrescar);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            Controls.Add(dtgInfraccion);
            Margin = new Padding(6);
            Name = "InfraccionMan03";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar Infracción";
            Load += InfraccionMan05_Load;
            ((System.ComponentModel.ISupportInitialize)dtgInfraccion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgInfraccion;
        private Label label1;
        private TextBox txtFiltro;
        private Button btnRefrescar;
        private Button btnInsertar;
        private Button btnEliminar;
        private Label label3;
        private Label lblRegistros;
        private Button btnSalir;
    }
}