using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab02
{
    public partial class PrincipalMDI : Form
    {
        public PrincipalMDI()
        {
            InitializeComponent();
        }

        private void mnuSisSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuManUsuarios_Click(object sender, EventArgs e)
        {
            manUsuario frm = new manUsuario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuManProductos_Click(object sender, EventArgs e)
        {
            manProductos frm = new manProductos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuManCategorias_Click(object sender, EventArgs e)
        {
            manCategorias frm = new manCategorias();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuManProveedores_Click(object sender, EventArgs e)
        {
            manProveedores frm = new manProveedores();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuManClientes_Click(object sender, EventArgs e)
        {
            manClientes frm = new manClientes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuProRegistrarVenta_Click(object sender, EventArgs e)
        {
            regVentas frm = new regVentas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuProRegistrarCompra_Click(object sender, EventArgs e)
        {
            regCompras frm = new regCompras();
            frm.MdiParent = this;
            frm.Show();
        }

        private void RepReporteVentas_Click(object sender, EventArgs e)
        {
            repVentas frm = new repVentas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void RepReporteCompras_Click(object sender, EventArgs e)
        {
            repCompras frm = new repCompras();
            frm.MdiParent = this;
            frm.Show();
        }

        private void RepInventarioProductos_Click(object sender, EventArgs e)
        {
            repInventario frm = new repInventario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void RepReporteProveedores_Click(object sender, EventArgs e)
        {
            repProveedores frm = new repProveedores();
            frm.MdiParent = this;
            frm.Show();
        }

        private void RepReporteUsuarios_Click(object sender, EventArgs e)
        {
            repUsuarios frm = new repUsuarios();
            frm.MdiParent = this;
            frm.Show();
        }

        private void RepReporteClientes_Click(object sender, EventArgs e)
        {
            repClientes frm = new repClientes();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
