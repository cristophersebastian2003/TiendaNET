using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CryptSharp;
using BOL; // logica
using ENTITIES; // estructura
using DESIGNER.Tools; // herramientas

namespace DESIGNER.Modulos
{
    public partial class frmEmpresa : Form
    {
        // OBjeto "usuario" contien las funciones logicas => Registar, lsiatr etc
        Empresa empresa = new Empresa();
        //Objeto #entUsuario" contien los datos => apellidos, nombre, email, clave, etc 
        EEmpresa entEmpresa = new EEmpresa();
        

        //Reservado un espacion de memoria para el objeto(VIsta Datos)
        DataView dv;
        public frmEmpresa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            actualizarDatos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       

        private void gridEmpresa_KeyUp(object sender, KeyEventArgs e)
        {
           dv.RowFilter = "razonsocial LIKE'%" + txtBuscar1.Text + "%' OR nruc LIKE '%" + txtBuscar1.Text + "%'";
        }

        private void txtBuscar1_KeyUp(object sender, KeyEventArgs e)
        {
            dv.RowFilter = "razonsocial LIKE'%" + txtBuscar1.Text + "%' OR ruc LIKE '%" + txtBuscar1.Text + "%'";
        }

        private void gridEmpresa_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            gridEmpresa.ClearSelection();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtRazonsocial_TextChanged(object sender, EventArgs e)
        {

        }

        private void textRuc_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void textEmail1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textWebsite_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar1_Click(object sender, EventArgs e)
        {
            if (Aviso.Preguntar("¿Esta seguro de guardar?") == DialogResult.Yes)
            {
               


                entEmpresa.razonsocial = txtRazonsocial.Text;
                entEmpresa.ruc = txtRuc.Text;
                entEmpresa.direccion = txtDireccion.Text;
                entEmpresa.telefono = txtTelefono.Text;
                entEmpresa.email = txtEmail1.Text;
                entEmpresa.website = txtWebsite.Text;


                if (empresa.Registrar(entEmpresa) > 0)
                {
                    
                    actualizarDatos(); //actualizacion en el dataview
                    Aviso.Informar("Nuevo usuarios registrado");
                }
                else
                {
                    Aviso.Advertir("No hemos podido terminar el registro");
                }



            }

        }
        private void actualizarDatos()
        {
            dv = new DataView(empresa.Listar());
            gridEmpresa.DataSource = dv;
            gridEmpresa.Refresh();

            gridEmpresa.Columns[0].Visible = false; // ID
            gridEmpresa.Columns[4].Visible = false; // clave

            gridEmpresa.Columns[1].Width = 280;
            gridEmpresa.Columns[2].Width = 180;
            gridEmpresa.Columns[3].Width = 250;
            gridEmpresa.Columns[5].Width = 150;

            //filas cebradas ( alternado )
            gridEmpresa.AlternatingRowsDefaultCellStyle.BackColor = Color.Aquamarine;
        }

        
         private void ReiniciarInterfaz()
        {
            txtRazonsocial.Clear();
            txtRuc.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail1.Clear();
            txtWebsite.Focus();
        }
        
        
    }
}

