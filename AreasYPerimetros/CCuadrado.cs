using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreasYPerimetros
{
    internal class CCuadrado
    {
        private static CCuadrado instancia = null;
        private float lado;

        public CCuadrado()
        {
            lado = 0.0f;
        }

        public CCuadrado(float lado)
        {
            this.lado = lado;
        }

        public static CCuadrado GetInstance()
        {
            if (instancia == null)
                instancia = new CCuadrado();
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
            return 4 * lado;  
        }

        public float CalcularArea()
        {
            return lado * lado;  
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
