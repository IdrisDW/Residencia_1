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
    public partial class FrmMaterial : Form
    {
        int idd;
        private int? id;
        private string MaterialName = "";
        private int? MaterialQuantity;
        DateTime Materialdt = new DateTime().Date;
        private string MaterialExpDate = "";
        private decimal? MaterialUnits;
        private string MatSupplier = "";

        public FrmMaterial(int? id = null, string MaterialName = "", int? MaterialQuantity = null,
       DateTime Materialdt = new DateTime() ,
          decimal? MaterialUnits = null,
          string MatSupplier = "")
        {
            InitializeComponent();
            this.id = id;
            this.MaterialName = MaterialName;
            this.MaterialQuantity = MaterialQuantity;
            this.Materialdt= Materialdt;
            this.MaterialUnits = MaterialUnits;
            this.MatSupplier = MatSupplier;
        }


        private void Refresh()
        {
            DataSet1TableAdapters.MaterialTableAdapter ta =
                new DataSet1TableAdapters.MaterialTableAdapter();

            DataSet1.MaterialDataTable dt = ta.GetDataMaterial();

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[2].HeaderText = "Cantidad";
            dataGridView1.Columns[3].HeaderText = "Caducidad";
            dataGridView1.Columns[4].HeaderText = "Unidades";
            dataGridView1.Columns[5].HeaderText = "Proveedor";
        }


        private void RefreshSupplier()
        {
            DataSet1TableAdapters.SupplierTableAdapter ta =
                new DataSet1TableAdapters.SupplierTableAdapter();

            DataSet1.SupplierDataTable dt = ta.GetDataSupplier();

            dgvProveedor.DataSource = dt;
            dgvProveedor.Columns[0].HeaderText = "Id";
            dgvProveedor.Columns[1].HeaderText = "Nombre";
           
        }

        private void FrmMaterial_Load(object sender, EventArgs e)
        {
            Refresh();
            RefreshSupplier();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscarMat.Clear();
            Refresh();
        }

        private void btnLimpiarProv_Click(object sender, EventArgs e)
        {
           
            txtProveedor.Clear();
            RefreshSupplier();
            txtProveedor.Enabled = true;
            dgvProveedor.Enabled = true;
            btnElegir.Enabled = true;
        }

        private void txtProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                DataSet1TableAdapters.SupplierTableAdapter ta = new DataSet1TableAdapters.SupplierTableAdapter();
                DataSet1.SupplierDataTable dt = ta.GetDataByFilteringSupplier(txtProveedor.Text);


                ta.FillByFilteringSupplier(dt,txtProveedor.Text);


                dgvProveedor.DataSource = dt;

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /*WE'LL GET THE MATERIAL ID*/
        private int? GetId()
        {
            try
            {
                idd = int.Parse(
                        dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()
                        );
                return int.Parse(
                    dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()
                    );

            }
            catch
            {

                return null;
            }


        }

        /*WE'LL GET THE SUPPLIER ID*/
        private int? GetIdSupplier()
        {
            try
            {
                idd = int.Parse(
                        dgvProveedor.Rows[dgvProveedor.CurrentRow.Index].Cells[0].Value.ToString()
                        );
                return int.Parse(
                    dgvProveedor.Rows[dgvProveedor.CurrentRow.Index].Cells[0].Value.ToString()
                    );

            }
            catch
            {

                return null;
            }


        }
        //
        private void button1_Click(object sender, EventArgs e)
        {

            int? idS = GetIdSupplier();
            MessageBox.Show(idS.ToString());
            if (idS != null)
            {
                DataSet1TableAdapters.SupplierTableAdapter ta = new DataSet1TableAdapters.SupplierTableAdapter();
                DataSet1.SupplierDataTable pt = ta.GetDataByIdSupplier((int)idS);

                
                DataSet1.SupplierRow row = (DataSet1.SupplierRow)pt.Rows[0];
                txtProveedor.Text = row.SupplierName;
                dgvProveedor.Enabled = false;
                txtProveedor.Enabled = false;
                btnElegir.Enabled
                    = false;
                
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            MessageBox.Show(idd.ToString());
            DataSet1TableAdapters.MaterialTableAdapter ta = new DataSet1TableAdapters.MaterialTableAdapter();
            MessageBox.Show(idd.ToString());
            if (string.IsNullOrWhiteSpace(txtNombre.Text))


            {

                MessageBox.Show("Verifique que todos los campos hayan sido llenados correctamente");
            }


            else
            if (idd == 0)
            {
                // ta.InsertQueryMaterial(txtNombre.Text.Trim());
                ta.InsertQueryMaterial(txtNombre.Text.Trim());
                txtNombre.Clear();
                udCantidad.Value.Equals("0");
                udUnidades.Value.Equals("0.00");
                clnFechaExp.SetDate(DateTime.Now);


                txtProveedor.Clear();
                txtProveedor.Enabled = true;
                dgvProveedor.Enabled = true;
                btnElegir.Enabled = true;
                btnLimpiar.Enabled = true;
                idd = 0;
                Refresh();

            }
            else
            {
              //  ta.UpdateQuerySupplier(txtNombre.Text.Trim(), (int)idd);
                txtNombre.Clear();

                idd = 0;

                Refresh();
            }
            /*
             
            
            
             */
        }
    }
}
