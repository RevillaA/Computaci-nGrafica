using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreasYPerimetros
{
    internal class CRomboide
    {
        private static CRomboide instancia = null;
        private float baseR;
        private float altura;
        private float lado;

        private CRomboide()
        {
            baseR = 0.0f;
            altura = 0.0f;
            lado = 0.0f;
        }

        public static CRomboide GetInstance()
        {
            if (instancia == null)
                instancia = new CRomboide();
            return instancia;
        }

        public bool ReadData(TextBox txtBase, TextBox txtAltura, TextBox txtLado)
        {
            try
            {
                baseR = float.Parse(txtBase.Text);
                altura = float.Parse(txtAltura.Text);
                lado = float.Parse(txtLado.Text);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public float CalcularArea()
        {
            return baseR * altura;
        }

        public float CalcularPerimetro()
        {
            return 2 * (baseR + lado);
        }

        public void ResetForm(TextBox txtBase, TextBox txtAltura, TextBox txtLado, TextBox txtArea, TextBox txtPerimetro)
        {
            txtBase.Text = "";
            txtAltura.Text = "";
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
