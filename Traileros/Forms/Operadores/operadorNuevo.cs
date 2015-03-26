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
    public partial class operadorNuevo : Form
    {
        public operadorNuevo()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private static operadorNuevo frmInst = null;
        private BaseDatos bd = new BaseDatos();

        public static operadorNuevo Instancia()
        {
            if (frmInst == null || frmInst.IsDisposed == true)
            {
                frmInst = new operadorNuevo();
            }

            frmInst.BringToFront();
            return frmInst;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO operadores(nombre,paterno,materno,nacimiento,calle,numero,colonia,delegacion,telefono,email,licencia) VALUES ('"+
                txbNombre.Text+"','"+txbPaterno.Text+"','"+txbMaterno.Text+"','"+dtpNacimiento.Value+"','"+txbCalle.Text+"','"+txbNumero.Text+"','"+txbColonia.Text+"','"+cmbDelegacion.ValueMember+"','"+txbTelefono.Text+"','"+txbEmail.Text+"','"+txbLicencia.Text+"')";
            if (bd.insertar(sql))
            {

            }
            else
            {

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar.txb(this);
        }
    }
}
