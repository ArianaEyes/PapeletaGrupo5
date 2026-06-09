namespace ProyPapeleta_GUI
{
    partial class InfraccionMan03
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
            lblEstado = new Label();
            label6 = new Label();
            lblUIT = new Label();
            lblPuntos = new Label();
            lblCalificacion = new Label();
            lblDescripcion = new Label();
            txtCod = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnConsultarInfraccion = new Button();
            btnCancelar = new Button();
            label10 = new Label();
            label1 = new Label();
            lblMedida = new Label();
            label7 = new Label();
            grpDatosPolicia.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatosPolicia
            // 
            grpDatosPolicia.Controls.Add(label7);
            grpDatosPolicia.Controls.Add(lblMedida);
            grpDatosPolicia.Controls.Add(lblEstado);
            grpDatosPolicia.Controls.Add(label6);
            grpDatosPolicia.Controls.Add(lblUIT);
            grpDatosPolicia.Controls.Add(lblPuntos);
            grpDatosPolicia.Controls.Add(lblCalificacion);
            grpDatosPolicia.Controls.Add(lblDescripcion);
            grpDatosPolicia.Controls.Add(txtCod);
            grpDatosPolicia.Controls.Add(label4);
            grpDatosPolicia.Controls.Add(label3);
            grpDatosPolicia.Controls.Add(label2);
            grpDatosPolicia.Controls.Add(btnConsultarInfraccion);
            grpDatosPolicia.Controls.Add(btnCancelar);
            grpDatosPolicia.Controls.Add(label10);
            grpDatosPolicia.Controls.Add(label1);
            grpDatosPolicia.Location = new Point(12, 11);
            grpDatosPolicia.Margin = new Padding(3, 2, 3, 2);
            grpDatosPolicia.Name = "grpDatosPolicia";
            grpDatosPolicia.Padding = new Padding(3, 2, 3, 2);
            grpDatosPolicia.Size = new Size(652, 304);
            grpDatosPolicia.TabIndex = 3;
            grpDatosPolicia.TabStop = false;
            grpDatosPolicia.Text = "Consultar Infracción";
            grpDatosPolicia.Enter += grpDatosPolicia_Enter;
            // 
            // lblEstado
            // 
            lblEstado.BorderStyle = BorderStyle.FixedSingle;
            lblEstado.Location = new Point(369, 181);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(90, 23);
            lblEstado.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(318, 183);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 16;
            label6.Text = "Estado:";
            // 
            // lblUIT
            // 
            lblUIT.BorderStyle = BorderStyle.FixedSingle;
            lblUIT.Location = new Point(59, 188);
            lblUIT.Name = "lblUIT";
            lblUIT.Size = new Size(51, 23);
            lblUIT.TabIndex = 15;
            // 
            // lblPuntos
            // 
            lblPuntos.BorderStyle = BorderStyle.FixedSingle;
            lblPuntos.Location = new Point(82, 140);
            lblPuntos.Name = "lblPuntos";
            lblPuntos.Size = new Size(51, 23);
            lblPuntos.TabIndex = 14;
            // 
            // lblCalificacion
            // 
            lblCalificacion.BorderStyle = BorderStyle.FixedSingle;
            lblCalificacion.Location = new Point(105, 102);
            lblCalificacion.Name = "lblCalificacion";
            lblCalificacion.Size = new Size(168, 23);
            lblCalificacion.TabIndex = 13;
            // 
            // lblDescripcion
            // 
            lblDescripcion.BorderStyle = BorderStyle.FixedSingle;
            lblDescripcion.Location = new Point(176, 61);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(269, 23);
            lblDescripcion.TabIndex = 12;
            // 
            // txtCod
            // 
            txtCod.Location = new Point(82, 23);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(100, 23);
            txtCod.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 26);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 10;
            label4.Text = "Código:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 141);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 8;
            label3.Text = "Puntos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 189);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 7;
            label2.Text = "UIT:";
            // 
            // btnConsultarInfraccion
            // 
            btnConsultarInfraccion.Location = new Point(322, 249);
            btnConsultarInfraccion.Margin = new Padding(3, 2, 3, 2);
            btnConsultarInfraccion.Name = "btnConsultarInfraccion";
            btnConsultarInfraccion.Size = new Size(93, 24);
            btnConsultarInfraccion.TabIndex = 1;
            btnConsultarInfraccion.Text = "Consultar";
            btnConsultarInfraccion.UseVisualStyleBackColor = true;
            btnConsultarInfraccion.Click += btnAgregarInfraccion_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(448, 250);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(95, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(27, 103);
            label10.Name = "label10";
            label10.Size = new Size(72, 15);
            label10.TabIndex = 4;
            label10.Text = "Calificación:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 62);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 0;
            label1.Text = "Descripción de Sanción:";
            // 
            // lblMedida
            // 
            lblMedida.BorderStyle = BorderStyle.FixedSingle;
            lblMedida.Location = new Point(448, 102);
            lblMedida.Name = "lblMedida";
            lblMedida.Size = new Size(168, 23);
            lblMedida.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(334, 103);
            label7.Name = "label7";
            label7.Size = new Size(108, 15);
            label7.TabIndex = 21;
            label7.Text = "Medida Preventiva:";
            // 
            // InfraccionMan03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 326);
            Controls.Add(grpDatosPolicia);
            Name = "InfraccionMan03";
            Text = "Consultar Datos Infracción";
            Load += InfraccionMan03_Load;
            grpDatosPolicia.ResumeLayout(false);
            grpDatosPolicia.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatosPolicia;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnConsultarInfraccion;
        private Button btnCancelar;
        private Label label10;
        private Label label1;
        private Label lblCalificacion;
        private Label lblDescripcion;
        private TextBox txtCod;
        private Label lblUIT;
        private Label lblPuntos;
        private Label label6;
        private Label lblEstado;
        private Label lblMedida;
        private Label label7;
    }
}