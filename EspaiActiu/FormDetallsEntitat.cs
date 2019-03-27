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
    public partial class FormDetallsEntitat : Form
    {
        private ENTITATS entitat;

        public FormDetallsEntitat(ENTITATS entitat)
        {
            InitializeComponent();
            this.entitat = entitat;
        }


        private void FormDetallsEntitat_Load(object sender, EventArgs e)
        {
            this.Text = entitat.nom;

            Refresh();
            
        }

        private void lTelefon_Click(object sender, EventArgs e)
        {

        }

        private void lNIF_Click(object sender, EventArgs e)
        {

        }

        private void lAdreça_Click(object sender, EventArgs e)
        {

        }

        private void lEmail_Click(object sender, EventArgs e)
        {

        }

        private void lNom_Click(object sender, EventArgs e)
        {

        }

        private void lvEquips_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Estas segur que vols modificar?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Verificamos que todos los campos esten llenos
                if(textBoxNom.Text.Length != 0 || textBoxTemp.Text.Length != 0 || textBoxAdreça.Text.Length != 0 || textBoxNIF.Text.Length != 0 || textBoxCorreu.Text.Length != 0)
                {
                    ORMEntitats.UpdateEntitat(textBoxNom.Text, textBoxTemp.Text, textBoxAdreça.Text, textBoxNIF.Text, textBoxCorreu.Text, entitat.id);
                    MessageBox.Show("Entitat modificada amb éxit.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    //Refrescamos los datos
                    Refresh();
                }
                else
                {
                    MessageBox.Show("Tots els camps han de estar omplerts.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                                
            }
        }


        private void Refresh()
        {
            this.Text = entitat.nom;

            lNomEntitat.Text = entitat.nom;
            textBoxNIF.Text = entitat.nif;
            textBoxNom.Text = entitat.nom;
            textBoxCorreu.Text = entitat.correu;
            textBoxAdreça.Text = entitat.adreca;
            textBoxTemp.Text = entitat.temporada;
        }

        private void bindingSourceTelefons_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
