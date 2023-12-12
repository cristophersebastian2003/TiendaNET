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
    public partial class frmUsuario : Form
    {
        // OBjeto "usuario" contien las funciones logicas => Registar, lsiatr etc
        Usuario usuario = new Usuario();
        //Objeto #entUsuario" contien los datos => apellidos, nombre, email, clave, etc 
        EUsuario entUsuario = new EUsuario();
        string nivelAccceso = "INV";

        //Reservado un espacion de memoria para el objeto(VIsta Datos)
        DataView dv;
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(Aviso.Preguntar("¿Esta seguro de guardar?")== DialogResult.Yes)
            {
                string claveEncriptada = Crypter.Blowfish.Crypt(txtClave.Text.Trim());


                entUsuario.apellidos = txtApellidos.Text;
                entUsuario.nombres = txtNombres.Text;
                entUsuario.email = txtEmail.Text;
                entUsuario.claveAcceso = claveEncriptada;
                entUsuario.nivelAcceso = nivelAccceso;

                if (usuario.Registrar(entUsuario) > 0)
                {
                    reiniciarInterfaz();
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
            dv = new DataView(usuario.Listar());
            gridUsuarios.DataSource = dv;
            gridUsuarios.Refresh();

            gridUsuarios.Columns[0].Visible = false; // ID
            gridUsuarios.Columns[4].Visible = false; // clave

            gridUsuarios.Columns[1].Width = 450;
            gridUsuarios.Columns[2].Width = 180;
            gridUsuarios.Columns[3].Width = 250;
            gridUsuarios.Columns[5].Width = 150;

            //filas cebradas ( alternado )
            gridUsuarios.AlternatingRowsDefaultCellStyle.BackColor = Color.Aquamarine;
        }

        private void reiniciarInterfaz()
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtEmail.Clear();
            txtClave.Clear();
            optInvitado.Checked = true;
            nivelAccceso = "INV";
            txtApellidos.Focus();
        }
        private void optAdministrador_CheckedChanged(object sender, EventArgs e)
        {
            nivelAccceso = "ADM";
        }

        private void optInvitado_CheckedChanged(object sender, EventArgs e)
        {
            nivelAccceso = "INV";
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            actualizarDatos();
        }

        private void gridUsuarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            gridUsuarios.ClearSelection();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            dv.RowFilter = "apellidos LIKE'%" + txtBuscar.Text + "%' OR nombres LIKE '%" + txtBuscar.Text + "%'";
        }

        private void gridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
