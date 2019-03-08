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



           if(correcto)
            {
                this.Close();
            }
            else
            {
                DialogResult error = MessageBox.Show("Verificar Credenciales","Atenció",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void ButtonValidar_Click(object sender, EventArgs e)
        {
            correcto = true;
        }
    }
}
