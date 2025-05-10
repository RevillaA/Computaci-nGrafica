using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace AreasYPerimetros
{
    internal class CTriangulo
    {
        private static CTriangulo instancia = null;
        private float lado0, lado1, lado2;

        public CTriangulo()
        {
            lado0 = lado1 = lado2 = 0.0f;
        }

        public static CTriangulo GetInstance()
        {
            if (instancia == null)
                instancia = new CTriangulo();
            return instancia;
        }

        public bool ReadData(TextBox txtLado0, TextBox txtLado1, TextBox txtLado2)
        {
            try
            {
                lado0 = float.Parse(txtLado0.Text);
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
            return lado0 + lado1 + lado2;
        }

        public float CalcularArea()
        {
            float s = CalcularPerimetro() / 2;
            return (float)Math.Sqrt(s * (s - lado0) * (s - lado1) * (s - lado2));
        }

        public void ResetForm(TextBox txtLado0, TextBox txtLado1, TextBox txtLado2, TextBox txtArea, TextBox txtPerimetro)
        {
            txtLado0.Text = "";
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
