using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DESIGNER.Tools; //traemos nuestras herramientas
//  INCLUIR LA LIBRERIAS
using CryptSharp;
using BOL;

namespace DESIGNER
{
    public partial class frmLogin : Form
    {
        //INSTANCIA DE LA CLASE
        Usuario usuario = new Usuario();
        DataTable dtRpta = new DataTable();

        // CONSTRUCTOR
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Login()
        {
            // TRIM QUITA LOS ESPACIOS
            if (txtEmail.Text.Trim() == String.Empty)
            {
                errorLogin.SetError(txtEmail, "Por favor ingrese su email");
                txtEmail.Focus();
            }
            else
            {
                errorLogin.Clear();
                txtClaveAcceso.Focus();

                // LOS DATOS FUERON INGRESADO, VALIDAMOS EL USUARIO


                dtRpta = usuario.iniciarSesion(txtEmail.Text);
                // COMPROBAR SI EL USUAURIO EXISTE
                if (dtRpta.Rows.Count > 0)
                {
                    
                    string claveEncriptada = dtRpta.Rows[0][4].ToString();
                    string apellidos = dtRpta.Rows[0][1].ToString();
                    string nombres = dtRpta.Rows[0][2].ToString();
                    // MessageBox.Show(claveEncriptada);

                    if (Crypter.CheckPassword(txtClaveAcceso.Text, claveEncriptada))
                    {
                        Aviso.Informar($"Bienvenido {apellidos}{nombres}");
                        frmMain frmMain = new frmMain();
                        frmMain.Show(); // Abre el formulario principal
                        this.Hide(); // Login se oculta
                    }
                    else
                    {
                        Aviso.Advertir("Error en la contraseña");
                    }

                }
                else
                {
                    Aviso.Advertir("El usuario no existe");
                }
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //txtClaveAcceso.Text = Crypter.Blowfish.Crypt("SENATI123");
            //return;
            Login();
        }



        private void txtClaveAcceso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Login();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola que hace");
        }
    }
}
