namespace ProyPapeleta_GUI
{
    partial class frmLogin
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
            txtLogin = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            txtPassword = new TextBox();
            label2 = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(90, 49);
            txtLogin.Margin = new Padding(4, 3, 4, 3);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(116, 23);
            txtLogin.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(227, 48);
            btnAceptar.Margin = new Padding(4, 3, 4, 3);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(89, 24);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(227, 95);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(89, 23);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(90, 92);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(116, 23);
            txtPassword.TabIndex = 2;
            txtPassword.TextChanged += txtPassword_TextChanged;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 95);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 6;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 48);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 7;
            label1.Text = "Login:";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 159);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtLogin);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingrese su Login y password";
            FormClosed += frmLogin_FormClosed;
            Load += frmLogin_Load;
            KeyDown += frmLogin_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLogin;
        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox txtPassword;
        private Label label2;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}