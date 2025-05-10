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
    public partial class FrmTrapezoide : Form
    {
        private static FrmTrapezoide instance = null;
        private CTrapezoide trapezoide = CTrapezoide.GetInstance();

        public FrmTrapezoide()
        {
            InitializeComponent();
        }

        public static FrmTrapezoide GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmTrapezoide();
            }
            return instance;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (trapezoide.ReadData(txtBaseMayor, txtBaseMenor, txtAltura, txtLado1, txtLado2))
            {
                txtArea.Text = trapezoide.CalcularArea().ToString("0.00");
                txtPerimetro.Text = trapezoide.CalcularPerimetro().ToString("0.00");
            }
            else
            {
                MessageBox.Show("Ingrese todos los valores numéricos correctamente.", "Error");
            }
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            trapezoide.ResetForm(txtBaseMayor, txtBaseMenor, txtAltura, txtLado1, txtLado2, txtArea, txtPerimetro);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            trapezoide.CloseForm(this);
        }
    }
}
