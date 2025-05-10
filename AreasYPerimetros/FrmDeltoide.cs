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
    public partial class FrmDeltoide : Form
    {
        private static FrmDeltoide instance = null;
        private CDeltoide deltoide = CDeltoide.GetInstance();

        public FrmDeltoide()
        {
            InitializeComponent();
        }

        public static FrmDeltoide GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmDeltoide();
            }
            return instance;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (deltoide.LeerDatos(txtDiagonalMayor, txtDiagonalMenor, txtLadoPequeño, txtLadoGrande))
            {
                txtArea.Text = deltoide.CalcularArea().ToString("0.00");
                txtPerimetro.Text = deltoide.CalcularPerimetro().ToString("0.00");
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos válidos.", "Error");
            }
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            deltoide.ResetearFormulario(txtDiagonalMayor, txtDiagonalMenor, txtLadoPequeño, txtLadoGrande, txtArea, txtPerimetro);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            deltoide.CerrarFormulario(this);
        }
    }
}
