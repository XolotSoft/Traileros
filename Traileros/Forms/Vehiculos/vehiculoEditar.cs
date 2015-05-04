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
    public partial class vehiculoEditar : Form
    {
        public vehiculoEditar()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
            dtpAdquicision.Format = DateTimePickerFormat.Custom;
            dtpAdquicision.CustomFormat = "yyyy-MM-dd";
            dtpServicio.Format = DateTimePickerFormat.Custom;
            dtpServicio.CustomFormat = "yyyy-MM-dd";
        }

        private static vehiculoEditar frmInst = null;
        private BaseDatos bd = new BaseDatos();

        public static vehiculoEditar Instancia()
        {
            if (frmInst == null || frmInst.IsDisposed == true)
            {
                frmInst = new vehiculoEditar();
            }

            frmInst.BringToFront();
            return frmInst;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            vehiculosIndex index = null;
            index = vehiculosIndex.Instancia();
            index.MdiParent = MDI.ActiveForm;
            index.Show();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM vehiculos WHERE id = '" + Variables.id + "'";
            if (bd.insertar(sql))
            {
                MessageBox.Show("Se ha eliminado correctamente el vehiculo", "Correcto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuarioIndex index = null;
                index = usuarioIndex.Instancia();
                index.MdiParent = MDI.ActiveForm;
                index.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("No se ha eliminado", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {

            string sql = "UPDATE vehiculos SET serie = '" + txbSerie.Text + "', marca = '" + txbMarca.Text + "', tipo = '" + txbTipo.Text +
                "', modelo = '" + txbModelo.Text + "', placa = '" + txbPlaca.Text + "', adquicision = '" + dtpAdquicision.Text +
                "', servicio = '" + dtpServicio.Text + "', mantenimiento = '" + cmbMes.Text + "' WHERE id = '" + Variables.id + "'";
            if (Vacio.txb(this))
            {
                if (Vacio.cbx(this))
                { 
                    if (bd.insertar(sql))
                    {
                        MessageBox.Show("Se ha modificado correctamente el vehiculo", "Correcto",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        usuarioIndex index = null;
                        index = usuarioIndex.Instancia();
                        index.MdiParent = MDI.ActiveForm;
                        index.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se ha modificado", "Atención",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }  
                }
                else
                {
                    MessageBox.Show("Debes seleccionar una opción", "Atención",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debes llenar todos los campos", "Atención",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
