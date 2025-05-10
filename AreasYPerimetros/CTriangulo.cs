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
        private float lado;

        public CTriangulo()
        {
            lado = 0.0f;
        }

        public CTriangulo(float lado)
        {
            this.lado = lado;
        }

        public static CTriangulo GetInstance()
        {
            if (instancia == null)
                instancia = new CTriangulo();
            return instancia;
        }

        public bool ReadData(TextBox txtLado)
        {
            try
            {
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
            return 3 * lado;
        }

        public float CalcularArea()
        {
            return (float)((Math.Sqrt(3) / 4) * lado * lado);
        }

        public void ResetForm(TextBox txtLado, TextBox txtArea, TextBox txtPerimetro)
        {
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
