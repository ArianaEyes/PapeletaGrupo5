namespace ProyPapeleta_GUI
{
    partial class MultasInfractor
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            dtpFecIni = new DateTimePicker();
            dtpFecFin = new DateTimePicker();
            txtCod = new TextBox();
            lblNombre = new Label();
            lblTipoBrevete = new Label();
            lblDNI = new Label();
            lblApellido = new Label();
            lblNumBrevete = new Label();
            lblCorreo = new Label();
            dtgMultas = new DataGridView();
            lblRegistros = new Label();
            label14 = new Label();
            lblEstado = new Label();
            label19 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgMultas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 13);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Código Infractor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 45);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 90);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 2;
            label3.Text = "Tipo de brevete:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(167, 161);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 4;
            label5.Text = "Fecha Inicio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(437, 50);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 5;
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(437, 21);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 6;
            label7.Text = "DNI:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(437, 53);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 7;
            label8.Text = "Apellido:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(437, 90);
            label9.Name = "label9";
            label9.Size = new Size(112, 15);
            label9.TabIndex = 8;
            label9.Text = "Número de Brevete:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(437, 122);
            label10.Name = "label10";
            label10.Size = new Size(46, 15);
            label10.TabIndex = 9;
            label10.Text = "Correo:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(437, 169);
            label11.Name = "label11";
            label11.Size = new Size(60, 15);
            label11.TabIndex = 10;
            label11.Text = "Fecha Fin:";
            // 
            // dtpFecIni
            // 
            dtpFecIni.Format = DateTimePickerFormat.Short;
            dtpFecIni.Location = new Point(254, 158);
            dtpFecIni.Margin = new Padding(4, 3, 4, 3);
            dtpFecIni.Name = "dtpFecIni";
            dtpFecIni.Size = new Size(148, 23);
            dtpFecIni.TabIndex = 11;
            // 
            // dtpFecFin
            // 
            dtpFecFin.Format = DateTimePickerFormat.Short;
            dtpFecFin.Location = new Point(509, 165);
            dtpFecFin.Margin = new Padding(4, 3, 4, 3);
            dtpFecFin.Name = "dtpFecFin";
            dtpFecFin.Size = new Size(148, 23);
            dtpFecFin.TabIndex = 12;
            // 
            // txtCod
            // 
            txtCod.CharacterCasing = CharacterCasing.Upper;
            txtCod.Location = new Point(286, 10);
            txtCod.Margin = new Padding(4, 3, 4, 3);
            txtCod.MaxLength = 5;
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(90, 23);
            txtCod.TabIndex = 13;
            txtCod.KeyPress += txtCod_KeyPress_1;
            // 
            // lblNombre
            // 
            lblNombre.BorderStyle = BorderStyle.FixedSingle;
            lblNombre.Location = new Point(228, 42);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(116, 26);
            lblNombre.TabIndex = 14;
            // 
            // lblTipoBrevete
            // 
            lblTipoBrevete.BorderStyle = BorderStyle.FixedSingle;
            lblTipoBrevete.Location = new Point(266, 90);
            lblTipoBrevete.Margin = new Padding(4, 0, 4, 0);
            lblTipoBrevete.Name = "lblTipoBrevete";
            lblTipoBrevete.Size = new Size(110, 26);
            lblTipoBrevete.TabIndex = 15;
            // 
            // lblDNI
            // 
            lblDNI.BorderStyle = BorderStyle.FixedSingle;
            lblDNI.Location = new Point(474, 15);
            lblDNI.Margin = new Padding(4, 0, 4, 0);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(142, 26);
            lblDNI.TabIndex = 17;
            // 
            // lblApellido
            // 
            lblApellido.BorderStyle = BorderStyle.FixedSingle;
            lblApellido.Location = new Point(498, 50);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(312, 26);
            lblApellido.TabIndex = 18;
            // 
            // lblNumBrevete
            // 
            lblNumBrevete.BorderStyle = BorderStyle.FixedSingle;
            lblNumBrevete.Location = new Point(556, 87);
            lblNumBrevete.Margin = new Padding(4, 0, 4, 0);
            lblNumBrevete.Name = "lblNumBrevete";
            lblNumBrevete.Size = new Size(254, 26);
            lblNumBrevete.TabIndex = 19;
            // 
            // lblCorreo
            // 
            lblCorreo.BorderStyle = BorderStyle.FixedSingle;
            lblCorreo.Location = new Point(490, 121);
            lblCorreo.Margin = new Padding(4, 0, 4, 0);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(320, 26);
            lblCorreo.TabIndex = 20;
            // 
            // dtgMultas
            // 
            dtgMultas.AllowUserToAddRows = false;
            dtgMultas.AllowUserToDeleteRows = false;
            dtgMultas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgMultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgMultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgMultas.Location = new Point(12, 210);
            dtgMultas.Margin = new Padding(4, 3, 4, 3);
            dtgMultas.Name = "dtgMultas";
            dtgMultas.ReadOnly = true;
            dtgMultas.RowHeadersVisible = false;
            dtgMultas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgMultas.Size = new Size(914, 185);
            dtgMultas.TabIndex = 21;
            // 
            // lblRegistros
            // 
            lblRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(853, 408);
            lblRegistros.Margin = new Padding(4, 0, 4, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(57, 26);
            lblRegistros.TabIndex = 23;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Location = new Point(787, 414);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(58, 15);
            label14.TabIndex = 22;
            label14.Text = "Registros:";
            // 
            // lblEstado
            // 
            lblEstado.BorderStyle = BorderStyle.FixedSingle;
            lblEstado.Location = new Point(704, 15);
            lblEstado.Margin = new Padding(4, 0, 4, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(106, 25);
            lblEstado.TabIndex = 25;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(651, 21);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(45, 15);
            label19.TabIndex = 24;
            label19.Text = "Estado:";
            // 
            // MultasInfractor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 450);
            Controls.Add(lblEstado);
            Controls.Add(label19);
            Controls.Add(lblRegistros);
            Controls.Add(label14);
            Controls.Add(dtgMultas);
            Controls.Add(lblCorreo);
            Controls.Add(lblNumBrevete);
            Controls.Add(lblApellido);
            Controls.Add(lblDNI);
            Controls.Add(lblTipoBrevete);
            Controls.Add(lblNombre);
            Controls.Add(txtCod);
            Controls.Add(dtpFecFin);
            Controls.Add(dtpFecIni);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MultasInfractor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MultasInfractor";
            ((System.ComponentModel.ISupportInitialize)dtgMultas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private DateTimePicker dtpFecIni;
        private DateTimePicker dtpFecFin;
        private TextBox txtCod;
        private Label lblNombre;
        private Label lblTipoBrevete;
        private Label lblDNI;
        private Label lblApellido;
        private Label lblNumBrevete;
        private Label lblCorreo;
        private DataGridView dtgMultas;
        private Label lblRegistros;
        private Label label14;
        private Label lblEstado;
        private Label label19;
    }
}