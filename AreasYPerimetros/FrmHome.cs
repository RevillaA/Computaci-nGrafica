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
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void MostrarFormulario(Form formulario)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            formulario.MdiParent = this;
            formulario.StartPosition = FormStartPosition.Manual;
            formulario.Show();
        }

        private void triánguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTriangulo frmTriangulo = FrmTriangulo.GetInstance();
            MostrarFormulario(frmTriangulo);
        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCuadrado frmCuadrado = FrmCuadrado.GetInstance();
            MostrarFormulario(frmCuadrado);
        }

        private void rectánguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRectangulo frmRectangulo = FrmRectangulo.GetInstance();
            MostrarFormulario(frmRectangulo);
        }

        private void romboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRombo frmRombo = FrmRombo.GetInstance();
            MostrarFormulario(frmRombo);
        }

        private void trapecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrapecio frmTrapecio = FrmTrapecio.GetInstance();
            MostrarFormulario(frmTrapecio);
        }

        private void trapezoideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrapezoide frmTrapezoide = FrmTrapezoide.GetInstance();
            MostrarFormulario(frmTrapezoide);
        }

        private void romboideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRomboide frmRomboide = FrmRomboide.GetInstance();
            MostrarFormulario(frmRomboide);
        }

        private void deltoideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeltoide frmDeltoide = FrmDeltoide.GetInstance();
            MostrarFormulario(frmDeltoide);
        }

        private void polígonosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPoligonos frmPoligonos = FrmPoligonos.GetInstance();
            MostrarFormulario(frmPoligonos);
        }

        private void círculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCírculo frmCírculo = FrmCírculo.GetInstance();
            MostrarFormulario(frmCírculo);
        }

        private void elipseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmElipse frmElipse = FrmElipse.GetInstance();
            MostrarFormulario(frmElipse);
        }

        private void ovaloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOvalo frmOvalo = FrmOvalo.GetInstance();
            MostrarFormulario(frmOvalo);
        }
    }
}
