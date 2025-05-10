using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreasYPerimetros
{
    public partial class FrmCírculo : Form
    {
        private static FrmCírculo instance = null;
        private CCírculo circulo = CCírculo.GetInstance();

        public FrmCírculo()
        {
            InitializeComponent();
        }

        public static FrmCírculo GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmCírculo();
            }
            return instance;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                float radio = float.Parse(txtRadio.Text);
                circulo.SetRadio(radio);

                txtPerimetro.Text = circulo.CalcularPerimetro().ToString("0.00");
                txtArea.Text = circulo.CalcularArea().ToString("0.00");
            }
            catch
            {
                MessageBox.Show("Ingrese un valor numérico válido para el radio.", "Error");
            }
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            circulo.ResetearFormulario(txtRadio, txtArea, txtPerimetro);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            circulo.CerrarFormulario(this);
        }
    }
}
