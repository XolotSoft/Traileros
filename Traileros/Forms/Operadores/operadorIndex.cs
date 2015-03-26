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
    public partial class operadorIndex : Form
    {
        public operadorIndex()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private static operadorIndex frmInst = null;
        private BaseDatos bd = new BaseDatos();

        public static operadorIndex Instancia()
        {
            if (frmInst == null || frmInst.IsDisposed == true)
            {
                frmInst = new operadorIndex();
            }

            frmInst.BringToFront();
            return frmInst;
        }

        private void operadorIndex_Load(object sender, EventArgs e)
        {
            bd.buscar("SELECT id AS ID, nombre AS Nombre, paterno AS Paterno, materno AS Materno, licencia AS Licencia FROM operadores");
            
            dgvOperador.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOperador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOperador.RowHeadersVisible = false;
            dgvOperador.DataSource = bd.ds.Tables[0];  
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            operadorNuevo nuevo = null;
            nuevo = operadorNuevo.Instancia();
            nuevo.MdiParent = MDI.ActiveForm;
            nuevo.Show();
            this.Close();
        }

        private void dgvOperador_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            operadorEditar editar = null;
            editar = operadorEditar.Instancia();
            editar.MdiParent = MDI.ActiveForm;
            editar.Show();
            this.Close();
        }

    }
}
