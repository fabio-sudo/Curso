using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "7";
        }

        private void btCalcula_Click(object sender, EventArgs e)
        {

        }

        private void btApagarTudo_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
        }


    }
}
