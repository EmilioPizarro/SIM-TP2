using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_2.Entidades;

namespace TP_2
{
    public partial class DistroNormal : Form
    {
        private Funciones funciones = new Funciones();
        public DistroNormal()
        {
            InitializeComponent();
        }

        private void valorMuestra_KeyPress(object sender, KeyPressEventArgs e)
        {
            funciones.ProcesarTeclaPresionada(sender, e);
        }

        private void valorMedia_KeyPress(object sender, KeyPressEventArgs e)
        {
            funciones.ProcesarTeclaPresionada(sender, e);
        }

        private void valorDesviacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            funciones.ProcesarTeclaPresionada(sender, e);
        }


        private void btnInicio_Click(object sender, EventArgs e)
        {
            Principal formPrincipal = new Principal();
            formPrincipal.Show();
            this.Close();
        }

        private void btnGenerarSerie_Click(object sender, EventArgs e)
        {
            //limpio el datagrid cada vez que genero una serie
            dtgSerie.Rows.Clear();
        }

        
    }
}
