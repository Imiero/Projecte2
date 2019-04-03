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
        EQUIPS equip;
        int id_enti,id_equip,check = 0;
        bool detalls = false;        
        public FormNuevoEquipo(int id_enti)
        {
            InitializeComponent();
            this.id_enti = id_enti;
        }

        public FormNuevoEquipo(EQUIPS equip, bool detalls, int check)
        {
            InitializeComponent();
            this.equip = equip;
            this.detalls = detalls;
            this.check = check;
        }



        private void FormNuevoEquipo_Load(object sender, EventArgs e)
        {
            //Cargar la combo desde la funcion de "ORMHorarisInstalacio" para poder cargar los dias y las horas y tal...
            bindingSourceEsport.DataSource = ORMEsports.SelectAllEsports();
            bindingSourceCompeticio.DataSource = ORMCompeticio.SelectAllCompeticio();
            bindingSourceCategoria.DataSource = ORMCategoria.SelectAllCateogrias();
            bindingSourceEdat.DataSource = ORMCategoriaEdat.SelectAllCateogriasEdat();
            bindingSourceSexe.DataSource = ORMSexe.SelectAllSexes();

            //En caso de abrirse a causa de un doble click en uno de los equipos tendriamos preseleccionados los detalles del mismo
            if (detalls)
            {
                this.id_equip = equip.id;

                this.Text = "Detalls del equip";
                this.textBoxNom.Text = equip.nom;
                this.comboBoxCategoria.SelectedItem= equip.CATEGORIA_NIVELL;
                this.comboBoxCategoriaEdat.SelectedItem = equip.CATEGORIA_EDAT;
                this.comboBoxCompeticio.SelectedItem = equip.COMPETICIO;
                this.comboBoxEsport.SelectedItem = equip.SPORTS;
                this.comboBoxSexe.SelectedItem = equip.SEXE;
                
                this.buttonAceptar.Visible = false;
                this.buttonModificar.Visible = true;

                if(check == 1) //En caso de abrirse desde una peticion, no se puede modificar nada
                {

                    this.Text = "Detalls del equip";
                    this.textBoxNom.Enabled = false;
                    this.comboBoxCategoria.Enabled = false;
                    this.comboBoxCategoriaEdat.Enabled = false;
                    this.comboBoxCompeticio.Enabled = false;
                    this.comboBoxEsport.Enabled = false;
                    this.comboBoxSexe.Enabled = false;

                    this.buttonModificar.Visible = false;
                }

            }

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

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (textBoxNom.Text.Length != 0)
            {
                ORMEquips.UpdateEquipo(textBoxNom.Text, (int)comboBoxEsport.SelectedValue, (int)comboBoxCompeticio.SelectedValue, (int)comboBoxCategoria.SelectedValue, (int)comboBoxCategoriaEdat.SelectedValue, (int)comboBoxSexe.SelectedValue, id_equip);
                MessageBox.Show("Equip modificat amb èxit.", "Correcte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Tots els camps han de estar omplerts.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
