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



        //al clicar un espaicio en la lista de instalaciones id a detalles
        private void dgvLlistaEspais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LLOC_DEPORTIVO espai = (LLOC_DEPORTIVO)dgvLlistaEspais.CurrentRow.DataBoundItem;

            FormDetallsEspai f = new FormDetallsEspai(espai);
            f.Show();

        }
        
        //Modificar
        private void bModificar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Estas segur que vols modificar?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //Verificamos que todos los campos esten llenos______________ mirar como modificar horarios
                if (tbNomInstalacio.Text.Length != 0 && tbAdrecaInstalacio.Text.Length != 0)
                {
    
                    ORMInstalacions.UpdateInstalacio(tbNomInstalacio.Text, tbAdrecaInstalacio.Text, instalacio.id);
                    MessageBox.Show("Entitat modificada amb éxit.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }


                else
                {
                    MessageBox.Show("Tots els camps han de estar omplerts.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        //Eliminar
        private void bEliminar_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Estas segur que vols eliminar la instalacio?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //ORMInstalacions.DeleteInstalacio(instalacio);
                MessageBox.Show("La instalacio ha estat eliminada.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
