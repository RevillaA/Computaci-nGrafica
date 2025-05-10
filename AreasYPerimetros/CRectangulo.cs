using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreasYPerimetros
{
    internal class CRectangulo
    {
        private static CRectangulo instancia = null;
        private float baseRect;
        private float altura;

        private CRectangulo()
        {
            baseRect = 0.0f;
            altura = 0.0f;
        }

        public static CRectangulo GetInstance()
        {
            if (instancia == null)
                instancia = new CRectangulo();
            return instancia;
        }

        public bool ReadData(TextBox txtBase, TextBox txtAltura)
        {
            try
            {
                baseRect = float.Parse(txtBase.Text);
                altura = float.Parse(txtAltura.Text);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public float CalcularPerimetro()
        {
            return 2 * (baseRect + altura);
        }

        public float CalcularArea()
        {
            return baseRect * altura;
        }

        public void ResetForm(TextBox txtBase, TextBox txtAltura, TextBox txtArea, TextBox txtPerimetro)
        {
            txtBase.Text = "";
            txtAltura.Text = "";
            txtArea.Text = "";
            txtPerimetro.Text = "";
        }

        public void CloseForm(Form form)
        {
            form.Close();
        }

    }
}
