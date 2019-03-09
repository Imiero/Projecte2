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
    public partial class FormAddEntitat : Form
    {
        public FormAddEntitat()
        {
            InitializeComponent();
        }

        private void bSortir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
