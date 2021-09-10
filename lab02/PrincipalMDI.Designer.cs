
namespace lab02
{
    partial class PrincipalMDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSisSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProRegistrarVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProRegistrarCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.RepReporteVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.RepReporteCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.RepInventarioProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.RepReporteProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.RepReporteUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.RepReporteClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSistema,
            this.mnuMantenimiento,
            this.mnuProcesos,
            this.mnuReportes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuSistema
            // 
            this.mnuSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSisSalir});
            this.mnuSistema.Name = "mnuSistema";
            this.mnuSistema.Size = new System.Drawing.Size(60, 20);
            this.mnuSistema.Text = "Sistema";
            // 
            // mnuSisSalir
            // 
            this.mnuSisSalir.Name = "mnuSisSalir";
            this.mnuSisSalir.Size = new System.Drawing.Size(96, 22);
            this.mnuSisSalir.Text = "Salir";
            this.mnuSisSalir.Click += new System.EventHandler(this.mnuSisSalir_Click);
            // 
            // mnuMantenimiento
            // 
            this.mnuMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManUsuarios,
            this.mnuManProductos,
            this.mnuManCategorias,
            this.mnuManProveedores,
            this.mnuManClientes});
            this.mnuMantenimiento.Name = "mnuMantenimiento";
            this.mnuMantenimiento.Size = new System.Drawing.Size(101, 20);
            this.mnuMantenimiento.Text = "Mantenimiento";
            // 
            // mnuManUsuarios
            // 
            this.mnuManUsuarios.Name = "mnuManUsuarios";
            this.mnuManUsuarios.Size = new System.Drawing.Size(139, 22);
            this.mnuManUsuarios.Text = "Usuarios";
            this.mnuManUsuarios.Click += new System.EventHandler(this.mnuManUsuarios_Click);
            // 
            // mnuManProductos
            // 
            this.mnuManProductos.Name = "mnuManProductos";
            this.mnuManProductos.Size = new System.Drawing.Size(139, 22);
            this.mnuManProductos.Text = "Productos";
            this.mnuManProductos.Click += new System.EventHandler(this.mnuManProductos_Click);
            // 
            // mnuManCategorias
            // 
            this.mnuManCategorias.Name = "mnuManCategorias";
            this.mnuManCategorias.Size = new System.Drawing.Size(139, 22);
            this.mnuManCategorias.Text = "Categorias";
            this.mnuManCategorias.Click += new System.EventHandler(this.mnuManCategorias_Click);
            // 
            // mnuManProveedores
            // 
            this.mnuManProveedores.Name = "mnuManProveedores";
            this.mnuManProveedores.Size = new System.Drawing.Size(139, 22);
            this.mnuManProveedores.Text = "Proveedores";
            this.mnuManProveedores.Click += new System.EventHandler(this.mnuManProveedores_Click);
            // 
            // mnuManClientes
            // 
            this.mnuManClientes.Name = "mnuManClientes";
            this.mnuManClientes.Size = new System.Drawing.Size(139, 22);
            this.mnuManClientes.Text = "Clientes";
            this.mnuManClientes.Click += new System.EventHandler(this.mnuManClientes_Click);
            // 
            // mnuProcesos
            // 
            this.mnuProcesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProRegistrarVenta,
            this.mnuProRegistrarCompra});
            this.mnuProcesos.Name = "mnuProcesos";
            this.mnuProcesos.Size = new System.Drawing.Size(66, 20);
            this.mnuProcesos.Text = "Procesos";
            // 
            // mnuProRegistrarVenta
            // 
            this.mnuProRegistrarVenta.Name = "mnuProRegistrarVenta";
            this.mnuProRegistrarVenta.Size = new System.Drawing.Size(180, 22);
            this.mnuProRegistrarVenta.Text = "Registrar Venta";
            this.mnuProRegistrarVenta.Click += new System.EventHandler(this.mnuProRegistrarVenta_Click);
            // 
            // mnuProRegistrarCompra
            // 
            this.mnuProRegistrarCompra.Name = "mnuProRegistrarCompra";
            this.mnuProRegistrarCompra.Size = new System.Drawing.Size(180, 22);
            this.mnuProRegistrarCompra.Text = "Registrar Compra";
            this.mnuProRegistrarCompra.Click += new System.EventHandler(this.mnuProRegistrarCompra_Click);
            // 
            // mnuReportes
            // 
            this.mnuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RepReporteVentas,
            this.RepReporteCompras,
            this.RepInventarioProductos,
            this.RepReporteProveedores,
            this.RepReporteUsuarios,
            this.RepReporteClientes});
            this.mnuReportes.Name = "mnuReportes";
            this.mnuReportes.Size = new System.Drawing.Size(65, 20);
            this.mnuReportes.Text = "Reportes";
            // 
            // RepReporteVentas
            // 
            this.RepReporteVentas.Name = "RepReporteVentas";
            this.RepReporteVentas.Size = new System.Drawing.Size(204, 22);
            this.RepReporteVentas.Text = "Reporte de ventas";
            this.RepReporteVentas.Click += new System.EventHandler(this.RepReporteVentas_Click);
            // 
            // RepReporteCompras
            // 
            this.RepReporteCompras.Name = "RepReporteCompras";
            this.RepReporteCompras.Size = new System.Drawing.Size(204, 22);
            this.RepReporteCompras.Text = "Reporte de Compras";
            this.RepReporteCompras.Click += new System.EventHandler(this.RepReporteCompras_Click);
            // 
            // RepInventarioProductos
            // 
            this.RepInventarioProductos.Name = "RepInventarioProductos";
            this.RepInventarioProductos.Size = new System.Drawing.Size(204, 22);
            this.RepInventarioProductos.Text = "Inventario de Productos";
            this.RepInventarioProductos.Click += new System.EventHandler(this.RepInventarioProductos_Click);
            // 
            // RepReporteProveedores
            // 
            this.RepReporteProveedores.Name = "RepReporteProveedores";
            this.RepReporteProveedores.Size = new System.Drawing.Size(204, 22);
            this.RepReporteProveedores.Text = "Reportes de Proveedores";
            this.RepReporteProveedores.Click += new System.EventHandler(this.RepReporteProveedores_Click);
            // 
            // RepReporteUsuarios
            // 
            this.RepReporteUsuarios.Name = "RepReporteUsuarios";
            this.RepReporteUsuarios.Size = new System.Drawing.Size(204, 22);
            this.RepReporteUsuarios.Text = "Reporte de Usuarios";
            this.RepReporteUsuarios.Click += new System.EventHandler(this.RepReporteUsuarios_Click);
            // 
            // RepReporteClientes
            // 
            this.RepReporteClientes.Name = "RepReporteClientes";
            this.RepReporteClientes.Size = new System.Drawing.Size(204, 22);
            this.RepReporteClientes.Text = "Reporte de Clientes";
            this.RepReporteClientes.Click += new System.EventHandler(this.RepReporteClientes_Click);
            // 
            // PrincipalMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSistema;
        private System.Windows.Forms.ToolStripMenuItem mnuSisSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuMantenimiento;
        private System.Windows.Forms.ToolStripMenuItem mnuManUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuManProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuManCategorias;
        private System.Windows.Forms.ToolStripMenuItem mnuManProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuManClientes;
        private System.Windows.Forms.ToolStripMenuItem mnuProcesos;
        private System.Windows.Forms.ToolStripMenuItem mnuProRegistrarVenta;
        private System.Windows.Forms.ToolStripMenuItem mnuProRegistrarCompra;
        private System.Windows.Forms.ToolStripMenuItem mnuReportes;
        private System.Windows.Forms.ToolStripMenuItem RepReporteVentas;
        private System.Windows.Forms.ToolStripMenuItem RepReporteCompras;
        private System.Windows.Forms.ToolStripMenuItem RepInventarioProductos;
        private System.Windows.Forms.ToolStripMenuItem RepReporteProveedores;
        private System.Windows.Forms.ToolStripMenuItem RepReporteUsuarios;
        private System.Windows.Forms.ToolStripMenuItem RepReporteClientes;
    }
}