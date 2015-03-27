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
            dtpNacimiento.Format = DateTimePickerFormat.Custom;
            dtpNacimiento.CustomFormat = "yyyy-MM-dd";
            MinimizeBox = false;
            MaximizeBox = false;
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
            BaseDatos bd = new BaseDatos();
            bd.buscar("SELECT * FROM operadores where id = '"+Variables.id+"'");
            txbNombre.Text = Convert.ToString(bd.ds.Tables[0].Rows[0]["nombre"]);
            txbPaterno.Text = Convert.ToString(bd.ds.Tables[0].Rows[0]["paterno"]);
            txbMaterno.Text = Convert.ToString(bd.ds.Tables[0].Rows[0]["materno"]);
            txbCalle.Text = Convert.ToString(bd.ds.Tables[0].Rows[0]["calle"]);
            txbNumero.Text = Convert.ToString(bd.ds.Tables[0].Rows[0]["numero"]);
            txbColonia.Text = Convert.ToString(bd.ds.Tables[0].Rows[0]["colonia"]);
            cmbDelegacion.Text = Convert.ToString(bd.ds.Tables[0].Rows[0]["delegacion"]);
            txbTelefono.Text = Convert.ToString(bd.ds.Tables[0].Rows[0]["telefono"]);
            txbEmail.Text = Convert.ToString(bd.ds.Tables[0].Rows[0]["email"]);
            txbLicencia.Text = Convert.ToString(bd.ds.Tables[0].Rows[0]["licencia"]);
            dtpNacimiento.Text = Convert.ToString(bd.ds.Tables[0].Rows[0]["nacimiento"]);
            
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            BaseDatos bd = new BaseDatos();
            string sql = "UPDATE operadores SET nombre = '" + txbNombre.Text + "',paterno = '" + txbPaterno.Text + "',materno = '" +
                txbMaterno.Text + "',calle = '" + txbCalle.Text + "',numero = '" + txbNumero.Text + "',nacimiento = '" +
                dtpNacimiento.Text + "',colonia = '" + txbColonia.Text + "',telefono = '" + txbTelefono.Text + "',delegacion = '" +
                cmbDelegacion.Text+ "',email = '" + txbEmail.Text + "',licencia = '" + txbLicencia.Text + "' WHERE id = '"+Variables.id+"'  ";
            if (bd.insertar(sql)) 
            {
                MessageBox.Show("Se ha modificado correctamente el operador", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                operadorIndex index = null;
                index = operadorIndex.Instancia();
                index.MdiParent = MDI.ActiveForm;
                index.Show();
            }
        }

        private void btnElimar_Click(object sender, EventArgs e)
        {
            BaseDatos bd = new BaseDatos();
            string sql = "DELETE FROM operadores WHERE id = '"+Variables.id+"'";
            if (bd.insertar(sql))
            {
                MessageBox.Show("Se ha eliminado correctamente el operador");
                this.Hide();
                operadorIndex index = null;
                index = operadorIndex.Instancia();
                index.MdiParent = MDI.ActiveForm;
                index.Show();
            }
        }


  
    }
}
