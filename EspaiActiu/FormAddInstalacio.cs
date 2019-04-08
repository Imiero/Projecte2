using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EspaiActiu.BD;

namespace EspaiActiu
{
    public partial class FormAddInstalacio : Form
    {
        public FormAddInstalacio()
        {
            InitializeComponent();
        }
    //CANCELAR
        private void bCancelar_Click(object sender, EventArgs e)
        {
            //Antes aseguramos
            DialogResult result = MessageBox.Show("Estas segur que vols sortir?", "Sortir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
   //ACEPTAR
        //Verificamos que los campos esten introducidos correctamente
        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (tbNomInstalacio.Text.Length == 0 || tbAdrecaInstalacio.Text.Length == 0) {
                MessageBox.Show("Omplir els camps.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else //Si todos los campos estan correctos se crea la instalación y cerramos ventana mostrando mensaje.
            {
                //Llamamos método para crear instalación recibiendo el id
                int idInst = ORMInstalacions.InsertInstalcion(tbNomInstalacio.Text, tbAdrecaInstalacio.Text, cbEsPropi.Checked);

               
                //Para crear los horarios de la instalación creamos dos listas de horario inicio y final
                List<DateTime> obertures = new List<DateTime>();
                obertures.Add(dtpInici1.Value); obertures.Add(dtpInici2.Value); obertures.Add(dtpInici3.Value); obertures.Add(dtpInici4.Value);
                obertures.Add(dtpInici5.Value); obertures.Add(dtpInici6.Value); obertures.Add(dtpInici7.Value);

                List<DateTime> tancaments = new List<DateTime>();
                tancaments.Add(dtpFi1.Value); tancaments.Add(dtpFi2.Value); tancaments.Add(dtpFi3.Value); tancaments.Add(dtpFi4.Value);
                tancaments.Add(dtpFi5.Value); tancaments.Add(dtpFi6.Value); tancaments.Add(dtpFi7.Value);

                //Llamamos al método para crear los horarios
                ORMHorarisInstalacio.InsertHorarisInstalacio(idInst, obertures, tancaments);

                MessageBox.Show("Entitat creada amb èxit.", "Correcte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        
    }
}
