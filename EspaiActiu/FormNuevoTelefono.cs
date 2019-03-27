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
    public partial class FormNuevoTelefono : Form
    {
        private int id_enti;
        public FormNuevoTelefono(int id_enti)
        {
            InitializeComponent();
            this.id_enti = id_enti;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Estas segur que vols sortir?", "Sortir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FormNuevoTelefono_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Verificamos que ambas textbox esten llenas
            if (textBoxNombre.Text.Length !=0 || textBoxTelefono.Text.Length != 0)
            {
                ORMTelefono.InsertTelefono(id_enti, textBoxNombre.Text, textBoxTelefono.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Tots els camps han de estar omplerts.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
