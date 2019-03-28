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
    public partial class FormNuevoEquipo : Form
    {
        
        int id_enti;
        bool detalls = false;
        public FormNuevoEquipo(int id_enti)
        {
            InitializeComponent();
            this.id_enti = id_enti;
        }

        public FormNuevoEquipo(int id_enti, bool detalls)
        {
            InitializeComponent();
            this.id_enti = id_enti;
            this.detalls = detalls;
        }



        private void FormNuevoEquipo_Load(object sender, EventArgs e)
        {

            bindingSourceEsport.DataSource = ORMEsports.SelectAllEsports();
            bindingSourceCompeticio.DataSource = ORMCompeticio.SelectAllCompeticio();
            bindingSourceCategoria.DataSource = ORMCategoria.SelectAllCateogrias();
            bindingSourceEdat.DataSource = ORMCategoriaEdat.SelectAllCateogriasEdat();
            bindingSourceSexe.DataSource = ORMSexe.SelectAllSexes();


        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (textBoxNom.Text.Length != 0)
            {
                ORMEquips.InsertEquipo(id_enti, textBoxNom.Text, (int)comboBoxEsport.SelectedValue, (int)comboBoxCompeticio.SelectedValue, (int)comboBoxCategoria.SelectedValue, (int)comboBoxCategoriaEdat.SelectedValue, (int)comboBoxSexe.SelectedValue);
                MessageBox.Show("Equip creat amb èxit.", "Correcte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else {
                MessageBox.Show("Tots els camps han de estar omplerts.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }
    }
}
