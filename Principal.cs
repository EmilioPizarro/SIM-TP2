using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_2
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnUniforme_Click(object sender, EventArgs e)
        {
            DistroUniforme formUniforme = new DistroUniforme();
            formUniforme.Show();
            this.Hide();


        }

        private void btnExponencial_Click(object sender, EventArgs e)
        {
            DistroExponencial formExponenial = new DistroExponencial();
            formExponenial.Show();
            this.Hide();

        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            DistroNormal formNormal = new DistroNormal();
            formNormal.Show();
            this.Hide();

        }
    }
}
