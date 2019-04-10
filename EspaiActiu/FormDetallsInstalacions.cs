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
    public partial class FormDetallsInstalacions : Form
    {

        private INSTALACIO instalacio;

        public FormDetallsInstalacions()
        {
            InitializeComponent();
        }

        public FormDetallsInstalacions(INSTALACIO instalacio)
        {
            InitializeComponent();
            this.instalacio = instalacio;
        }

        private void FormDetallsInstalacions_Load(object sender, EventArgs e)
        {
            this.Text = instalacio.nom;

            //cargamos los dias para que se muestren como el nombre del dia no un numero
            bindingSourceDias.DataSource = ORMDia.SelectAllDies();
            //Llamamos al método para cargar la grid con la lista de espacios de una instalacion
            bindingSourceEspais.DataSource = ORMEspai.SelectAllEspaisById(instalacio.id);

            //cargamos grid con los horaris de la instalación filtrando por id
            bindingSourceHoraris.DataSource = ORMInstalacions.SelectHorarisById(instalacio.id);
         

            Refrescar();
        }


        private void Refrescar()
        {
            this.Text = instalacio.nom;

           // lNom.Text = instalacio.nom;
            tbNomInstalacio.Text = instalacio.nom;
            tbAdrecaInstalacio.Text = instalacio.adreca;
         
        }

        private void gbDetallsInstalacio_Enter(object sender, EventArgs e)
        {

        }
    }
}
