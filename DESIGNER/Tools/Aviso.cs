using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DESIGNER.Tools
{
    public static class Aviso
    {
        public static void Informar(String mensaje)
        {
            MessageBox.Show(mensaje,"App TiendaNET",MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }
        public static void Advertir(String mensaje)
        {
            MessageBox.Show(mensaje, "App TiendaNET", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

        }
        public static DialogResult Preguntar(String mensaje)
        {
           return MessageBox.Show(mensaje, "App TiendaNET", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

        }
    }

}
