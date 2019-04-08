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

    public partial class FormDetallsPeticio : Form
    {

        private ACTIVIDADES_DEMANADAS activitat;
        public FormDetallsPeticio(ACTIVIDADES_DEMANADAS activitat)
        {
            InitializeComponent();
            this.activitat = activitat;
        }

        private void FormDetallsPeticio_Load(object sender, EventArgs e)
        {
            //Creamos los objetos que vamos a ir necesitando
            EQUIPS equip = ORMEquips.SelectEquiposByID(activitat.id_equipo);
            TIPUS_ACTIVIDAD tipu_acti = ORMTipoActividad.SelectTipoActividadByID(activitat.id_tipus_actividad);
            LLOC_DEPORTIVO espai = ORMEspai.SelectEspaiFiltroID(activitat.id_espai);

            List<ACTIVITATS> listActi = ORMActivitats.SelectActivitatsByInstalacion(espai.id);


            bindingSourceHorarisActivitats.DataSource = ORMHorari.SelectAllHorarisByInstalacio(espai.id_instalacions);      

            
            bindingSourceHorariDemanat.DataSource = ORMHorari.SelectAllHoraris(activitat.id);
            bindingSourceHorariInstalacio.DataSource = ORMInstalacions.SelectHorarisById(espai.id_instalacions);


            //Cargamos los datos de la peticion
            textBoxNombre.Text = activitat.nom;
            textBoxDurada.Text = activitat.durada + " H";
            textBoxEquip.Text = equip.nom;
            textBoxTipusActivitat.Text = tipu_acti.nom;
            textBoxEspai.Text = espai.nom;

           

            }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            EQUIPS equip = ORMEquips.SelectEquiposByID(activitat.id_equipo);
            FormNuevoEquipo f = new FormNuevoEquipo(equip, true,1);
            f.Show();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonSortir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDetallsEspai_Click(object sender, EventArgs e)
        {
            FormDetallsEspai f = new FormDetallsEspai();
        }

        private void comboBoxDias_SelectedIndexChanged(object sender, EventArgs e)
        {

            

        }

        private void comboBoxDias_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void bindingSourceHorari_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxInstalacio_Enter(object sender, EventArgs e)
        {

        }
    }
}
