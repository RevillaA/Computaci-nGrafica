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
    public partial class FrmOvalo : Form
    {
        private static FrmOvalo instance = null;
        private COvalo ovalo = COvalo.GetInstance();

        public FrmOvalo()
        {
            InitializeComponent();
        }

        public static FrmOvalo GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmOvalo();
            }
            return instance;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (ovalo.ReadData(txtEjeMayor, txtEjeMenor))
            {
                txtArea.Text = ovalo.CalcularArea().ToString("0.00");
                txtPerimetro.Text = ovalo.CalcularPerimetro().ToString("0.00");
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos válidos para eje mayor y eje menor.", "Error");
            }
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            ovalo.ResetForm(txtEjeMayor, txtEjeMenor, txtArea, txtPerimetro);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ovalo.CloseForm(this);
        }
    }
}
