namespace ProyPapeleta_GUI
{
    partial class InfraccionMan04
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
            lblDescripcion = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnEliminarInfraccion = new Button();
            btnCancelar = new Button();
            label10 = new Label();
            label1 = new Label();
            txtCod = new TextBox();
            lblCalificacion = new Label();
            lblPuntos = new Label();
            lblUIT = new Label();
            grpDatosPolicia.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatosPolicia
            // 
            grpDatosPolicia.Controls.Add(lblUIT);
            grpDatosPolicia.Controls.Add(lblPuntos);
            grpDatosPolicia.Controls.Add(lblCalificacion);
            grpDatosPolicia.Controls.Add(txtCod);
            grpDatosPolicia.Controls.Add(lblDescripcion);
            grpDatosPolicia.Controls.Add(label4);
            grpDatosPolicia.Controls.Add(label3);
            grpDatosPolicia.Controls.Add(label2);
            grpDatosPolicia.Controls.Add(btnEliminarInfraccion);
            grpDatosPolicia.Controls.Add(btnCancelar);
            grpDatosPolicia.Controls.Add(label10);
            grpDatosPolicia.Controls.Add(label1);
            grpDatosPolicia.Location = new Point(12, 11);
            grpDatosPolicia.Margin = new Padding(3, 2, 3, 2);
            grpDatosPolicia.Name = "grpDatosPolicia";
            grpDatosPolicia.Padding = new Padding(3, 2, 3, 2);
            grpDatosPolicia.Size = new Size(535, 250);
            grpDatosPolicia.TabIndex = 5;
            grpDatosPolicia.TabStop = false;
            grpDatosPolicia.Text = "Eliminar Infraccion";
            // 
            // lblDescripcion
            // 
            lblDescripcion.BorderStyle = BorderStyle.FixedSingle;
            lblDescripcion.Location = new Point(167, 60);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(216, 23);
            lblDescripcion.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 24);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 10;
            label4.Text = "Código:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 139);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 8;
            label3.Text = "Puntos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 187);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 7;
            label2.Text = "UIT:";
            // 
            // btnEliminarInfraccion
            // 
            btnEliminarInfraccion.Location = new Point(196, 192);
            btnEliminarInfraccion.Margin = new Padding(3, 2, 3, 2);
            btnEliminarInfraccion.Name = "btnEliminarInfraccion";
            btnEliminarInfraccion.Size = new Size(93, 24);
            btnEliminarInfraccion.TabIndex = 1;
            btnEliminarInfraccion.Text = "Eliminar";
            btnEliminarInfraccion.UseVisualStyleBackColor = true;
            btnEliminarInfraccion.Click += btnEliminarInfraccion_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(322, 193);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(95, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(27, 101);
            label10.Name = "label10";
            label10.Size = new Size(72, 15);
            label10.TabIndex = 4;
            label10.Text = "Calificación:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 60);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 0;
            label1.Text = "Descripción de Sanción:";
            // 
            // txtCod
            // 
            txtCod.Location = new Point(81, 21);
            txtCod.Margin = new Padding(2, 1, 2, 1);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(110, 23);
            txtCod.TabIndex = 13;
            // 
            // lblCalificacion
            // 
            lblCalificacion.BorderStyle = BorderStyle.FixedSingle;
            lblCalificacion.Location = new Point(115, 100);
            lblCalificacion.Name = "lblCalificacion";
            lblCalificacion.Size = new Size(216, 23);
            lblCalificacion.TabIndex = 14;
            // 
            // lblPuntos
            // 
            lblPuntos.BorderStyle = BorderStyle.FixedSingle;
            lblPuntos.Location = new Point(81, 138);
            lblPuntos.Name = "lblPuntos";
            lblPuntos.Size = new Size(52, 23);
            lblPuntos.TabIndex = 15;
            // 
            // lblUIT
            // 
            lblUIT.BorderStyle = BorderStyle.FixedSingle;
            lblUIT.Location = new Point(59, 186);
            lblUIT.Name = "lblUIT";
            lblUIT.Size = new Size(52, 23);
            lblUIT.TabIndex = 16;
            // 
            // InfraccionMan04
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 276);
            Controls.Add(grpDatosPolicia);
            Name = "InfraccionMan04";
            Text = "Eliminar Infraccion";
            Load += InfraccionMan04_Load;
            grpDatosPolicia.ResumeLayout(false);
            grpDatosPolicia.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatosPolicia;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnEliminarInfraccion;
        private Button btnCancelar;
        private Label label10;
        private Label label1;
        private Label lblDescripcion;
        private Label lblUIT;
        private Label lblPuntos;
        private Label lblCalificacion;
        private TextBox txtCod;
    }
}