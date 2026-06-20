using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using ProyVentas_BE;
using ProyVentas_BL;

namespace ProyPapeleta_GUI
{
    public partial class frmLogin : Form
    {
        Int16 intentos = 0;
        Int16 tiempo = 20;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void ProcesarIntentoFallido(string mensaje)
        {
            intentos++;
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (intentos >= 3)
            {
                timer1.Enabled = false;
                MessageBox.Show("Lo sentimos, superó el número de intentos válidos", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Application.Exit();
            }
        }

        private void EntrarAlSistema()
        {
            timer1.Enabled = false;
            this.Hide();
            using (MDIPrincipal mdi = new MDIPrincipal())
            {
                mdi.ShowDialog();
            }

            Application.Exit();
            return;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string usuario = txtLogin.Text.Trim();
            string pass = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(pass))
            {
                ProcesarIntentoFallido("Usuario o Password obligatorios");
                return;
            }

            try
            {
                UsuarioBL objUsuarioBL = new UsuarioBL();
                UsuarioBE objUsuarioBE = objUsuarioBL.ConsultarUsuario(usuario);

                if (string.IsNullOrEmpty(objUsuarioBE.Login_Usuario))
                {
                    ProcesarIntentoFallido("Usuario no encontrado");
                    return;
                }

                if (usuario != objUsuarioBE.Login_Usuario || pass != objUsuarioBE.Pass_Usuario)
                {
                    ProcesarIntentoFallido("Credenciales incorrectas");
                    return;
                }

                if (objUsuarioBE.Est_Usuario != 1)
                {
                    ProcesarIntentoFallido("Usuario inactivo. Contacte al administrador");
                    return;
                }

                if (objUsuarioBE.Niv_Usuario != 1)
                {
                    ProcesarIntentoFallido("Acceso restringido. Por ahora solo el rol Admin puede ingresar");
                    return;
                }

                clsCredenciales.Usuario = objUsuarioBE.Login_Usuario;
                clsCredenciales.Password = objUsuarioBE.Pass_Usuario;
                clsCredenciales.Nivel = objUsuarioBE.Niv_Usuario;

                EntrarAlSistema();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: " + ex.Message, "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo--;
            this.Text = "Ingrese su login y contraseña. Le quedan...." + tiempo;
            if (tiempo == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("Lo sentimos, sobrepaso el tiempo de espera",
                 "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
                return;
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
            Application.Exit();
            return;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnAceptar.PerformClick();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnAceptar.PerformClick();
            }
        }
    }
}