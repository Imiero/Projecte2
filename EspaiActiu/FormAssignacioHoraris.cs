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
    public partial class AssignacioHoraris : Form
    {
        int id_espai, id_activitat;
        FormDetallsPeticio f;


        public AssignacioHoraris(int id_activitat, int id_espai, FormDetallsPeticio f)
        {
            this.id_activitat = id_activitat;
            this.id_espai = id_espai;
            InitializeComponent();
            this.f = f;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            
            //Pasmos los date times a timespans
            DateTime dt = dateTimePickerInici.Value;
            TimeSpan st = new TimeSpan(dt.Hour, dt.Minute, dt.Second);

            DateTime dt2 = dateTimePickerFinal.Value;
            TimeSpan st2 = new TimeSpan(dt2.Hour, dt2.Minute, dt2.Second);

            ORMHorari.InsertHorariActivitat(st, st2, int.Parse(comboBox1.SelectedValue.ToString()), id_activitat, id_espai);
            

            if (checkBoxFinal.Checked)
            {
                f.Close();
                this.Close();
            }
        }

        private void AssignacioHoraris_Load(object sender, EventArgs e)
        {
            dIESSETMANABindingSource.DataSource = ORMDia.SelectAllDies();


        }
    }
}
