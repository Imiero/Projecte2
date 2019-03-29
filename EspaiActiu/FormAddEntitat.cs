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
    public partial class FormAddEntitat : Form
    {
        public FormAddEntitat()
        {
            InitializeComponent();
        }

        private void bSortir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Estas segur que vols sortir?", "Sortir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
        }

        private void bAceptar_Click(object sender, EventArgs e)
        { 
            //Primero verificamos que se ha llenado todos los campos
            if (tbContrasenya.Text.Length == 0 || tbContrasenya2.Text.Length == 0 || tbCorreu.Text.Length == 0 || tbNIF.Text.Length == 0 || tbUsuari.Text.Length == 0 || textBoxAdreça.Text.Length == 0 || textBoxTemporada.Text.Length == 0)
            {
                MessageBox.Show("Omplir els camps.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //Verificamos que la contraseña tenga mas de 4 caracteres
            else if (tbContrasenya.Text.Length < 4 && tbContrasenya2.Text.Length < 4)
            {
                MessageBox.Show("La contrasenya ha de tenir mes de 4 caràcters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //Ahora verificamos que las contraseñas coincidan
            else if (tbContrasenya.Text != tbContrasenya2.Text)
            {
                MessageBox.Show("Les contrasenyes no coincideixen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }                        

            //El NIF solo puede ser de 9 caracteres, se podría ampliar verificando que sean 8 numeros y 1 letra
            else if (tbNIF.Text.Length != 9)
            {
                MessageBox.Show("El NIF ha de ser de 9 caràcters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else //Si todos los campos estan correctos se crea la entidad con los datos y se cierra la ventana.
            {
                ORMEntitats.InsertEntitat(tbUsuari.Text, textBoxTemporada.Text, textBoxAdreça.Text, tbNIF.Text, tbCorreu.Text, tbContrasenya.Text);
                MessageBox.Show("Entitat creada amb èxit.", "Correcte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void FormAddEntitat_Load(object sender, EventArgs e)
        {

        }

        private void FormAddEntitat_KeyDown(object sender, KeyEventArgs e)
        {
      
            if (e.KeyCode == Keys.Enter)
            {
                bAceptar.PerformClick();
                // Suprimir volumne
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        
    }

        private void tbUsuari_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
