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
            dtgPolicia.Location = new Point(31, 71);
            dtgPolicia.Name = "dtgPolicia";
            dtgPolicia.ReadOnly = true;
            dtgPolicia.RowHeadersWidth = 82;
            dtgPolicia.Size = new Size(823, 367);
            dtgPolicia.TabIndex = 6;
            dtgPolicia.CellDoubleClick += dtgPolicia_CellDoubleClick;
            // 
            // txtFiltrooo
            // 
            txtFiltrooo.Location = new Point(419, 29);
            txtFiltrooo.Margin = new Padding(2, 1, 2, 1);
            txtFiltrooo.Name = "txtFiltrooo";
            txtFiltrooo.Size = new Size(253, 23);
            txtFiltrooo.TabIndex = 1;
            txtFiltrooo.TextChanged += txtFiltrooo_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 29);
            label1.Name = "label1";
            label1.Size = new Size(255, 20);
            label1.TabIndex = 4;
            label1.Text = "Ingrese iniciales del apellido Paterno:";
            label1.Click += label1_Click;
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(697, 459);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(100, 33);
            lblRegistros.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(619, 464);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 16;
            label3.Text = "Registros:";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(384, 348);
            btnSalir.Margin = new Padding(2, 1, 2, 1);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(96, 30);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(206, 348);
            btnEliminar.Margin = new Padding(2, 1, 2, 1);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(115, 30);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(62, 464);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(90, 30);
            btnInsertar.TabIndex = 2;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // PoliciaMan03
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 556);
            Controls.Add(btnInsertar);
            Controls.Add(lblRegistros);
            Controls.Add(label3);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(dtgPolicia);
            Controls.Add(txtFiltrooo);
            Controls.Add(label1);
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