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

        //myLabel.ForeColor = System.Drawing.Color.Red;
        //myLabel.ForeColor = Color.FromArgb(0, 0, 0);//(R, G, B) (0, 0, 0 = black)

        private void resetColors()
        {
            Petilabel.ForeColor = System.Drawing.Color.Black;
            EspaLabel.ForeColor = System.Drawing.Color.Black;
            Entitatslabel.ForeColor = System.Drawing.Color.Black;
        }
        private void tabPeticio()
        {
            tabControl1.SelectedIndex = 0;
            resetColors();
            Petilabel.ForeColor = System.Drawing.Color.White;
            
        }
        private void tabEspais()
        {
            tabControl1.SelectedIndex = 1;
            resetColors();
            EspaLabel.ForeColor = System.Drawing.Color.White;
            
        }
        private void tabEquips()
        {
            tabControl1.SelectedIndex = 2;
            resetColors();
            Entitatslabel.ForeColor = System.Drawing.Color.White;

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

        private void label2_Click(object sender, EventArgs e)
        {
            tabEspais();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tabEspais();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            tabEspais();
        }

        private void Equipslabel_Click(object sender, EventArgs e)
        {
            tabEquips();
        }

        private void EquipsPanel_Click(object sender, EventArgs e)
        {
            tabEquips();
        }

        private void EquipsImage_Click(object sender, EventArgs e)
        {
            tabEquips();
        }




        private void FormInicio_Load(object sender, EventArgs e)
        {
            tabPeticio();
        }


        private void buttonAddEspai_Click(object sender, EventArgs e)
        {
            FormAddEspai fEspai = new FormAddEspai();
            fEspai.ShowDialog();
        }

        private void buttonAddEntitat_Click(object sender, EventArgs e)
        {
            FormAddEntitat fEnti = new FormAddEntitat();
            fEnti.ShowDialog();
        }

    }
}
