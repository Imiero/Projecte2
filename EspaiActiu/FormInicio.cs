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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();

        }

        //myLabel.ForeColor = System.Drawing.Color.Red;
        //myLabel.ForeColor = Color.FromArgb(0, 0, 0);//(R, G, B) (0, 0, 0 = black)

        private void resetColors()
        {
            Petilabel.ForeColor = System.Drawing.Color.Black;
            EspaLabel.ForeColor = System.Drawing.Color.Black;
            Entitatslabel.ForeColor = System.Drawing.Color.Black;
            label9.ForeColor = System.Drawing.Color.Black;
        }
        private void tabPeticio()
        {
            tabControl.SelectedIndex = 0;
            resetColors();
            Petilabel.ForeColor = System.Drawing.Color.White;
            
        }
        private void tabEspais()
        {
            tabControl.SelectedIndex = 1;
            resetColors();
            EspaLabel.ForeColor = System.Drawing.Color.White;
            
        }
        private void tabEquips()
        {
            tabControl.SelectedIndex = 2;
            resetColors();
            Entitatslabel.ForeColor = System.Drawing.Color.White;

        }

        private void tabAdmins()
        {
            tabControl.SelectedIndex = 3;
            resetColors();
            label9.ForeColor = System.Drawing.Color.White;

        }
        private void Sortir()
        {
            this.Close();
        }

        private void bDenegarSollicitut_Click(object sender, EventArgs e)
        {


        }

        private void bAfegirEntitat_Click(object sender, EventArgs e)
        {
            FormAddEntitat f = new FormAddEntitat();
            f.Show();
        }

        private void bAfegirEspai_Click(object sender, EventArgs e)
        {
            FormAddEspai f = new FormAddEspai();
            f.Show();
        }

        #region Label, panel, picturebox etc... Clicks
        private void label1_Click(object sender, EventArgs e)
        {
            tabPeticio();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            tabPeticio();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tabPeticio();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Sortir();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Sortir();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            Sortir();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            tabEspais();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tabEspais();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            tabEspais();
        }

        private void Equipslabel_Click(object sender, EventArgs e)
        {
            tabEquips();
        }

        private void EquipsPanel_Click(object sender, EventArgs e)
        {
            tabEquips();
        }

        private void EquipsImage_Click(object sender, EventArgs e)
        {
            tabEquips();
        }

        #endregion


        private void FormInicio_Load(object sender, EventArgs e)
        {
            tabPeticio();

            //cargamos grids
            bindingSourceEntitats.DataSource = ORMEntitats.SelectAllEntitats();
            bindingSourcePeticions.DataSource = ORMActivitatsDemandades.SelectAllActvitats();
            bindingSourceInstalacions.DataSource = ORMInstalacions.SelectAllInstalacions();
            bindingSourceActivitats.DataSource = ORMActivitats.SelectAllActvitats();
            bindingSourceAdmins.DataSource = ORMAdmins.SelectAllAdmins();

        }


        private void buttonAddEspai_Click(object sender, EventArgs e)
        {
            FormAddEspai fEspai = new FormAddEspai();
            fEspai.ShowDialog();
        }

        //Al clicar en el boton de "Afegir" abririamos el form "FormAddEntitat" para crear una entidad
        private void buttonAddEntitat_Click(object sender, EventArgs e)
        {
            FormAddEntitat fEnti = new FormAddEntitat();
            fEnti.ShowDialog();
        }

        private void dataGridViewEntitats_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingSourceEntitats_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void tabPagePeticions_Click(object sender, EventArgs e)
        {

        }

        //Al escribir algo en la textbox se filtra el contenido de la GridView de entidades por nombre
        private void textBoxCercarEntitats_TextChanged(object sender, EventArgs e)
        {
            bindingSourceEntitats.DataSource = ORMEntitats.SelectEntitatsByNom(textBoxCercarEntitats.Text);
        }

        private void buttonCercarEntitat_Click(object sender, EventArgs e)
        {

        }

        //Al volver a esta pantalla se refresca la grid
        private void FormInicio_Activated(object sender, EventArgs e)
        {
            bindingSourceEntitats.DataSource = ORMEntitats.SelectEntitatsByNom(textBoxCercarEntitats.Text);
            bindingSourceInstalacions.DataSource = ORMInstalacions.SelectInstalacionssByNom(textBoxCercarEspais.Text);
            bindingSourcePeticions.DataSource = ORMActivitatsDemandades.SelectAllActvitats();
            bindingSourceActivitats.DataSource = ORMActivitats.SelectAllActvitats();

        }

        //Al pulsar suprimir sobre un elemento de la Grid aparece un mensaje de confirmacion, en caso de pulsar "Yes" se borra la entidad con la funcion "DeleteEntitat" pasandole el objeto seleccionado en la grid.
        private void dataGridViewEntitats_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult result3 = MessageBox.Show("Segur que vols eliminar l'entitat?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result3 == DialogResult.Yes)
            {
                ORMEntitats.DeleteEntitat((ENTITATS)dataGridViewEntitats.SelectedRows[0].DataBoundItem);
            }
            else
            {
                e.Cancel = true;
            }
        }

        //Abrir los detalles de una entidad al hacer doble click en una
        private void dataGridViewEntitats_DoubleClick(object sender, EventArgs e)
        {
            ENTITATS entitat = (ENTITATS)dataGridViewEntitats.CurrentRow.DataBoundItem;

            FormDetallsEntitat f = new FormDetallsEntitat(entitat);
            f.Show();
        }

        //Al clicar una instalacion abrir form de detalles
        private void dataGridViewInstalacions_DoubleClick(object sender, EventArgs e)
        {
            INSTALACIO instalacio = (INSTALACIO)dataGridViewInstalacions.CurrentRow.DataBoundItem;

            FormDetallsInstalacions f = new FormDetallsInstalacions(instalacio);
            f.Show();
        }


        private void groupBoxEntitats_Enter(object sender, EventArgs e)
        {

        }

     

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxBuscarPeticion_TextChanged(object sender, EventArgs e)
        {
            bindingSourcePeticions.DataSource = ORMActivitatsDemandades.SelectEntitatsByNom(textBoxBuscarPeticion.Text);
        }

        private void dataGridViewPeticio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                ACTIVIDADES_DEMANADAS activitat = (ACTIVIDADES_DEMANADAS)dataGridViewPeticio.CurrentRow.DataBoundItem;
                
                FormDetallsPeticio f = new FormDetallsPeticio(activitat);
                f.ShowDialog();
            
        }

        //Al escribir algo en la textbox de búsqueda se filtra el contenido de la GridView de instalaciones por nombre
        private void textBoxCercarEspais_TextChanged(object sender, EventArgs e)
        {
            bindingSourceInstalacions.DataSource = ORMInstalacions.SelectInstalacionssByNom(textBoxCercarEspais.Text);
        }

        private void tabPageEspais_Click(object sender, EventArgs e)
        {

        }
        //Agregar Instalación
        private void bAfegirInstalacio_Click(object sender, EventArgs e)
        {
            FormAddInstalacio fInst = new FormAddInstalacio();
            fInst.ShowDialog();
        }

        private void textBoxBuscarActivitat_TextChanged(object sender, EventArgs e)
        {
            bindingSourceActivitats.DataSource = ORMActivitats.SelectActivitatsByNom(textBoxBuscarActivitat.Text);
        }

        private void dataGridViewActivitats_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult result4 = MessageBox.Show("Segur que vols eliminar l'admin?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result4 == DialogResult.Yes)
            {
                ORMAdmins.DeleteAdmin((ADMINS)dataGridView1.SelectedRows[0].DataBoundItem);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void buttonAcceptar_Click(object sender, EventArgs e)
        {
                if (textBoxNom.Text.Length == 0 || textBoxPAss.Text.Length < 4 || textBoxCorreu.Text.Length == 0)
                {
                    MessageBox.Show("Les dades son incorrectes.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



                else
                {
                    ORMAdmins.InsertAdmin(textBoxNom.Text, textBoxPAss.Text, textBoxCorreu.Text);
                    //Refrescamos la grid
                    bindingSourceAdmins.DataSource = ORMAdmins.SelectAllAdmins();
                    //Dejamos las textbox limpias
                    textBoxNom.Text = "";
                    textBoxPAss.Text = "";
                    textBoxCorreu.Text = "";

                }



        }

        private void label9_Click(object sender, EventArgs e)
        {
            tabAdmins();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            tabAdmins();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            tabAdmins();
        }

    }
}
