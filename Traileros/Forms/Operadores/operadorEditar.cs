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

        private void operadorEditar_Load(object sender, EventArgs e)
        {

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

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
