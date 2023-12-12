using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOL;
using DESIGNER.Tools;
using ENTITIES;
namespace DESIGNER.Modulos
{
    public partial class frmProductos : Form
    {
        Producto producto = new Producto();
        Marca marca = new Marca();
        Categoria categoria = new Categoria();
        Subcategoria subcategoria = new Subcategoria();
        EProducto entProducto = new EProducto();
        //Bandera = variable Logica que controla estados
        bool categoriasListas = false;
        bool subcategoriasListas = false;

        public frmProductos()
        {

            InitializeComponent();
        }
        private void ActualizarMarcas()
        {
            cboMarca.DataSource = marca.Listar();
            cboMarca.DisplayMember = "Marcas";
            cboMarca.ValueMember = "idmarca";
            cboMarca.Refresh();
        }
        private void ActualizarCategorias()
        {
            cboCategoria.DataSource = categoria.Listar();
            cboCategoria.DisplayMember = "categoria";
            cboCategoria.ValueMember = "idcategoria";
            cboCategoria.Refresh();
            cboCategoria.Text = "";

        }
        

  
        private void ActualizarDatos()
        {
            gridProductos.DataSource = producto.Listar();
            gridProductos.Refresh();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            ActualizarDatos();
            ActualizarMarcas();
            ActualizarCategorias();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(categoriasListas == true)
            { 
            int idcategoria = Convert.ToInt32(cboCategoria.SelectedValue.ToString());
                cboCategoria.DataSource = categoria.Listar(idcategoria);
                cboCategoria.DisplayMember = "categoria";
                cboCategoria.ValueMember = "idcategoria";
                cboCategoria.Refresh();
                cboCategoria.Text = "";
            }
        }

        private void cboSubcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subcategoriasListas == true)
            {
                int idsubcategoria = Convert.ToInt32(cboSubcategoria.SelectedValue.ToString());
                cboSubcategoria.DataSource = subcategoria.Listar(idsubcategoria);
                cboSubcategoria.DisplayMember = "subcategoria";
                cboSubcategoria.ValueMember = "idsubcategoria";
                cboSubcategoria.Refresh();
                cboSubcategoria.Text = "";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(Aviso.Preguntar("¿Esta seguro de registrar un nuevo producto?")==DialogResult.Yes)
            {
                entProducto.idmarca = Convert.ToInt32(cboMarca.SelectedValue.ToString());
                entProducto.idsubcategoria = Convert.ToInt32(cboCategoria.SelectedValue.ToString());
                entProducto.descripcion = txtDescripcion.Text;
                entProducto.garantia = Convert.ToInt32(txtGarantia.Text);
                entProducto.precio = Convert.ToDouble(txtPrecio.Text);
                entProducto.stock = Convert.ToInt32(txtStock);

                if (producto.registrar(entProducto)>0)
                {
                    reiniciarInterfaz();
                    actualizarProdcutos();
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //1. Crear instacioa dle reporte (CrystalReport)
            Reportes.rptProductos reporte = new Reportes.rptProductos();
            //2. asignrar los datos al objeto reporte(creao paso a paso 1)
            reporte.SetDataSource(producto.Listar());
            reporte.Refresh();

            //3. Instanciar el formulario deonde se mostraran los reportes,
            Reportes.VisorReportes formulario = new Reportes.VisorReportes();

            //4. Pasamos el reporte al Visor
            formulario.visor.ReportSorce = reporte;
            object p = formulario.visor.Refresh();

            formulario.ShowDialog();



        }
    }
}