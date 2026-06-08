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
            lblCodigo = new Label();
            grpFoto = new GroupBox();
            btnCargarFoto = new Button();
            pcbFoto = new PictureBox();
            btnCancelar = new Button();
            btnAgregar = new Button();
            chkActivo = new CheckBox();
            dtpFechaNacimiento = new DateTimePicker();
            label10 = new Label();
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
            grpDatosPolicia.Controls.Add(lblCodigo);
            grpDatosPolicia.Controls.Add(grpFoto);
            grpDatosPolicia.Controls.Add(btnCancelar);
            grpDatosPolicia.Controls.Add(btnAgregar);
            grpDatosPolicia.Controls.Add(chkActivo);
            grpDatosPolicia.Controls.Add(dtpFechaNacimiento);
            grpDatosPolicia.Controls.Add(label10);
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
            grpDatosPolicia.Location = new Point(21, 38);
            grpDatosPolicia.Margin = new Padding(5);
            grpDatosPolicia.Name = "grpDatosPolicia";
            grpDatosPolicia.Padding = new Padding(5);
            grpDatosPolicia.Size = new Size(1308, 875);
            grpDatosPolicia.TabIndex = 1;
            grpDatosPolicia.TabStop = false;
            grpDatosPolicia.Text = "Actualizar Datos Policia";
            grpDatosPolicia.Enter += grpDatosPolicia_Enter;
            // 
            // lblCodigo
            // 
            lblCodigo.BorderStyle = BorderStyle.FixedSingle;
            lblCodigo.Location = new Point(177, 69);
            lblCodigo.Margin = new Padding(5, 0, 5, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(161, 47);
            lblCodigo.TabIndex = 8;
            lblCodigo.Click += lblCodigo_Click;
            lblCodigo.MouseDoubleClick += lblCodigo_MouseDoubleClick;
            // 
            // grpFoto
            // 
            grpFoto.Controls.Add(btnCargarFoto);
            grpFoto.Controls.Add(pcbFoto);
            grpFoto.Location = new Point(671, 384);
            grpFoto.Margin = new Padding(5);
            grpFoto.Name = "grpFoto";
            grpFoto.Padding = new Padding(5);
            grpFoto.Size = new Size(544, 344);
            grpFoto.TabIndex = 7;
            grpFoto.TabStop = false;
            grpFoto.Text = "Foto";
            // 
            // btnCargarFoto
            // 
            btnCargarFoto.Location = new Point(73, 139);
            btnCargarFoto.Margin = new Padding(5);
            btnCargarFoto.Name = "btnCargarFoto";
            btnCargarFoto.Size = new Size(153, 78);
            btnCargarFoto.TabIndex = 1;
            btnCargarFoto.Text = "Cargar Foto";
            btnCargarFoto.UseVisualStyleBackColor = true;
            btnCargarFoto.Click += btnCargarFoto_Click_1;
            // 
            // pcbFoto
            // 
            pcbFoto.Location = new Point(268, 43);
            pcbFoto.Margin = new Padding(5);
            pcbFoto.Name = "pcbFoto";
            pcbFoto.Size = new Size(245, 267);
            pcbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbFoto.TabIndex = 0;
            pcbFoto.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1063, 787);
            btnCancelar.Margin = new Padding(5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(153, 46);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnAgregar_Click_2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(863, 787);
            btnAgregar.Margin = new Padding(5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(153, 46);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_2;
            // 
            // chkActivo
            // 
            chkActivo.AllowDrop = true;
            chkActivo.Location = new Point(959, 302);
            chkActivo.Margin = new Padding(5);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(205, 46);
            chkActivo.TabIndex = 6;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(289, 293);
            dtpFechaNacimiento.Margin = new Padding(5);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(488, 39);
            dtpFechaNacimiento.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(42, 523);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(87, 32);
            label10.TabIndex = 4;
            label10.Text = "Rango:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(829, 302);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(89, 32);
            label6.TabIndex = 4;
            label6.Text = "Estado:";
            // 
            // cboDistrito
            // 
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(252, 773);
            cboDistrito.Margin = new Padding(5);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(311, 40);
            cboDistrito.TabIndex = 2;
            // 
            // cboProvincia
            // 
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(252, 691);
            cboProvincia.Margin = new Padding(5);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(311, 40);
            cboProvincia.TabIndex = 2;
            // 
            // cboDepartamento
            // 
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Location = new Point(252, 616);
            cboDepartamento.Margin = new Padding(5);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(311, 40);
            cboDepartamento.TabIndex = 2;
            // 
            // cboRango
            // 
            cboRango.FormattingEnabled = true;
            cboRango.Items.AddRange(new object[] { "--Seleccione--", "General de Policía", "", "Teniente General", "", "General", "", "Coronel", "", "Comandante", "", "Mayor", "", "Capitán", "", "Teniente", "", "Alférez", "Suboficial Superior", "", "Suboficial Brigadier", "", "Suboficial Técnico de Primera", "", "Suboficial Técnico de Segunda", "", "Suboficial Técnico de Tercera", "", "Suboficial de Primera", "", "Suboficial de Segunda", "", "Suboficial de Tercera" });
            cboRango.Location = new Point(252, 523);
            cboRango.Margin = new Padding(5);
            cboRango.Name = "cboRango";
            cboRango.Size = new Size(311, 40);
            cboRango.TabIndex = 2;
            // 
            // grpSexo
            // 
            grpSexo.Controls.Add(optFemenino);
            grpSexo.Controls.Add(optMasculino);
            grpSexo.Location = new Point(42, 366);
            grpSexo.Margin = new Padding(5);
            grpSexo.Name = "grpSexo";
            grpSexo.Padding = new Padding(5);
            grpSexo.Size = new Size(522, 117);
            grpSexo.TabIndex = 3;
            grpSexo.TabStop = false;
            grpSexo.Text = "Sexo";
            // 
            // optFemenino
            // 
            optFemenino.AutoSize = true;
            optFemenino.Location = new Point(39, 46);
            optFemenino.Margin = new Padding(5);
            optFemenino.Name = "optFemenino";
            optFemenino.Size = new Size(152, 36);
            optFemenino.TabIndex = 2;
            optFemenino.TabStop = true;
            optFemenino.Text = "Femenino";
            optFemenino.UseVisualStyleBackColor = true;
            // 
            // optMasculino
            // 
            optMasculino.AutoSize = true;
            optMasculino.Location = new Point(304, 46);
            optMasculino.Margin = new Padding(5);
            optMasculino.Name = "optMasculino";
            optMasculino.Size = new Size(154, 36);
            optMasculino.TabIndex = 2;
            optMasculino.TabStop = true;
            optMasculino.Text = "Masculino";
            optMasculino.UseVisualStyleBackColor = true;
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.Location = new Point(933, 216);
            txtApellidoMaterno.Margin = new Padding(5);
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(249, 39);
            txtApellidoMaterno.TabIndex = 1;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(933, 141);
            txtDNI.Margin = new Padding(5);
            txtDNI.MaxLength = 12345678;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(249, 39);
            txtDNI.TabIndex = 1;
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.Location = new Point(252, 216);
            txtApellidoPaterno.Margin = new Padding(5);
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(311, 39);
            txtApellidoPaterno.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(177, 136);
            txtNombre.Margin = new Padding(5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(378, 39);
            txtNombre.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(686, 222);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(205, 32);
            label3.TabIndex = 0;
            label3.Text = "Apellido Materno:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(671, 141);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(60, 32);
            label5.TabIndex = 0;
            label5.Text = "DNI:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 301);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(252, 32);
            label7.TabIndex = 0;
            label7.Text = " Fecha de Nacimiento:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(42, 779);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(96, 32);
            label9.TabIndex = 0;
            label9.Text = "Distrito:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(42, 696);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(115, 32);
            label8.TabIndex = 0;
            label8.Text = "Provincia:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 619);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(173, 32);
            label4.TabIndex = 0;
            label4.Text = "Departamento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 226);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(195, 32);
            label2.TabIndex = 0;
            label2.Text = "Apellido Paterno:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(42, 69);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(96, 32);
            label11.TabIndex = 0;
            label11.Text = "Codigo:";
            label11.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 141);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 32);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            label1.Click += label1_Click;
            // 
            // PoliciaMan02
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 943);
            Controls.Add(grpDatosPolicia);
            Margin = new Padding(5);
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
        private Button btnCargarFoto;
        private PictureBox pcbFoto;
        private CheckBox chkActivo;
        private DateTimePicker dtpFechaNacimiento;
        private Label label10;
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
    }
}