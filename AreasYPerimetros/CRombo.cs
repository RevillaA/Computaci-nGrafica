using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreasYPerimetros
{
    internal class CRombo
    {
        private static CRombo instancia = null;
        private float diagonalMayor;
        private float diagonalMenor;
        private float lado;

        private CRombo()
        {
            diagonalMayor = 0.0f;
            diagonalMenor = 0.0f;
            lado = 0.0f;
        }

        public static CRombo GetInstance()
        {
            if (instancia == null)
                instancia = new CRombo();
            return instancia;
        }

        public bool ReadData(TextBox txtDiagonalMayor, TextBox txtDiagonalMenor, TextBox txtLado)
        {
            try
            {
                diagonalMayor = float.Parse(txtDiagonalMayor.Text);
                diagonalMenor = float.Parse(txtDiagonalMenor.Text);
                lado = float.Parse(txtLado.Text);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public float CalcularPerimetro()
        {
            return 4 * lado;
        }

        public float CalcularArea()
        {
            return (diagonalMayor * diagonalMenor) / 2;
        }

        public void ResetForm(TextBox txtDMayor, TextBox txtDMenor, TextBox txtLado, TextBox txtArea, TextBox txtPerimetro)
        {
            txtDMayor.Text = "";
            txtDMenor.Text = "";
            txtLado.Text = "";
            txtArea.Text = "";
            txtPerimetro.Text = "";
        }

        public void CloseForm(Form form)
        {
            form.Close();
        }
    }
}
