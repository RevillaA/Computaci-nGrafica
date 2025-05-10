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
    public partial class FrmPoligonos : Form
    {
        private static FrmPoligonos instance = null;
        private CPoligonos poligono = CPoligonos.GetInstance();

        public FrmPoligonos()
        {
            InitializeComponent();
        }

        public static FrmPoligonos GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmPoligonos();
            }
            return instance;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (poligono.LeerDatos(cmbNlados, txtLado))
            {
                txtPerimetro.Text = poligono.CalcularPerimetro().ToString("0.00");
                txtArea.Text = poligono.CalcularArea().ToString("0.00");
            }
            else
            {
                MessageBox.Show("Seleccione un polígono válido y asegúrese de ingresar un valor numérico para el lado.", "Error");
            }
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            poligono.ResetearFormulario(cmbNlados, txtLado, txtArea, txtPerimetro);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            poligono.CerrarFormulario(this);
        }

    }
}
