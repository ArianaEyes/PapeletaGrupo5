namespace ProyPapeleta_GUI
{
    partial class PoliciaMan01
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpDatosPolicia = new GroupBox();
            grpFoto = new GroupBox();
            btnCargarFoto = new Button();
            pcbFoto = new PictureBox();
            btnInsertarPoli = new Button();
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
            label1 = new Label();
            grpDatosPolicia.SuspendLayout();
            grpFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFoto).BeginInit();
            grpSexo.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatosPolicia
            // 
            grpDatosPolicia.Controls.Add(grpFoto);
            grpDatosPolicia.Controls.Add(btnInsertarPoli);
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
            grpDatosPolicia.Controls.Add(label1);
            grpDatosPolicia.Location = new Point(10, 9);
            grpDatosPolicia.Margin = new Padding(3, 2, 3, 2);
            grpDatosPolicia.Name = "grpDatosPolicia";
            grpDatosPolicia.Padding = new Padding(3, 2, 3, 2);
            grpDatosPolicia.Size = new Size(679, 368);
            grpDatosPolicia.TabIndex = 0;
            grpDatosPolicia.TabStop = false;
            grpDatosPolicia.Text = "Datos Policia";
            grpDatosPolicia.Enter += grpDatosPolicia_Enter;
            // 
            // grpFoto
            // 
            grpFoto.Controls.Add(btnCargarFoto);
            grpFoto.Controls.Add(pcbFoto);
            grpFoto.Location = new Point(361, 142);
            grpFoto.Margin = new Padding(3, 2, 3, 2);
            grpFoto.Name = "grpFoto";
            grpFoto.Padding = new Padding(3, 2, 3, 2);
            grpFoto.Size = new Size(293, 161);
            grpFoto.TabIndex = 7;
            grpFoto.TabStop = false;
            grpFoto.Text = "Foto";
            // 
            // btnCargarFoto
            // 
            btnCargarFoto.Location = new Point(38, 65);
            btnCargarFoto.Margin = new Padding(3, 2, 3, 2);
            btnCargarFoto.Name = "btnCargarFoto";
            btnCargarFoto.Size = new Size(82, 37);
            btnCargarFoto.TabIndex = 11;
            btnCargarFoto.Text = "Cargar Foto";
            btnCargarFoto.UseVisualStyleBackColor = true;
            btnCargarFoto.Click += btnCargarFoto_Click;
            // 
            // pcbFoto
            // 
            pcbFoto.Location = new Point(144, 20);
            pcbFoto.Margin = new Padding(3, 2, 3, 2);
            pcbFoto.Name = "pcbFoto";
            pcbFoto.Size = new Size(132, 125);
            pcbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbFoto.TabIndex = 0;
            pcbFoto.TabStop = false;
            // 
            // btnInsertarPoli
            // 
            btnInsertarPoli.Location = new Point(459, 323);
            btnInsertarPoli.Margin = new Padding(3, 2, 3, 2);
            btnInsertarPoli.Name = "btnInsertarPoli";
            btnInsertarPoli.Size = new Size(82, 24);
            btnInsertarPoli.TabIndex = 12;
            btnInsertarPoli.Text = "Agregar";
            btnInsertarPoli.UseVisualStyleBackColor = true;
            btnInsertarPoli.Click += btnInsertarPoli_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(572, 324);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 23);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "Cancelar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // chkActivo
            // 
            chkActivo.AllowDrop = true;
            chkActivo.Checked = true;
            chkActivo.CheckState = CheckState.Checked;
            chkActivo.Enabled = false;
            chkActivo.Location = new Point(516, 104);
            chkActivo.Margin = new Padding(3, 2, 3, 2);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(110, 22);
            chkActivo.TabIndex = 6;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(156, 99);
            dtpFechaNacimiento.Margin = new Padding(3, 2, 3, 2);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(265, 23);
            dtpFechaNacimiento.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(23, 207);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 4;
            label10.Text = "Rango:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(446, 104);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 4;
            label6.Text = "Estado:";
            // 
            // cboDistrito
            // 
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(136, 324);
            cboDistrito.Margin = new Padding(3, 2, 3, 2);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(168, 23);
            cboDistrito.TabIndex = 10;
            // 
            // cboProvincia
            // 
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(136, 286);
            cboProvincia.Margin = new Padding(3, 2, 3, 2);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(168, 23);
            cboProvincia.TabIndex = 9;
            // 
            // cboDepartamento
            // 
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Location = new Point(136, 250);
            cboDepartamento.Margin = new Padding(3, 2, 3, 2);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(168, 23);
            cboDepartamento.TabIndex = 8;
            // 
            // cboRango
            // 
            cboRango.FormattingEnabled = true;
            cboRango.Items.AddRange(new object[] { "--Seleccione--", "General de Policía", "Teniente General", "General", "Coronel", "Comandante", "Mayor", "Capitán", "Teniente", "Alférez", "Suboficial Superior", "Suboficial Brigadier", "Suboficial Técnico de Primera", "Suboficial Técnico de Segunda", "Suboficial Técnico de Tercera", "Suboficial de Primera", "Suboficial de Segunda", "Suboficial de Tercera" });
            cboRango.Location = new Point(136, 207);
            cboRango.Margin = new Padding(3, 2, 3, 2);
            cboRango.Name = "cboRango";
            cboRango.Size = new Size(168, 23);
            cboRango.TabIndex = 7;
            cboRango.SelectedIndexChanged += cboRango_SelectedIndexChanged;
            // 
            // grpSexo
            // 
            grpSexo.Controls.Add(optFemenino);
            grpSexo.Controls.Add(optMasculino);
            grpSexo.Location = new Point(23, 134);
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
            optFemenino.TabIndex = 6;
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
            optMasculino.TabIndex = 7;
            optMasculino.TabStop = true;
            optMasculino.Text = "Masculino";
            optMasculino.UseVisualStyleBackColor = true;
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.Location = new Point(163, 60);
            txtApellidoMaterno.Margin = new Padding(3, 2, 3, 2);
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(136, 23);
            txtApellidoMaterno.TabIndex = 3;
            txtApellidoMaterno.KeyPress += txtApellidoMaterno_KeyPress;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(446, 60);
            txtDNI.Margin = new Padding(3, 2, 3, 2);
            txtDNI.MaxLength = 12345678;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(168, 23);
            txtDNI.TabIndex = 4;
            txtDNI.KeyPress += txtDNI_KeyPress;
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.Location = new Point(446, 26);
            txtApellidoPaterno.Margin = new Padding(3, 2, 3, 2);
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(168, 23);
            txtApellidoPaterno.TabIndex = 2;
            txtApellidoPaterno.KeyPress += txtApellidoPaterno_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(94, 26);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(205, 23);
            txtNombre.TabIndex = 1;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 63);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 0;
            label3.Text = "Apellido Materno:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(323, 63);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 0;
            label5.Text = "DNI:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 103);
            label7.Name = "label7";
            label7.Size = new Size(125, 15);
            label7.TabIndex = 0;
            label7.Text = " Fecha de Nacimiento:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 326);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 0;
            label9.Text = "Distrito:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 288);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 0;
            label8.Text = "Provincia:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 251);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 0;
            label4.Text = "Departamento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(323, 28);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 0;
            label2.Text = "Apellido Paterno:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 28);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // PoliciaMan01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 388);
            Controls.Add(grpDatosPolicia);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "PoliciaMan01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Insertar Policia";
            Load += PoliciaMan01_Load;
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAgregar;
        private TextBox txtApellidoMaterno;
        private TextBox txtDNI;
        private TextBox txtApellidoPaterno;
        private TextBox txtNombre;
        private Label label5;
        private Label label4;
        private RadioButton optMasculino;
        private RadioButton optFemenino;
        private GroupBox grpSexo;
        private ComboBox cboRango;
        private Label label6;
        private DateTimePicker dtpFechaNacimiento;
        private Label label7;
        private ComboBox cboProvincia;
        private ComboBox cboDepartamento;
        private Label label8;
        private CheckBox chkActivo;
        private Label label10;
        private ComboBox cboDistrito;
        private Label label9;
        private GroupBox grpFoto;
        private Button btnCargarFoto;
        private PictureBox pcbFoto;
        private Button btnInsertarPoli;
    }
}
