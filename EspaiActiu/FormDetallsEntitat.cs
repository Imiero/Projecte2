﻿using EspaiActiu.BD;
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
   
    //TO DO: Preguntar a Francisco porque cuando generas una entidad, durante la "sesion" que la has generado no aparecen en la lista de telefonos o equipos (Se pueden crear y estan en la BD)


    public partial class FormDetallsEntitat : Form
    {
        private ENTITATS entitat;
        bool alta = false;


        public FormDetallsEntitat(ENTITATS entitat)
        {
            InitializeComponent();
            this.entitat = entitat;
        }


        private void FormDetallsEntitat_Load(object sender, EventArgs e)
        {
            this.Text = entitat.nom;
            //bindingSourceTelefons.DataSource = ORMTelefono.SelectTelefonosByEntitat(entitat.id);
            bindingSourceTelefons.DataSource = entitat.TELEFONS.ToList();
            bindingSourceEquips.DataSource = entitat.EQUIPS.ToList();
            

            Refrescar();
            
        }

        private void lTelefon_Click(object sender, EventArgs e)
        {

        }

        private void lNIF_Click(object sender, EventArgs e)
        {

        }

        private void lAdreça_Click(object sender, EventArgs e)
        {

        }

        private void lEmail_Click(object sender, EventArgs e)
        {

        }

        private void lNom_Click(object sender, EventArgs e)
        {

        }

        private void lvEquips_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Estas segur que vols modificar?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Verificamos que todos los campos esten llenos
                if(textBoxNom.Text.Length != 0 && textBoxTemp.Text.Length != 0 && textBoxAdreça.Text.Length != 0 && textBoxNIF.Text.Length == 9 && textBoxCorreu.Text.Length != 0)
                {
                    ORMEntitats.UpdateEntitat(textBoxNom.Text, textBoxTemp.Text, textBoxAdreça.Text, textBoxNIF.Text, textBoxCorreu.Text, entitat.id);
                    MessageBox.Show("Entitat modificada amb éxit.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }


                else
                {
                    MessageBox.Show("Tots els camps han de estar omplerts.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                                
            }
        }


        private void Refrescar()
        {
            this.Text = entitat.nom;

            lNomEntitat.Text = entitat.nom;
            textBoxNIF.Text = entitat.nif;
            textBoxNom.Text = entitat.nom;
            textBoxCorreu.Text = entitat.correu;
            textBoxAdreça.Text = entitat.adreca;
            textBoxTemp.Text = entitat.temporada;
        }

        private void pictureBoxNuevoTelefono_Click(object sender, EventArgs e)
        {
            FormNuevoTelefono f = new FormNuevoTelefono(entitat.id);
            alta = true;
            f.ShowDialog();
        }

        private void bindingSourceTelefons_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void FormDetallsEntitat_Activated(object sender, EventArgs e)
        {
            if (alta)
            {
                bindingSourceTelefons.DataSource = entitat.TELEFONS.ToList();
                bindingSourceEquips.DataSource = entitat.EQUIPS.ToList();
                alta = false;
            }
            
        }

        private void listBoxTelefons_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                DialogResult result = MessageBox.Show("Segur que vols eliminar el telèfon?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if(result == DialogResult.Yes)
                {
                    ORMTelefono.DeleteTelefon((TELEFONS)listBoxTelefons.SelectedItem);
                    bindingSourceTelefons.DataSource = entitat.TELEFONS.ToList();
                }                
                
            }
        }

        private void listBoxTelefons_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxNouEquip_Click(object sender, EventArgs e)
        {
            alta = true;
            FormNuevoEquipo f = new FormNuevoEquipo(entitat.id);
            f.Show();
        }

        private void listBoxEquips_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult result = MessageBox.Show("Segur que vols eliminar el equip?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    ORMEquips.DeleteEquip((EQUIPS)listBoxEquips.SelectedItem);
                    bindingSourceEquips.DataSource = entitat.EQUIPS.ToList();
                }

            }
        }

        private void listBoxEquips_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxTelefons_DoubleClick(object sender, EventArgs e)
        {
            alta = true;
            try
            {
                int id_telef = (int)listBoxTelefons.SelectedValue;
                FormNuevoTelefono f = new FormNuevoTelefono(id_telef, true);
                f.Show();
            }
            catch (Exception)
            {

            }
        }

        private void listBoxEquips_DoubleClick(object sender, EventArgs e)
        {
            alta = true;
            try
            {
                int id_equip = (int)listBoxEquips.SelectedValue;
                FormNuevoEquipo f = new FormNuevoEquipo((EQUIPS)listBoxEquips.SelectedItem, true,0);
                f.Show();
            }
            catch (Exception)
            {

            }
        }

        private void pictureBoxBorrarTele_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Segur que vols eliminar el telèfon?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                ORMTelefono.DeleteTelefon((TELEFONS)listBoxTelefons.SelectedItem);
                bindingSourceTelefons.DataSource = entitat.TELEFONS.ToList();
            }
        }

        private void pictureBoxBorrarEquipo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Segur que vols eliminar el equip?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                ORMEquips.DeleteEquip((EQUIPS)listBoxEquips.SelectedItem);
                bindingSourceEquips.DataSource = entitat.EQUIPS.ToList();
            }
        }
    }
}
