using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace AreasYPerimetros
{
    public partial class FrmElipse : Form
    {

        private static FrmElipse instance = null;
        private CElipse elipse = CElipse.GetInstance();

        public FrmElipse()
        {
            InitializeComponent();
        }

        public static FrmElipse GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmElipse();
            }
            return instance;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                float ejeMayor = float.Parse(txtEjeMayor.Text);
                float ejeMenor = float.Parse(txtEjeMenor.Text);
                elipse.SetEjes(ejeMayor, ejeMenor);

                txtArea.Text = elipse.CalcularArea().ToString("0.00");
                txtPerimetro.Text = elipse.CalcularPerimetro().ToString("0.00");
            }
            catch
            {
                MessageBox.Show("Ingrese valores numéricos válidos para los ejes.", "Error");
            }
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            elipse.ResetearFormulario(txtEjeMayor, txtEjeMenor, txtArea, txtPerimetro);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            elipse.CerrarFormulario(this);
        }
    }
}
