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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        
        private void tabPeticio()
        {
            FormDenegacio f = new FormDenegacio();
            f.ShowDialog();
        }
        private void Sortir()
        {
            this.Close();
        }

        private void bDenegarSollicitut_Click(object sender, EventArgs e)
        {


        }

        private void bAfegirEntitat_Click(object sender, EventArgs e)
        {
            FormAddEntitat f = new FormAddEntitat();
            f.Show();
        }

        private void bAfegirEspai_Click(object sender, EventArgs e)
        {
            FormAddEspai f = new FormAddEspai();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            tabPeticio();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            tabPeticio();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tabPeticio();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Sortir();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Sortir();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            Sortir();
        }
    }
}
