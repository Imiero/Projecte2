using EspaiActiu.BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EspaiActiu
{
    public partial class FormLogin : Form
    {
        public static bool correcto = false;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //TODO:validacion here.....

            //Validaciones de las textbox

            if (textBoxContraseña.Text.Length == 0 && textBoxNombre.Text.Length == 0)
            {
                MessageBox.Show("Omplir els camps.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (textBoxNombre.Text.Length == 0)
            {
                MessageBox.Show("Omplir el camp Nom d'usuari.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxNombre.Focus();
            }

            else if (textBoxContraseña.Text.Length == 0)
            {
                MessageBox.Show("Omplir el camp Clau d'accés.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxContraseña.Focus();
            }

            else
            {
                // En este else irian las comprobaciones con el servidor
                List<ADMINS> _admins = ORMAdmins.SelectAllAdmins();
                
                foreach(ADMINS admin in _admins)
                {
                    if(admin.nombre == textBoxNombre.Text)
                    {
                        if(admin.password == textBoxContraseña.Text)
                        {
                            correcto = true;
                        }
                    }

                }

                if (!correcto)
                {
                    MessageBox.Show("Nom o contrasenya incorrectes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBoxNombre.Focus();
                }
            }

            if (correcto)
            {
                this.Close();
            }
        }

        //Botón del ojo para mostar o esconder la contraseña
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (textBoxContraseña.PasswordChar == '*')
            {
                textBoxContraseña.PasswordChar = '\0';
                pictureBoxOjoPassword.Image = Properties.Resources.ojoabierto;
            }

            else if (textBoxContraseña.PasswordChar == '\0')
            {
                textBoxContraseña.PasswordChar = '*';
                pictureBoxOjoPassword.Image = Properties.Resources.ojocerrado;
            }
        }

        protected override void OnShown(EventArgs e)
        {
            textBoxNombre.Focus(); //Abrimos el formularion con el focus en la caja de nombre de usuario
            base.OnShown(e);
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        //Al apretar enter en los textbox se clica sobre el boton de Login
        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin.PerformClick();
                // Suprimir volumne
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
