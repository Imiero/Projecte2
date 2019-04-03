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
            HORARIS_ACT_DEMANADA horari = ORMHorari.SelectEquiposByID(activitat.id);
            EQUIPS equip = ORMEquips.SelectEquiposByID(activitat.id_equipo);
            DIES_SETMANA dia = ORMDia.SelectDiaByID(horari.dia);
            TIPUS_ACTIVIDAD tipu_acti = ORMTipoActividad.SelectTipoActividadByID(activitat.id_tipus_actividad);

            //Hacer el equivalente del equipo al espacio para assignar la TextBoxEspai como la del equipo.
            //Cargamos los datos de la peticion
            textBoxNombre.Text = activitat.nom;
            textBoxDurada.Text = activitat.durada;
            textBoxEquip.Text = equip.nom;
            textBoxInici.Text = horari.horari_inici.ToString();
            textBoxFinal.Text = horari.horari_fi.ToString();
            textBoxDia.Text = dia.dia;
            textBoxTipusActivitat.Text = tipu_acti.nom;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
