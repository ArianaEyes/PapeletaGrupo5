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
        // Declaramos variableas de intentos y tiempo....
        Int16 intentos = 0;
        Int16 tiempo = 20;

        public frmLogin()
        {
            InitializeComponent();
        }
        private void ProcesarIntentoFallido(string mensaje)
        {
            intentos++;//Incrementamos el numero de intentos
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (intentos >= 3)
            {
                MessageBox.Show("Lo sentimos, superó el número de intentos válidos", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Application.Exit();
            }
        }
        private void EntrarAlSistema()
        {
            //"Apagamos" el timer y ocultamos el frmLogin
            timer1.Enabled = false;
            this.Hide();
            // Usamos 'using' para que el formulario MDIPrincipal se destruya correctamente al cerrar
            using (MDIPrincipal mdi = new MDIPrincipal())
            {
                mdi.ShowDialog();
            }
            //Al cerrar el MDIPrincipal termina la aplicacion
            Application.Exit();
            return;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Se obtienen los valores de las credenciales
            string usuario = txtLogin.Text.Trim();
            string pass = txtPassword.Text.Trim();

            // Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(pass))
            {
                ProcesarIntentoFallido("Usuario o Password obligatorios");
                return;
            }
            try
            {
                // Codifique
                UsuarioBE objUsuarioBE = new UsuarioBE();
                UsuarioBL objUsuarioBL = new UsuarioBL();

                //Invocamos el metodo ConsultarUsuario 
                objUsuarioBE = objUsuarioBL.ConsultarUsuario(txtLogin.Text.Trim());

                //Validamos 
                if (usuario == objUsuarioBE.Login_Usuario & pass == objUsuarioBE.Pass_Usuario)
                {
                    //Guardamos en la clase clsCredenciales el Usuario, password y nivel de usuario logeado
                    clsCredenciales.Usuario = objUsuarioBE.Login_Usuario;
                    clsCredenciales.Password = objUsuarioBE.Pass_Usuario;
                    clsCredenciales.Nivel = objUsuarioBE.Niv_Usuario;


                    EntrarAlSistema();
                }
                else
                {
                    ProcesarIntentoFallido("Credenciales incorrectas");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: " + ex.Message, "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            //Enviamos mensaje de tiempo restante para el logueo
            tiempo--; //decrementamos la variable tiempo
            this.Text = "Ingrese su login y contraseña. Le quedan...." + tiempo;
            if (tiempo == 0)
            {
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
            // Para al pulsar Enter acceder al MDI...
            if (e.KeyCode == Keys.Enter)
            {
                btnAceptar.PerformClick();

            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
