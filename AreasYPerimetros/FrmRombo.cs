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
    public partial class FrmRombo : Form
    {
        private static FrmRombo instance = null;
        private CRombo rombo = CRombo.GetInstance();

        public FrmRombo()
        {
            InitializeComponent();
        }

        public static FrmRombo GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmRombo();
            }
            return instance;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (rombo.ReadData(txtDiagonalMayor, txtDiagonalMenor, txtLado))
            {
                txtPerimetro.Text = rombo.CalcularPerimetro().ToString("0.00");
                txtArea.Text = rombo.CalcularArea().ToString("0.00");
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos válidos para las diagonales y el lado.", "Error");
                txtPerimetro.Text = "";
                txtArea.Text = "";
            }
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            rombo.ResetForm(txtDiagonalMayor, txtDiagonalMenor, txtLado, txtArea, txtPerimetro);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            rombo.CloseForm(this);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            FrmRectangulo siguiente = new FrmRectangulo();
            siguiente.Show();
            this.Hide();
        }
    }
}
