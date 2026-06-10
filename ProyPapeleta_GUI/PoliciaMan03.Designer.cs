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
            dtgPolicia.Location = new Point(41, 47);
            dtgPolicia.Margin = new Padding(3, 2, 3, 2);
            dtgPolicia.Name = "dtgPolicia";
            dtgPolicia.ReadOnly = true;
            dtgPolicia.RowHeadersWidth = 82;
            dtgPolicia.Size = new Size(761, 324);
            dtgPolicia.TabIndex = 6;
            dtgPolicia.CellDoubleClick += dtgPolicia_CellDoubleClick;
            // 
            // txtFiltrooo
            // 
            txtFiltrooo.Location = new Point(324, 14);
            txtFiltrooo.Margin = new Padding(3, 2, 3, 2);
            txtFiltrooo.Name = "txtFiltrooo";
            txtFiltrooo.Size = new Size(415, 23);
            txtFiltrooo.TabIndex = 5;
            txtFiltrooo.TextChanged += txtFiltrooo_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 17);
            label1.Name = "label1";
            label1.Size = new Size(173, 15);
            label1.TabIndex = 4;
            label1.Text = "Ingrese iniciales de descripción:";
            label1.Click += label1_Click;
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(710, 387);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(83, 33);
            lblRegistros.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(646, 396);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 16;
            label3.Text = "Registros:";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(496, 396);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(84, 24);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(324, 396);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(102, 24);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(152, 396);
            btnInsertar.Margin = new Padding(3, 2, 3, 2);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(100, 24);
            btnInsertar.TabIndex = 18;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // PoliciaMan03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 443);
            Controls.Add(btnInsertar);
            Controls.Add(lblRegistros);
            Controls.Add(label3);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(dtgPolicia);
            Controls.Add(txtFiltrooo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "PoliciaMan03";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PoliciaMan05";
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