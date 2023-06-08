using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DesktopOnBoarding
{
    public partial class MenuPrincipal : DevExpress.XtraEditors.XtraForm
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecursosUI ventana = new RecursosUI();

            ventana.Show();

        }

        private void recursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetalleAspectoUI ventana = new DetalleAspectoUI();

            ventana.Show();
        }
    }
}