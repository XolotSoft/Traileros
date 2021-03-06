﻿using System;
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
    public partial class vehiculoNuevo : Form
    {
        public vehiculoNuevo()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
            dtpAdquicision.Format = DateTimePickerFormat.Custom;
            dtpAdquicision.CustomFormat = "yyyy-MM-dd";
            dtpServicio.Format = DateTimePickerFormat.Custom;
            dtpServicio.CustomFormat = "yyyy-MM-dd";
        }

        private static vehiculoNuevo frmInst = null;
        private BaseDatos bd = new BaseDatos();

        public static vehiculoNuevo Instancia()
        {
            if (frmInst == null || frmInst.IsDisposed == true)
            {
                frmInst = new vehiculoNuevo();
            }

            frmInst.BringToFront();
            return frmInst;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (Vacio.txb(this))
            {
                if (Vacio.cbx(this))
                {
                    string sql = "INSERT INTO vehiculos(serie,marca,tipo,modelo,placa,adquicision,servicio,mantenimiento,estado,DF,Chihuahua,Moterrey,Hermosillo)VALUES('"+
                        txbSerie.Text+"','"+txbMarca.Text+"','"+txbTipo.Text+"','"+txbModelo.Text+"','"+txbPlaca.Text+"','"+
                        dtpAdquicision.Text + "','" + dtpServicio.Text + "','" + cmbMantenimiento.Text + "','libre','0','0','0','0')";
                    if (bd.insertar(sql))
                    {
                        MessageBox.Show("Vehiculo agregado correctamente", "Atención",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se guardo el vehiculo", "Atención",
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar.todo(this);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            vehiculosIndex index = null;
            index = vehiculosIndex.Instancia();
            index.MdiParent = MDI.ActiveForm;
            index.Show();
            this.Close();
        }

        private void vehiculoNuevo_Load(object sender, EventArgs e)
        {

        }


    }
}
