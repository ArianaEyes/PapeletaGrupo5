namespace ProyPapeleta_GUI
{
    partial class PoliciaMan05
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
            dtgPolicia.Location = new Point(50, 113);
            dtgPolicia.Margin = new Padding(6, 4, 6, 4);
            dtgPolicia.Name = "dtgPolicia";
            dtgPolicia.ReadOnly = true;
            dtgPolicia.RowHeadersWidth = 82;
            dtgPolicia.Size = new Size(1647, 770);
            dtgPolicia.TabIndex = 6;
            dtgPolicia.CellDoubleClick += dtgPolicia_CellDoubleClick;
            // 
            // txtFiltrooo
            // 
            txtFiltrooo.Location = new Point(271, 20);
            txtFiltrooo.Margin = new Padding(3, 2, 3, 2);
            txtFiltrooo.Name = "txtFiltrooo";
            txtFiltrooo.Size = new Size(467, 23);
            txtFiltrooo.TabIndex = 5;
            txtFiltrooo.TextChanged += txtFiltrooo_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 47);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(201, 15);
            label1.TabIndex = 4;
            label1.Text = "Ingrese iniciales del apellido Paterno:";
            label1.Click += label1_Click;
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(1445, 917);
            lblRegistros.Margin = new Padding(6, 0, 6, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(137, 34);
            lblRegistros.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1281, 958);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(115, 32);
            label3.TabIndex = 16;
            label3.Text = "Registros:";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(783, 479);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(243, 75);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(474, 479);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(243, 75);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(58, 937);
            btnInsertar.Margin = new Padding(6, 4, 6, 4);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(228, 75);
            btnInsertar.TabIndex = 18;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // PoliciaMan05
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1768, 1156);
            Controls.Add(btnInsertar);
            Controls.Add(lblRegistros);
            Controls.Add(label3);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(dtgPolicia);
            Controls.Add(txtFiltrooo);
            Controls.Add(label1);
            Margin = new Padding(6, 4, 6, 4);
            Name = "PoliciaMan05";
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