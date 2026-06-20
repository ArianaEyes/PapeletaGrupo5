namespace ProyPapeleta_GUI
{
    partial class InfractorMan01
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
            components = new System.ComponentModel.Container();
            grpInfractor = new GroupBox();
            checkBox1 = new CheckBox();
            label13 = new Label();
            btnFoto = new Button();
            button2 = new Button();
            btnAgregar = new Button();
            grpFoto = new GroupBox();
            pcbFoto = new PictureBox();
            cboTipoBrevete = new ComboBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            cboDistrito = new ComboBox();
            cboProvincia = new ComboBox();
            cboDepartamento = new ComboBox();
            txtCorreo = new TextBox();
            label9 = new Label();
            grpSexo = new GroupBox();
            optMasculino = new RadioButton();
            optFemenino = new RadioButton();
            dtpFecNacimiento = new DateTimePicker();
            txtNumBrevete = new TextBox();
            txtDireccion = new TextBox();
            txtApePaterno = new TextBox();
            txtApeMaterno = new TextBox();
            txtDNI = new TextBox();
            txtNombres = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            grpInfractor.SuspendLayout();
            grpFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFoto).BeginInit();
            grpSexo.SuspendLayout();
            SuspendLayout();
            // 
            // grpInfractor
            // 
            grpInfractor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpInfractor.Controls.Add(checkBox1);
            grpInfractor.Controls.Add(label13);
            grpInfractor.Controls.Add(btnFoto);
            grpInfractor.Controls.Add(button2);
            grpInfractor.Controls.Add(btnAgregar);
            grpInfractor.Controls.Add(grpFoto);
            grpInfractor.Controls.Add(cboTipoBrevete);
            grpInfractor.Controls.Add(label12);
            grpInfractor.Controls.Add(label11);
            grpInfractor.Controls.Add(label10);
            grpInfractor.Controls.Add(cboDistrito);
            grpInfractor.Controls.Add(cboProvincia);
            grpInfractor.Controls.Add(cboDepartamento);
            grpInfractor.Controls.Add(txtCorreo);
            grpInfractor.Controls.Add(label9);
            grpInfractor.Controls.Add(grpSexo);
            grpInfractor.Controls.Add(dtpFecNacimiento);
            grpInfractor.Controls.Add(txtNumBrevete);
            grpInfractor.Controls.Add(txtDireccion);
            grpInfractor.Controls.Add(txtApePaterno);
            grpInfractor.Controls.Add(txtApeMaterno);
            grpInfractor.Controls.Add(txtDNI);
            grpInfractor.Controls.Add(txtNombres);
            grpInfractor.Controls.Add(label8);
            grpInfractor.Controls.Add(label7);
            grpInfractor.Controls.Add(label6);
            grpInfractor.Controls.Add(label5);
            grpInfractor.Controls.Add(label4);
            grpInfractor.Controls.Add(label3);
            grpInfractor.Controls.Add(label2);
            grpInfractor.Controls.Add(label1);
            grpInfractor.Location = new Point(11, 10);
            grpInfractor.Margin = new Padding(2, 1, 2, 1);
            grpInfractor.Name = "grpInfractor";
            grpInfractor.Padding = new Padding(2, 1, 2, 1);
            grpInfractor.Size = new Size(812, 477);
            grpInfractor.TabIndex = 0;
            grpInfractor.TabStop = false;
            grpInfractor.Text = "Insertar Infractor";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(155, 388);
            checkBox1.Margin = new Padding(2, 1, 2, 1);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(60, 19);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "Activo";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(38, 388);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(45, 15);
            label13.TabIndex = 28;
            label13.Text = "Estado:";
            // 
            // btnFoto
            // 
            btnFoto.Location = new Point(613, 370);
            btnFoto.Margin = new Padding(2, 1, 2, 1);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(81, 33);
            btnFoto.TabIndex = 15;
            btnFoto.Text = "Subir Foto";
            btnFoto.UseVisualStyleBackColor = true;
            btnFoto.Click += btnFoto_Click;
            // 
            // button2
            // 
            button2.Location = new Point(439, 415);
            button2.Margin = new Padding(2, 1, 2, 1);
            button2.Name = "button2";
            button2.Size = new Size(81, 38);
            button2.TabIndex = 17;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(326, 415);
            btnAgregar.Margin = new Padding(2, 1, 2, 1);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(81, 38);
            btnAgregar.TabIndex = 16;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // grpFoto
            // 
            grpFoto.Controls.Add(pcbFoto);
            grpFoto.Location = new Point(538, 237);
            grpFoto.Margin = new Padding(2, 1, 2, 1);
            grpFoto.Name = "grpFoto";
            grpFoto.Padding = new Padding(2, 1, 2, 1);
            grpFoto.Size = new Size(186, 131);
            grpFoto.TabIndex = 13;
            grpFoto.TabStop = false;
            grpFoto.Text = "Foto";
            // 
            // pcbFoto
            // 
            pcbFoto.Location = new Point(55, 16);
            pcbFoto.Margin = new Padding(2, 1, 2, 1);
            pcbFoto.Name = "pcbFoto";
            pcbFoto.Size = new Size(108, 113);
            pcbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbFoto.TabIndex = 0;
            pcbFoto.TabStop = false;
            // 
            // cboTipoBrevete
            // 
            cboTipoBrevete.FormattingEnabled = true;
            cboTipoBrevete.Location = new Point(576, 208);
            cboTipoBrevete.Margin = new Padding(2, 1, 2, 1);
            cboTipoBrevete.Name = "cboTipoBrevete";
            cboTipoBrevete.Size = new Size(184, 23);
            cboTipoBrevete.TabIndex = 9;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(36, 341);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(48, 15);
            label12.TabIndex = 23;
            label12.Text = "Distrito:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(36, 285);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(59, 15);
            label11.TabIndex = 22;
            label11.Text = "Provincia:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(33, 246);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(86, 15);
            label10.TabIndex = 21;
            label10.Text = "Departamento:";
            // 
            // cboDistrito
            // 
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(155, 341);
            cboDistrito.Margin = new Padding(2, 1, 2, 1);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(199, 23);
            cboDistrito.TabIndex = 13;
            // 
            // cboProvincia
            // 
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(155, 291);
            cboProvincia.Margin = new Padding(2, 1, 2, 1);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(199, 23);
            cboProvincia.TabIndex = 12;
            // 
            // cboDepartamento
            // 
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Location = new Point(155, 246);
            cboDepartamento.Margin = new Padding(2, 1, 2, 1);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(199, 23);
            cboDepartamento.TabIndex = 11;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(123, 152);
            txtCorreo.Margin = new Padding(2, 1, 2, 1);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(231, 23);
            txtCorreo.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(34, 145);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(46, 15);
            label9.TabIndex = 16;
            label9.Text = "Correo:";
            // 
            // grpSexo
            // 
            grpSexo.Controls.Add(optMasculino);
            grpSexo.Controls.Add(optFemenino);
            grpSexo.Location = new Point(453, 105);
            grpSexo.Margin = new Padding(2, 1, 2, 1);
            grpSexo.Name = "grpSexo";
            grpSexo.Padding = new Padding(2, 1, 2, 1);
            grpSexo.Size = new Size(305, 48);
            grpSexo.TabIndex = 6;
            grpSexo.TabStop = false;
            grpSexo.Text = "Sexo:";
            // 
            // optMasculino
            // 
            optMasculino.AutoSize = true;
            optMasculino.Location = new Point(191, 22);
            optMasculino.Margin = new Padding(2, 1, 2, 1);
            optMasculino.Name = "optMasculino";
            optMasculino.Size = new Size(80, 19);
            optMasculino.TabIndex = 1;
            optMasculino.TabStop = true;
            optMasculino.Text = "Masculino";
            optMasculino.UseVisualStyleBackColor = true;
            // 
            // optFemenino
            // 
            optFemenino.AutoSize = true;
            optFemenino.Location = new Point(54, 22);
            optFemenino.Margin = new Padding(2, 1, 2, 1);
            optFemenino.Name = "optFemenino";
            optFemenino.Size = new Size(78, 19);
            optFemenino.TabIndex = 0;
            optFemenino.TabStop = true;
            optFemenino.Text = "Femenino";
            optFemenino.UseVisualStyleBackColor = true;
            // 
            // dtpFecNacimiento
            // 
            dtpFecNacimiento.Location = new Point(181, 105);
            dtpFecNacimiento.Margin = new Padding(2, 1, 2, 1);
            dtpFecNacimiento.Name = "dtpFecNacimiento";
            dtpFecNacimiento.Size = new Size(255, 23);
            dtpFecNacimiento.TabIndex = 5;
            // 
            // txtNumBrevete
            // 
            txtNumBrevete.Location = new Point(576, 170);
            txtNumBrevete.Margin = new Padding(2, 1, 2, 1);
            txtNumBrevete.Name = "txtNumBrevete";
            txtNumBrevete.Size = new Size(184, 23);
            txtNumBrevete.TabIndex = 8;
            txtNumBrevete.KeyPress += txtNumBrevete_KeyPress;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(123, 199);
            txtDireccion.Margin = new Padding(2, 1, 2, 1);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(231, 23);
            txtDireccion.TabIndex = 10;
            // 
            // txtApePaterno
            // 
            txtApePaterno.CharacterCasing = CharacterCasing.Upper;
            txtApePaterno.Location = new Point(578, 29);
            txtApePaterno.Margin = new Padding(2, 1, 2, 1);
            txtApePaterno.Name = "txtApePaterno";
            txtApePaterno.Size = new Size(182, 23);
            txtApePaterno.TabIndex = 2;
            txtApePaterno.KeyPress += txtApePaterno_KeyPress;
            // 
            // txtApeMaterno
            // 
            txtApeMaterno.CharacterCasing = CharacterCasing.Upper;
            txtApeMaterno.Location = new Point(172, 65);
            txtApeMaterno.Margin = new Padding(2, 1, 2, 1);
            txtApeMaterno.Name = "txtApeMaterno";
            txtApeMaterno.Size = new Size(182, 23);
            txtApeMaterno.TabIndex = 3;
            txtApeMaterno.KeyPress += txtApeMaterno_KeyPress;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(578, 68);
            txtDNI.Margin = new Padding(2, 1, 2, 1);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(182, 23);
            txtDNI.TabIndex = 4;
            txtDNI.KeyPress += txtDNI_KeyPress;
            // 
            // txtNombres
            // 
            txtNombres.CharacterCasing = CharacterCasing.Upper;
            txtNombres.Location = new Point(145, 25);
            txtNombres.Margin = new Padding(2, 1, 2, 1);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(209, 23);
            txtNombres.TabIndex = 1;
            txtNombres.KeyPress += txtNombres_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(431, 211);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(76, 15);
            label8.TabIndex = 7;
            label8.Text = "Tipo Brevete:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(431, 173);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(96, 15);
            label7.TabIndex = 6;
            label7.Text = "Número Brevete:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 193);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 5;
            label6.Text = "Dirección:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(431, 68);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 4;
            label5.Text = "DNI:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(431, 29);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 3;
            label4.Text = "Apellido Paterno:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 65);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido Materno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 27);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombres:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 105);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha de Nacimiento:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(32, 32);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // InfractorMan01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 497);
            Controls.Add(grpInfractor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 1, 2, 1);
            MaximizeBox = false;
            Name = "InfractorMan01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Insertar Infractor";
            Load += InfractorMan01_Load_1;
            grpInfractor.ResumeLayout(false);
            grpInfractor.PerformLayout();
            grpFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbFoto).EndInit();
            grpSexo.ResumeLayout(false);
            grpSexo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpInfractor;
        private DateTimePicker dtpFecNacimiento;
        private TextBox txtNumBrevete;
        private TextBox txtDireccion;
        private TextBox txtApePaterno;
        private TextBox txtApeMaterno;
        private TextBox txtDNI;
        private TextBox txtNombres;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private GroupBox grpSexo;
        private Button button2;
        private Button btnAgregar;
        private GroupBox grpFoto;
        private Button btnFoto;
        private PictureBox pcbFoto;
        private ComboBox cboTipoBrevete;
        private Label label12;
        private Label label11;
        private Label label10;
        private ComboBox cboDistrito;
        private ComboBox cboProvincia;
        private ComboBox cboDepartamento;
        private TextBox txtCorreo;
        private Label label9;
        private RadioButton optMasculino;
        private RadioButton optFemenino;
        private CheckBox checkBox1;
        private Label label13;
    }
}