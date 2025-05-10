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
    public partial class FrmCuadrado : Form
    {
        private static FrmCuadrado instance = null;
        private CCuadrado cuadrado = CCuadrado.GetInstance();

        public FrmCuadrado()
        {
            InitializeComponent();
        }
        public static FrmCuadrado GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmCuadrado();
            }
            return instance;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cuadrado.ReadData(txtLado))
            {
                txtPerimetro.Text = cuadrado.CalcularPerimetro().ToString("0.00");
                txtArea.Text = cuadrado.CalcularArea().ToString("0.00");
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido para el lado.", "Error");
            }
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            cuadrado.ResetForm(txtLado, txtArea, txtPerimetro);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            cuadrado.CloseForm(this);
        }

    }
}
