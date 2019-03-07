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

        


        private void bDenegarSollicitut_Click(object sender, EventArgs e)
        {
            FormDenegacio f = new FormDenegacio();
            f.ShowDialog();
            f.Text = "Denegació sol·licitut d'espai";
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
    }
}
