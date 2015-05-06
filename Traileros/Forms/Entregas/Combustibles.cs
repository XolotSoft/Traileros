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
            txbPrecio.Text = "14.35";
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
            string precio = txbPrecio.Text;
            string rendimiento = txbRendimiento.Text;
            string litros = txbLitros.Text;
            string costo = txbCosto.Text;

            string sql = "INSERT INTO cargas(carga,origen,destino,partida,arribo,kilo,peaje,operador_id,comision,viaticos,vehiculo_id,precio,rendimiento,litros,costo)VALUES('"+
                Variables.Carga+"','"+Variables.Origen+"','"+Variables.Destino+"','"+Variables.Partida+"','"+Variables.Arribo+"','"+Variables.Kilo+"','"+
                Variables.Peaje+"','"+Variables.Id+"','"+Variables.Comision+"','"+Variables.Viaticos+"','"+Variables.Vehiculo+"','"+precio+"','"+rendimiento+"','"+litros+"','"+costo+"')";
            BaseDatos com = new BaseDatos();
            if (com.insertar(sql))
            {
                if (com.insertar("UPDATE operadores SET estado = 'ocupado' WHERE id = " + Variables.Id))
                {
                    if (com.insertar("UPDATE vehiculos SET estado = 'ocupado' WHERE id = " + Variables.Vehiculo))
                    {
                        MessageBox.Show("Se ha guardado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se realizo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se realizo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se realizo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbRendimiento_Leave(object sender, EventArgs e)
        {
            double precio = 14.35;
            double rendimiento = Convert.ToDouble(txbRendimiento.Text);
            double litros = Convert.ToDouble(Variables.Kilo)/ rendimiento;
            double costo = precio * litros;

            txbLitros.Text = Convert.ToString(litros);
            txbCosto.Text = Convert.ToString(costo);
        }
    }
}
