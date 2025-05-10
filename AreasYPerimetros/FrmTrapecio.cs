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
    public partial class FrmTrapecio : Form
    {
        private static FrmTrapecio instance = null;
        private CTrapecio trapecio = CTrapecio.GetInstance();

        public FrmTrapecio()
        {
            InitializeComponent();
        }

        public static FrmTrapecio GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmTrapecio();
            }
            return instance;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (trapecio.ReadData(txtBaseMayor, txtBaseMenor, txtAltura, txtLado))
            {
                txtPerimetro.Text = trapecio.CalcularPerimetro().ToString("0.00");
                txtArea.Text = trapecio.CalcularArea().ToString("0.00");
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos válidos para base mayor, base menor, altura y lado.", "Error");
            }
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            trapecio.ResetForm(txtBaseMayor, txtBaseMenor, txtAltura, txtLado, txtArea, txtPerimetro);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            trapecio.CloseForm(this);
        }
    }
}
