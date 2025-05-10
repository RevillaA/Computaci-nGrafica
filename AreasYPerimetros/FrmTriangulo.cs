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
    public partial class FrmTriangulo : Form
    {
        private static FrmTriangulo instance;
        private CTriangulo triangulo;

        public FrmTriangulo()
        {
            InitializeComponent();
            triangulo = CTriangulo.GetInstance();
        }

        public static FrmTriangulo GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmTriangulo();
            }
            return instance;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (triangulo.ReadData(txtLado))
            {
                float perimetro = triangulo.CalcularPerimetro();
                float area = triangulo.CalcularArea();
                txtPerimetro.Text = perimetro.ToString("0.00");
                txtArea.Text = area.ToString("0.00");
            }
            else
            {
                txtPerimetro.Text = "";
                txtArea.Text = "";
                MessageBox.Show("Ingrese un valor numérico válido para el lado.", "Error");
            }
        }        

        private void btnResetear_Click(object sender, EventArgs e)
        {
            triangulo.ResetForm(txtLado, txtArea, txtPerimetro);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            FrmTrapezoide siguiente = new FrmTrapezoide(); 
            siguiente.Show();                        
            this.Hide();
        }
    }
}
