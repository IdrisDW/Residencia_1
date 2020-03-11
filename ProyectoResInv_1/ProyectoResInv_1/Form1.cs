using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoResInv_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDoctor frmdoctor = new FrmDoctor();
            frmdoctor.ShowDialog();
           // Refresh();

        }

        private void btnDoctores_Click(object sender, EventArgs e)
        {
            FrmDoctor frmdoctor = new FrmDoctor();
            frmdoctor.ShowDialog();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            FrmPaciente frmpaciente = new FrmPaciente();
            frmpaciente.ShowDialog();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            FrmProveedor frmProveedor = new FrmProveedor();
            frmProveedor.ShowDialog();
        }

        private void btnMateriales_Click(object sender, EventArgs e)
        {
            FrmMaterial frmMaterial = new FrmMaterial();
            frmMaterial.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormProductos formProductos = new FormProductos();
            formProductos.ShowDialog();
        }
    }
}
