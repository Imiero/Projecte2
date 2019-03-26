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

            lNomEntitat.Text = entitat.nom;
            lNIF.Text = entitat.nif;
            lNom.Text = entitat.nom;
            lEmail.Text = entitat.correu;
            lAdreça.Text = entitat.adreca;

            
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
    }
}
