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
            // dtgInfraccion
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
            // txtFiltro
            // 
            txtFiltro.Location = new Point(446, 62);
            txtFiltro.Margin = new Padding(6, 4, 6, 4);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(767, 39);
            txtFiltro.TabIndex = 8;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new Point(121, 753);
            btnRefrescar.Margin = new Padding(6, 4, 6, 4);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(193, 73);
            btnRefrescar.TabIndex = 31;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(400, 753);
            btnInsertar.Margin = new Padding(6, 4, 6, 4);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(228, 73);
            btnInsertar.TabIndex = 32;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(720, 753);
            btnEliminar.Margin = new Padding(6, 4, 6, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(243, 73);
            btnEliminar.TabIndex = 34;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1021, 753);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(115, 32);
            label3.TabIndex = 35;
            label3.Text = "Registros:";
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(1140, 732);
            lblRegistros.Margin = new Padding(6, 0, 6, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(197, 72);
            lblRegistros.TabIndex = 36;
            // 
            // btnSalir
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
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 326);
            Controls.Add(grpDatosPolicia);
            Name = "InfraccionMan03";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar Infracción";
            Load += InfraccionMan05_Load;
            ((System.ComponentModel.ISupportInitialize)dtgInfraccion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgInfraccion;
        private Label label1;
        private TextBox txtFiltro;
        private Button btnRefrescar;
        private Button btnInsertar;
        private Button btnEliminar;
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