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
            InitializeComponent();
            this.espai = espai;
        }

        private void FormDetallsEspai_Load(object sender, EventArgs e)
        {
            this.Text = espai.nom;
        }

        private void Refrescar()
        {
            this.Text = espai.nom;

            lNomEspai.Text = espai.nom;
           //tbPreu = espai.pre;

         
          

        }


    }
}
