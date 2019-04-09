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
    public partial class FormDetallsEspai : Form
    {

        private LLOC_DEPORTIVO espai;

        public FormDetallsEspai()
        {
      
        }

        public FormDetallsEspai(LLOC_DEPORTIVO espai)
        {
            InitializeComponent();
            this.espai = espai;
        }

        private void FormDetallsEspai_Load(object sender, EventArgs e)
        {
            this.Text = espai.nom;
            Refrescar();
        }


        private void Refrescar()
        {
            this.Text = espai.nom;

            lNomEspai.Text = espai.nom;
            tbPreu.Text = espai.preu.ToString()+"€";
            if (espai.exterior)
            {
                cbExterior.Checked = true;
            }

        }

        private void bSortir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
