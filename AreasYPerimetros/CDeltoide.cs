using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreasYPerimetros
{
    internal class CDeltoide
    {
        private static CDeltoide instancia = null;
        private float diagonalMayor;
        private float diagonalMenor;
        private float ladoPequeño;
        private float ladoGrande;

        private CDeltoide()
        {
            diagonalMayor = 0.0f;
            diagonalMenor = 0.0f;
            ladoPequeño = 0.0f;
            ladoGrande = 0.0f;
        }

        public static CDeltoide GetInstance()
        {
            if (instancia == null)
                instancia = new CDeltoide();
            return instancia;
        }

        public bool LeerDatos(TextBox txtD, TextBox txtd, TextBox txtA, TextBox txtB)
        {
            try
            {
                diagonalMayor = float.Parse(txtD.Text);
                diagonalMenor = float.Parse(txtd.Text);
                ladoPequeño = float.Parse(txtA.Text);
                ladoGrande = float.Parse(txtB.Text);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public float CalcularArea()
        {
            return (diagonalMayor * diagonalMenor) / 2;
        }

        public float CalcularPerimetro()
        {
            return 2 * (ladoPequeño + ladoGrande);
        }

        public void ResetearFormulario(TextBox txtD, TextBox txtd, TextBox txtA, TextBox txtB, TextBox txtArea, TextBox txtPerimetro)
        {
            txtD.Text = "";
            txtd.Text = "";
            txtA.Text = "";
            txtB.Text = "";
            txtArea.Text = "";
            txtPerimetro.Text = "";
        }

        public void CerrarFormulario(Form form)
        {
            form.Close();
        }
    }
}
