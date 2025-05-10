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
    public partial class FrmRectangulo : Form
    {

        private static FrmRectangulo instance = null;
        private CRectangulo rectangulo = CRectangulo.GetInstance();

        public FrmRectangulo()
        {
            InitializeComponent();
        }

        public static FrmRectangulo GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmRectangulo();
            }
            return instance;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (rectangulo.ReadData(txtBase, txtAltura))
            {
                txtPerimetro.Text = rectangulo.CalcularPerimetro().ToString("0.00");
                txtArea.Text = rectangulo.CalcularArea().ToString("0.00");
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos válidos para base y altura.", "Error");
            }
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            rectangulo.ResetForm(txtBase, txtAltura, txtArea, txtPerimetro);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            rectangulo.CloseForm(this);
        }
    }
}
