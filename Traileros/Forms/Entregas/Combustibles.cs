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
    public partial class Combustibles : Form
    {
        public Combustibles()
        {
            InitializeComponent();
        }

        private static Combustibles frmInst = null;

        public static Combustibles Instancia()
        {
            if (frmInst == null || frmInst.IsDisposed == true)
            {
                frmInst = new Combustibles();
            }

            frmInst.BringToFront();
            return frmInst;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
