namespace ProyPapeleta_GUI
{
    partial class InfraccionMan02
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
            chkActivo = new CheckBox();
            label6 = new Label();
            button1 = new Button();
            lblCodigo = new Label();
            label4 = new Label();
            nudPuntos = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            nudUIT = new NumericUpDown();
            btnCancelar = new Button();
            label10 = new Label();
            cboCalificacion = new ComboBox();
            txtDescripcion = new TextBox();
            label1 = new Label();
            grpDatosPolicia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPuntos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudUIT).BeginInit();
            SuspendLayout();
            // 
            // grpDatosPolicia
            // 
            grpDatosPolicia.Controls.Add(chkActivo);
            grpDatosPolicia.Controls.Add(label6);
            grpDatosPolicia.Controls.Add(button1);
            grpDatosPolicia.Controls.Add(lblCodigo);
            grpDatosPolicia.Controls.Add(label4);
            grpDatosPolicia.Controls.Add(nudPuntos);
            grpDatosPolicia.Controls.Add(label3);
            grpDatosPolicia.Controls.Add(label2);
            grpDatosPolicia.Controls.Add(nudUIT);
            grpDatosPolicia.Controls.Add(btnCancelar);
            grpDatosPolicia.Controls.Add(label10);
            grpDatosPolicia.Controls.Add(cboCalificacion);
            grpDatosPolicia.Controls.Add(txtDescripcion);
            grpDatosPolicia.Controls.Add(label1);
            grpDatosPolicia.Location = new Point(22, 23);
            grpDatosPolicia.Margin = new Padding(6, 4, 6, 4);
            grpDatosPolicia.Name = "grpDatosPolicia";
            grpDatosPolicia.Padding = new Padding(6, 4, 6, 4);
            grpDatosPolicia.Size = new Size(994, 533);
            grpDatosPolicia.TabIndex = 4;
            grpDatosPolicia.TabStop = false;
            grpDatosPolicia.Text = "Actualizar Datos Infraccion";
            grpDatosPolicia.Enter += grpDatosPolicia_Enter;
            // 
            // chkActivo
            // 
            chkActivo.AllowDrop = true;
            chkActivo.Checked = true;
            chkActivo.CheckState = CheckState.Checked;
            chkActivo.Location = new Point(691, 218);
            chkActivo.Margin = new Padding(6, 4, 6, 4);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(204, 47);
            chkActivo.TabIndex = 14;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(579, 222);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(89, 32);
            label6.TabIndex = 13;
            label6.Text = "Estado:";
            // 
            // button1
            // 
            button1.Location = new Point(431, 412);
            button1.Margin = new Padding(6, 6, 6, 6);
            button1.Name = "button1";
            button1.Size = new Size(139, 49);
            button1.TabIndex = 12;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.BorderStyle = BorderStyle.FixedSingle;
            lblCodigo.Location = new Point(152, 51);
            lblCodigo.Margin = new Padding(6, 0, 6, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(162, 47);
            lblCodigo.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 53);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 32);
            label4.TabIndex = 10;
            label4.Text = "Código:";
            // 
            // nudPuntos
            // 
            nudPuntos.Location = new Point(149, 301);
            nudPuntos.Margin = new Padding(6, 6, 6, 6);
            nudPuntos.Name = "nudPuntos";
            nudPuntos.Size = new Size(82, 39);
            nudPuntos.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 299);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 32);
            label3.TabIndex = 8;
            label3.Text = "Puntos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 401);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 32);
            label2.TabIndex = 7;
            label2.Text = "UIT:";
            // 
            // nudUIT
            // 
            nudUIT.Location = new Point(110, 403);
            nudUIT.Margin = new Padding(6, 6, 6, 6);
            nudUIT.Name = "nudUIT";
            nudUIT.Size = new Size(102, 39);
            nudUIT.TabIndex = 6;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(598, 412);
            btnCancelar.Margin = new Padding(6, 4, 6, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(176, 49);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(50, 218);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(140, 32);
            label10.TabIndex = 4;
            label10.Text = "Calificación:";
            // 
            // cboCalificacion
            // 
            cboCalificacion.FormattingEnabled = true;
            cboCalificacion.Items.AddRange(new object[] { "--Seleccione--", "General de Policía", "", "Teniente General", "", "General", "", "Coronel", "", "Comandante", "", "Mayor", "", "Capitán", "", "Teniente", "", "Alférez", "Suboficial Superior", "", "Suboficial Brigadier", "", "Suboficial Técnico de Primera", "", "Suboficial Técnico de Segunda", "", "Suboficial Técnico de Tercera", "", "Suboficial de Primera", "", "Suboficial de Segunda", "", "Suboficial de Tercera" });
            cboCalificacion.Location = new Point(195, 215);
            cboCalificacion.Margin = new Padding(6, 4, 6, 4);
            cboCalificacion.Name = "cboCalificacion";
            cboCalificacion.Size = new Size(309, 40);
            cboCalificacion.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(310, 130);
            txtDescripcion.Margin = new Padding(6, 4, 6, 4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(522, 39);
            txtDescripcion.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 130);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(268, 32);
            label1.TabIndex = 0;
            label1.Text = "Descripción de Sanción:";
            // 
            // InfraccionMan02
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 591);
            Controls.Add(grpDatosPolicia);
            Margin = new Padding(6, 6, 6, 6);
            Name = "InfraccionMan02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar Infraccion";
            Load += InfraccionMan02_Load;
            grpDatosPolicia.ResumeLayout(false);
            grpDatosPolicia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPuntos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudUIT).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatosPolicia;
        private Label label4;
        private NumericUpDown nudPuntos;
        private Label label3;
        private Label label2;
        private NumericUpDown nudUIT;
        private Button btnCancelar;
        private Label label10;
        private ComboBox cboCalificacion;
        private TextBox txtDescripcion;
        private Label label1;
        private Label lblCodigo;
        private Button button1;
        private CheckBox chkActivo;
        private Label label6;
    }
}