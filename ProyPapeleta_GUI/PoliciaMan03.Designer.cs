namespace ProyPapeleta_GUI
{
    partial class PoliciaMan03
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
            dtgPolicia = new DataGridView();
            txtFiltrooo = new TextBox();
            label1 = new Label();
            lblRegistros = new Label();
            label3 = new Label();
            btnSalir = new Button();
            btnEliminar = new Button();
            btnInsertar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgPolicia).BeginInit();
            SuspendLayout();
            // 
            // dtgPolicia
            // 
            dtgPolicia.AllowUserToAddRows = false;
            dtgPolicia.AllowUserToDeleteRows = false;
            dtgPolicia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPolicia.Location = new Point(29, 99);
            dtgPolicia.Margin = new Padding(3, 2, 3, 2);
            dtgPolicia.Name = "dtgPolicia";
            dtgPolicia.ReadOnly = true;
            dtgPolicia.RowHeadersWidth = 82;
            dtgPolicia.Size = new Size(1166, 396);
            dtgPolicia.TabIndex = 5;
            dtgPolicia.CellDoubleClick += dtgPolicia_CellDoubleClick;
            // 
            // txtFiltrooo
            // 
            txtFiltrooo.Location = new Point(476, 39);
            txtFiltrooo.Margin = new Padding(2, 1, 2, 1);
            txtFiltrooo.Name = "txtFiltrooo";
            txtFiltrooo.Size = new Size(546, 23);
            txtFiltrooo.TabIndex = 1;
            txtFiltrooo.TextChanged += txtFiltrooo_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(261, 47);
            label1.Name = "label1";
            label1.Size = new Size(201, 15);
            label1.TabIndex = 4;
            label1.Text = "Ingrese iniciales del apellido Paterno:";
            label1.Click += label1_Click;
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(1035, 530);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(88, 25);
            lblRegistros.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(971, 537);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 17;
            label3.Text = "Registros:";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(380, 532);
            btnSalir.Margin = new Padding(2, 1, 2, 1);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(111, 23);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(237, 532);
            btnEliminar.Margin = new Padding(2, 1, 2, 1);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(111, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Desactivar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(91, 532);
            btnInsertar.Margin = new Padding(3, 2, 3, 2);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(111, 23);
            btnInsertar.TabIndex = 2;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // PoliciaMan03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1227, 639);
            Controls.Add(btnInsertar);
            Controls.Add(lblRegistros);
            Controls.Add(label3);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(dtgPolicia);
            Controls.Add(txtFiltrooo);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PoliciaMan03";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listado de Policías";
            Load += PoliciaMan05_Load;
            ((System.ComponentModel.ISupportInitialize)dtgPolicia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgPolicia;
        private TextBox txtFiltrooo;
        private Label label1;
        private Label lblRegistros;
        private Label label3;
        private Button btnSalir;
        private Button btnEliminar;
        private Button btnInsertar;
    }
}