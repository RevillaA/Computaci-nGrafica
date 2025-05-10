using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreasYPerimetros
{
    internal class CCírculo
    {
        private static CCírculo instancia = null;
        private float radio;

        private CCírculo()
        {
            radio = 0.0f;
        }

        public static CCírculo GetInstance()
        {
            if (instancia == null)
                instancia = new CCírculo();
            return instancia;
        }

        public void SetRadio(float radio)
        {
            this.radio = radio;
        }

        public float CalcularPerimetro()
        {
            return 2 * (float)Math.PI * radio;
        }

        public float CalcularArea()
        {
            return (float)Math.PI * radio * radio;
        }

        public void ResetearFormulario(TextBox txtRadio, TextBox txtArea, TextBox txtPerimetro)
        {
            txtRadio.Text = "";
            txtArea.Text = "";
            txtPerimetro.Text = "";
        }

        public void CerrarFormulario(Form form)
        {
            form.Close();
        }
    }
}
