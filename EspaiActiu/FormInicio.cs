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

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;

            Brush _textBrush;

            tabPage1.Text = "sssss";
            tabPage2.Text = @"Something Meaningful";
            tabPage3.Text = @"Something Meaningful";
            // Get the item from the collection.

            TabPage _tabPage = tab.TabPages[e.Index];



            // Get the real bounds for the tab rectangle.

            Rectangle _tabBounds = tab.GetTabRect(e.Index);



            if (e.State == DrawItemState.Selected)

            {



                // Draw a different background color, and don't paint a focus rectangle.

                _textBrush = new SolidBrush(Color.FloralWhite);

                g.FillRectangle(Brushes.DarkSeaGreen, e.Bounds);

            }

            else

            {

                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);

                e.DrawBackground();

            }



            // Use our own font.

            Font _tabFont = new Font("Robot", (float)15.0, FontStyle.Bold, GraphicsUnit.Pixel);



            // Draw string. Center the text.

            StringFormat _stringFlags = new StringFormat();

            _stringFlags.Alignment = StringAlignment.Center;

            _stringFlags.LineAlignment = StringAlignment.Center;

            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }



        private void bDenegarSollicitut_Click(object sender, EventArgs e)
        {
            FormDenegacio f = new FormDenegacio();
            f.ShowDialog();
            f.Text = "Denegació sol·licitut d'espai";
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
    }
}
