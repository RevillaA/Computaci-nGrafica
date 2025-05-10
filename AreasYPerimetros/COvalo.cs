using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreasYPerimetros
{
    internal class COvalo
    {
        private static COvalo instancia = null;
        private float ejeMayor;
        private float ejeMenor;

        private COvalo()
        {
            ejeMayor = 0.0f;
            ejeMenor = 0.0f;
        }

        public static COvalo GetInstance()
        {
            if (instancia == null)
                instancia = new COvalo();
            return instancia;
        }

        public bool ReadData(TextBox txtEjeMayor, TextBox txtEjeMenor)
        {
            try
            {
                ejeMayor = float.Parse(txtEjeMayor.Text);
                ejeMenor = float.Parse(txtEjeMenor.Text);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public float CalcularArea()
        {
            return (float)(Math.PI * ejeMayor * ejeMenor);
        }

        public float CalcularPerimetro()
        {
            return (float)(Math.PI * (3 * (ejeMayor + ejeMenor) - Math.Sqrt((3 * ejeMayor + ejeMenor) * (ejeMayor + 3 * ejeMenor))));
        }

        public void ResetForm(TextBox txtEjeMayor, TextBox txtEjeMenor, TextBox txtArea, TextBox txtPerimetro)
        {
            txtEjeMayor.Text = "";
            txtEjeMenor.Text = "";
            txtArea.Text = "";
            txtPerimetro.Text = "";
        }

        public void CloseForm(Form form)
        {
            form.Close();
        }
    }
}
