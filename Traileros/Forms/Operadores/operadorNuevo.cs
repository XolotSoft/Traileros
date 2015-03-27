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
            dtpNacimiento.Format = DateTimePickerFormat.Custom;
            dtpNacimiento.CustomFormat = "yyyy-MM-dd";
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
                txbNombre.Text+"','"+txbPaterno.Text+"','"+txbMaterno.Text+"','"+dtpNacimiento.Text+"','"+txbCalle.Text+"','"+txbNumero.Text+"','"+txbColonia.Text+"','"+cmbDelegacion.Text+"','"+txbTelefono.Text+"','"+txbEmail.Text+"','"+txbLicencia.Text+"')";
            if (bd.insertar(sql))
            {
                MessageBox.Show("Se ha agregado correctamente el operador", "Correcto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                operadorIndex index = null;
                index = operadorIndex.Instancia();
                index.MdiParent = MDI.ActiveForm;
                index.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("No se agrego el operador", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar.txb(this);
        }
    }
}
