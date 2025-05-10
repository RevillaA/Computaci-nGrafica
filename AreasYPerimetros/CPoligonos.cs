using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreasYPerimetros
{
    internal class CPoligonos
    {
        private static CPoligonos instancia = null;
        private int numeroLados;
        private float lado;

        private CPoligonos()
        {
            numeroLados = 0;
            lado = 0.0f;
        }

        public static CPoligonos GetInstance()
        {
            if (instancia == null)
                instancia = new CPoligonos();
            return instancia;
        }

        public bool LeerDatos(ComboBox cmbLados, TextBox txtLado)
        {
            try
            {
                lado = float.Parse(txtLado.Text);

                switch (cmbLados.SelectedItem.ToString())
                {
                    case "Péntagono":
                        numeroLados = 5; break;
                    case "Hexágono":
                        numeroLados = 6; break;
                    case "Heptágono":
                        numeroLados = 7; break;
                    case "Octágono":
                        numeroLados = 8; break;
                    case "Eneágono":
                        numeroLados = 9; break;
                    case "Decágono":
                        numeroLados = 10; break;
                    default:
                        return false;
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public float CalcularPerimetro()
        {
            return numeroLados * lado;
        }

        public double CalcularArea()
        {
            if (numeroLados < 3)
            {
                MessageBox.Show("Se necesitan al menos 3 lados para formar un polígono.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0.0;
            }

            double anguloCentral = 2 * Math.PI / numeroLados;
            double radio = lado / (2 * Math.Sin(anguloCentral / 2));

            double a = radio;
            double b = radio;
            double c = lado;

            double s = (a + b + c) / 2;
            double areaTriangulo = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            return numeroLados * areaTriangulo;
        }

        public void ResetearFormulario(ComboBox cmb, TextBox txtLado, TextBox txtArea, TextBox txtPerimetro)
        {
            cmb.SelectedIndex = -1;
            txtLado.Text = "";
            txtArea.Text = "";
            txtPerimetro.Text = "";
        }

        public void CerrarFormulario(Form form)
        {
            form.Close();
        }
    }
}
