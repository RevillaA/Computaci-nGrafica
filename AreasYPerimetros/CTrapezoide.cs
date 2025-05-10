using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreasYPerimetros
{
    internal class CTrapezoide
    {
        private static CTrapezoide instancia = null;
        private float baseMayor;
        private float baseMenor;
        private float altura;
        private float lado1;
        private float lado2;

        private CTrapezoide()
        {
            baseMayor = 0.0f;
            baseMenor = 0.0f;
            altura = 0.0f;
            lado1 = 0.0f;
            lado2 = 0.0f;
        }

        public static CTrapezoide GetInstance()
        {
            if (instancia == null)
                instancia = new CTrapezoide();
            return instancia;
        }

        public bool ReadData(TextBox txtBaseMayor, TextBox txtBaseMenor, TextBox txtAltura, TextBox txtLado1, TextBox txtLado2)
        {
            try
            {
                baseMayor = float.Parse(txtBaseMayor.Text);
                baseMenor = float.Parse(txtBaseMenor.Text);
                altura = float.Parse(txtAltura.Text);
                lado1 = float.Parse(txtLado1.Text);
                lado2 = float.Parse(txtLado2.Text);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public float CalcularPerimetro()
        {
            return baseMayor + baseMenor + lado1 + lado2;
        }

        public float CalcularArea()
        {
            return ((baseMayor + baseMenor) * altura) / 2;
        }

        public void ResetForm(TextBox txtBaseMayor, TextBox txtBaseMenor, TextBox txtAltura, TextBox txtLado1, TextBox txtLado2, TextBox txtArea, TextBox txtPerimetro)
        {
            txtBaseMayor.Text = "";
            txtBaseMenor.Text = "";
            txtAltura.Text = "";
            txtLado1.Text = "";
            txtLado2.Text = "";
            txtArea.Text = "";
            txtPerimetro.Text = "";
        }

        public void CloseForm(Form form)
        {
            form.Close();
        }
    }
}
