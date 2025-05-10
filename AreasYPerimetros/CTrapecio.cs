using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreasYPerimetros
{
    internal class CTrapecio
    {
        private static CTrapecio instancia = null;
        private float baseMayor;
        private float baseMenor;
        private float altura;
        private float lado;

        private CTrapecio()
        {
            baseMayor = 0.0f;
            baseMenor = 0.0f;
            altura = 0.0f;
            lado = 0.0f;
        }

        public static CTrapecio GetInstance()
        {
            if (instancia == null)
                instancia = new CTrapecio();
            return instancia;
        }

        public bool ReadData(TextBox txtBaseMayor, TextBox txtBaseMenor, TextBox txtAltura, TextBox txtLado)
        {
            try
            {
                baseMayor = float.Parse(txtBaseMayor.Text);
                baseMenor = float.Parse(txtBaseMenor.Text);
                altura = float.Parse(txtAltura.Text);
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
            return baseMayor + baseMenor + 2 * lado;
        }

        public float CalcularArea()
        {
            return ((baseMayor + baseMenor) * altura) / 2;
        }

        public void ResetForm(TextBox txtBaseMayor, TextBox txtBaseMenor, TextBox txtAltura, TextBox txtLado, TextBox txtArea, TextBox txtPerimetro)
        {
            txtBaseMayor.Text = "";
            txtBaseMenor.Text = "";
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
