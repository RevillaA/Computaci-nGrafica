using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreasYPerimetros
{
    internal class CElipse
    {
        private static CElipse instancia = null;
        private float ejeMayor;
        private float ejeMenor;

        private CElipse()
        {
            ejeMayor = 0.0f;
            ejeMenor = 0.0f;
        }

        public static CElipse GetInstance()
        {
            if (instancia == null)
                instancia = new CElipse();
            return instancia;
        }

        public void SetEjes(float ejeMayor, float ejeMenor)
        {
            this.ejeMayor = ejeMayor;
            this.ejeMenor = ejeMenor;
        }

        public float CalcularArea()
        {
            return (float)Math.PI * ejeMayor * ejeMenor;
        }

        public float CalcularPerimetro()
        {
            return (float)(Math.PI * (3 * (ejeMayor + ejeMenor) - Math.Sqrt((3 * ejeMayor + ejeMenor) * (ejeMayor + 3 * ejeMenor))));
        }

        public void ResetearFormulario(TextBox txtEjeMayor, TextBox txtEjeMenor, TextBox txtArea, TextBox txtPerimetro)
        {
            txtEjeMayor.Text = "";
            txtEjeMenor.Text = "";
            txtArea.Text = "";
            txtPerimetro.Text = "";
        }

        public void CerrarFormulario(Form form)
        {
            form.Close();
        }
    }
}
