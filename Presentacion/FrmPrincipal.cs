﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtmSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtmMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void AbrirFrm(object frmHija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form frmAux = frmHija as Form;
            frmAux.TopLevel = false;
            frmAux.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(frmAux);
            this.panelContenedor.Tag = frmAux;
            frmAux.Show();
        }

        private void BtmProveedor_Click(object sender, EventArgs e)
        {
            AbrirFrm(new FrmProveedor());
        }

        private void BtmInventario_Click(object sender, EventArgs e)
        {
            AbrirFrm(new FrmInventario());
        }

        private void BtmCompra_Click(object sender, EventArgs e)
        {
            AbrirFrm(new FrmCotizacion());
        }

        private void BtmVenta_Click(object sender, EventArgs e)
        {
            AbrirFrm(new FrmVenta());
        }

        private void BtmReportes_Click(object sender, EventArgs e)
        {
            AbrirFrm(new FrmReportes());
        }

        private void BtmConsultas_Click(object sender, EventArgs e)
        {
            AbrirFrm(new FrmConsultas());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirFrm(new FrmInicio());
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            pictureBox1_Click(null, e);
        }
    }
}
