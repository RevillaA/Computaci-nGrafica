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
    public partial class FrmRomboide : Form
    {
        private static FrmRomboide instance = null;
        private CRomboide romboide = CRomboide.GetInstance();

        public FrmRomboide()
        {
            InitializeComponent();
        }

        public static FrmRomboide GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmRomboide();
            }
            return instance;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (romboide.ReadData(txtBase, txtAltura, txtLado))
            {
                txtArea.Text = romboide.CalcularArea().ToString("0.00");
                txtPerimetro.Text = romboide.CalcularPerimetro().ToString("0.00");
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos válidos.", "Error");
            }
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            romboide.ResetForm(txtBase, txtAltura, txtLado, txtArea, txtPerimetro);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            romboide.CloseForm(this);
        }

    }
}
