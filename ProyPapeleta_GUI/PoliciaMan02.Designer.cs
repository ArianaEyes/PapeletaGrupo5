namespace ProyPapeleta_GUI
{
    partial class PoliciaMan02
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
            grpDatosPolicia = new GroupBox();
            btnCargarFoto = new Button();
            lblCodigo = new Label();
            grpFoto = new GroupBox();
            pcbFoto = new PictureBox();
            btnCancelar = new Button();
            btnAgregar = new Button();
            chkActivo = new CheckBox();
            dtpFechaNacimiento = new DateTimePicker();
            txtRango = new Label();
            label6 = new Label();
            cboDistrito = new ComboBox();
            cboProvincia = new ComboBox();
            cboDepartamento = new ComboBox();
            cboRango = new ComboBox();
            grpSexo = new GroupBox();
            optFemenino = new RadioButton();
            optMasculino = new RadioButton();
            txtApellidoMaterno = new TextBox();
            txtDNI = new TextBox();
            txtApellidoPaterno = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label7 = new Label();
            label9 = new Label();
            label8 = new Label();
            label4 = new Label();
            label2 = new Label();
            label11 = new Label();
            label1 = new Label();
            grpDatosPolicia.SuspendLayout();
            grpFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFoto).BeginInit();
            grpSexo.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatosPolicia
            // 
            grpDatosPolicia.Controls.Add(btnCargarFoto);
            grpDatosPolicia.Controls.Add(lblCodigo);
            grpDatosPolicia.Controls.Add(grpFoto);
            grpDatosPolicia.Controls.Add(btnCancelar);
            grpDatosPolicia.Controls.Add(btnAgregar);
            grpDatosPolicia.Controls.Add(chkActivo);
            grpDatosPolicia.Controls.Add(dtpFechaNacimiento);
            grpDatosPolicia.Controls.Add(txtRango);
            grpDatosPolicia.Controls.Add(label6);
            grpDatosPolicia.Controls.Add(cboDistrito);
            grpDatosPolicia.Controls.Add(cboProvincia);
            grpDatosPolicia.Controls.Add(cboDepartamento);
            grpDatosPolicia.Controls.Add(cboRango);
            grpDatosPolicia.Controls.Add(grpSexo);
            grpDatosPolicia.Controls.Add(txtApellidoMaterno);
            grpDatosPolicia.Controls.Add(txtDNI);
            grpDatosPolicia.Controls.Add(txtApellidoPaterno);
            grpDatosPolicia.Controls.Add(txtNombre);
            grpDatosPolicia.Controls.Add(label3);
            grpDatosPolicia.Controls.Add(label5);
            grpDatosPolicia.Controls.Add(label7);
            grpDatosPolicia.Controls.Add(label9);
            grpDatosPolicia.Controls.Add(label8);
            grpDatosPolicia.Controls.Add(label4);
            grpDatosPolicia.Controls.Add(label2);
            grpDatosPolicia.Controls.Add(label11);
            grpDatosPolicia.Controls.Add(label1);
            grpDatosPolicia.Location = new Point(12, 11);
            grpDatosPolicia.Margin = new Padding(3, 2, 3, 2);
            grpDatosPolicia.Name = "grpDatosPolicia";
            grpDatosPolicia.Padding = new Padding(3, 2, 3, 2);
            grpDatosPolicia.Size = new Size(715, 432);
            grpDatosPolicia.TabIndex = 1;
            grpDatosPolicia.TabStop = false;
            grpDatosPolicia.Text = "Actualizar Datos Policia";
            grpDatosPolicia.Enter += grpDatosPolicia_Enter;
            // 
            // btnCargarFoto
            // 
            btnCargarFoto.Location = new Point(373, 222);
            btnCargarFoto.Margin = new Padding(3, 2, 3, 2);
            btnCargarFoto.Name = "btnCargarFoto";
            btnCargarFoto.Size = new Size(82, 37);
            btnCargarFoto.TabIndex = 15;
            btnCargarFoto.Text = "Cargar Foto";
            btnCargarFoto.UseVisualStyleBackColor = true;
            btnCargarFoto.Click += btnCargarFoto_Click_1;
            // 
            // lblCodigo
            // 
            lblCodigo.BorderStyle = BorderStyle.FixedSingle;
            lblCodigo.Location = new Point(95, 32);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(88, 23);
            lblCodigo.TabIndex = 8;
            lblCodigo.Click += lblCodigo_Click;
            lblCodigo.MouseDoubleClick += lblCodigo_MouseDoubleClick;
            // 
            // grpFoto
            // 
            grpFoto.Controls.Add(pcbFoto);
            grpFoto.Location = new Point(483, 180);
            grpFoto.Margin = new Padding(3, 2, 3, 2);
            grpFoto.Name = "grpFoto";
            grpFoto.Padding = new Padding(3, 2, 3, 2);
            grpFoto.Size = new Size(171, 161);
            grpFoto.TabIndex = 7;
            grpFoto.TabStop = false;
            grpFoto.Text = "Foto";
            // 
            // pcbFoto
            // 
            pcbFoto.Location = new Point(20, 20);
            pcbFoto.Margin = new Padding(3, 2, 3, 2);
            pcbFoto.Name = "pcbFoto";
            pcbFoto.Size = new Size(132, 125);
            pcbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbFoto.TabIndex = 0;
            pcbFoto.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(570, 369);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 35);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnAgregar_Click_2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(465, 369);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 35);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_2;
            // 
            // chkActivo
            // 
            chkActivo.AllowDrop = true;
            chkActivo.Checked = true;
            chkActivo.CheckState = CheckState.Checked;
            chkActivo.Location = new Point(516, 142);
            chkActivo.Margin = new Padding(3, 2, 3, 2);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(110, 22);
            chkActivo.TabIndex = 6;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(156, 137);
            dtpFechaNacimiento.Margin = new Padding(3, 2, 3, 2);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(265, 23);
            dtpFechaNacimiento.TabIndex = 5;
            // 
            // txtRango
            // 
            txtRango.AutoSize = true;
            txtRango.Location = new Point(23, 245);
            txtRango.Name = "txtRango";
            txtRango.Size = new Size(44, 15);
            txtRango.TabIndex = 4;
            txtRango.Text = "Rango:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(446, 142);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 4;
            label6.Text = "Estado:";
            // 
            // cboDistrito
            // 
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(136, 362);
            cboDistrito.Margin = new Padding(3, 2, 3, 2);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(169, 23);
            cboDistrito.TabIndex = 11;
            // 
            // cboProvincia
            // 
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(136, 324);
            cboProvincia.Margin = new Padding(3, 2, 3, 2);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(169, 23);
            cboProvincia.TabIndex = 10;
            // 
            // cboDepartamento
            // 
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Location = new Point(136, 289);
            cboDepartamento.Margin = new Padding(3, 2, 3, 2);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(169, 23);
            cboDepartamento.TabIndex = 9;
            // 
            // cboRango
            // 
            cboRango.FormattingEnabled = true;
            cboRango.Items.AddRange(new object[] { "--Seleccione--", "General de Policía", "", "Teniente General", "", "General", "", "Coronel", "", "Comandante", "", "Mayor", "", "Capitán", "", "Teniente", "", "Alférez", "Suboficial Superior", "", "Suboficial Brigadier", "", "Suboficial Técnico de Primera", "", "Suboficial Técnico de Segunda", "", "Suboficial Técnico de Tercera", "", "Suboficial de Primera", "", "Suboficial de Segunda", "", "Suboficial de Tercera" });
            cboRango.Location = new Point(136, 245);
            cboRango.Margin = new Padding(3, 2, 3, 2);
            cboRango.Name = "cboRango";
            cboRango.Size = new Size(169, 23);
            cboRango.TabIndex = 8;
            // 
            // grpSexo
            // 
            grpSexo.Controls.Add(optFemenino);
            grpSexo.Controls.Add(optMasculino);
            grpSexo.Location = new Point(23, 172);
            grpSexo.Margin = new Padding(3, 2, 3, 2);
            grpSexo.Name = "grpSexo";
            grpSexo.Padding = new Padding(3, 2, 3, 2);
            grpSexo.Size = new Size(281, 55);
            grpSexo.TabIndex = 7;
            grpSexo.TabStop = false;
            grpSexo.Text = "Sexo";
            // 
            // optFemenino
            // 
            optFemenino.AutoSize = true;
            optFemenino.Location = new Point(21, 22);
            optFemenino.Margin = new Padding(3, 2, 3, 2);
            optFemenino.Name = "optFemenino";
            optFemenino.Size = new Size(78, 19);
            optFemenino.TabIndex = 2;
            optFemenino.TabStop = true;
            optFemenino.Text = "Femenino";
            optFemenino.UseVisualStyleBackColor = true;
            // 
            // optMasculino
            // 
            optMasculino.AutoSize = true;
            optMasculino.Location = new Point(164, 22);
            optMasculino.Margin = new Padding(3, 2, 3, 2);
            optMasculino.Name = "optMasculino";
            optMasculino.Size = new Size(80, 19);
            optMasculino.TabIndex = 2;
            optMasculino.TabStop = true;
            optMasculino.Text = "Masculino";
            optMasculino.UseVisualStyleBackColor = true;
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.Location = new Point(156, 101);
            txtApellidoMaterno.Margin = new Padding(3, 2, 3, 2);
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(136, 23);
            txtApellidoMaterno.TabIndex = 3;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(483, 101);
            txtDNI.Margin = new Padding(3, 2, 3, 2);
            txtDNI.MaxLength = 12345678;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(169, 23);
            txtDNI.TabIndex = 4;
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.Location = new Point(483, 67);
            txtApellidoPaterno.Margin = new Padding(3, 2, 3, 2);
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(169, 23);
            txtApellidoPaterno.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(95, 64);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(205, 23);
            txtNombre.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 106);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 0;
            label3.Text = "Apellido Materno:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(361, 104);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 0;
            label5.Text = "DNI:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 141);
            label7.Name = "label7";
            label7.Size = new Size(125, 15);
            label7.TabIndex = 0;
            label7.Text = " Fecha de Nacimiento:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 365);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 0;
            label9.Text = "Distrito:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 326);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 0;
            label8.Text = "Provincia:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 290);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 0;
            label4.Text = "Departamento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(361, 67);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 0;
            label2.Text = "Apellido Paterno:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(23, 32);
            label11.Name = "label11";
            label11.Size = new Size(49, 15);
            label11.TabIndex = 0;
            label11.Text = "Codigo:";
            label11.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 66);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            label1.Click += label1_Click;
            // 
            // PoliciaMan02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 454);
            Controls.Add(grpDatosPolicia);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "PoliciaMan02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar Policia";
            Load += PoliciaMan02_Load;
            grpDatosPolicia.ResumeLayout(false);
            grpDatosPolicia.PerformLayout();
            grpFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbFoto).EndInit();
            grpSexo.ResumeLayout(false);
            grpSexo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatosPolicia;
        private GroupBox grpFoto;
        private PictureBox pcbFoto;
        private CheckBox chkActivo;
        private DateTimePicker dtpFechaNacimiento;
        private Label txtRango;
        private Label label6;
        private ComboBox cboDistrito;
        private ComboBox cboProvincia;
        private ComboBox cboDepartamento;
        private ComboBox cboRango;
        private GroupBox grpSexo;
        private RadioButton optFemenino;
        private RadioButton optMasculino;
        private TextBox txtApellidoMaterno;
        private TextBox txtDNI;
        private TextBox txtApellidoPaterno;
        private TextBox txtNombre;
        private Label label3;
        private Label label5;
        private Label label7;
        private Label label9;
        private Label label8;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label lblCodigo;
        private Label label11;
        private Button btnAgregar;
        private Button btnCancelar;
        private Button btnCargarFoto;
    }
}