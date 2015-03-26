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
    public partial class operadorEditar : Form
    {
        public operadorEditar()
        {
            InitializeComponent();
        }

        private static operadorEditar frmInst = null;

        public static operadorEditar Instancia()
        {
            if (frmInst == null || frmInst.IsDisposed == true)
            {
                frmInst = new operadorEditar();
            }

            frmInst.BringToFront();
            return frmInst;
        }

        private void operadorEditar_Load(object sender, EventArgs e)
        {
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has cambiado correctamente los datos", "Correcto",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Deseas Eliminar este registro", "Atención",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(dialogo == DialogResult.OK)
            {

            }
        }
    }
}
