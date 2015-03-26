using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traileros
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void operadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            operadorIndex index = null;
            index = operadorIndex.Instancia();
            index.MdiParent = this;
            index.Show();
            Form frm = this.MdiChildren.FirstOrDefault(x => x is operadorEditar || x is operadorNuevo);
            if (frm != null) frm.Close();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usuarioIndex index = new usuarioIndex();
            index.MdiParent = this;
            index.Show();
        }

        private void vehículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vehiculoIndex index = new vehiculoIndex();
            index.MdiParent = this;
            index.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
