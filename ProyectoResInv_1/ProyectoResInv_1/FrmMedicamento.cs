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
    public partial class FrmMedicamento : Form
    {

        int idd; int iddSupplier;
        private int? id;
        private string MedicineName = "";
        private int? MedicineQuantity;
        private decimal? MedicineDosQuan;
        DateTime Medicinedt = new DateTime().Date;
        // private string MaterialExpDate = "";
        private decimal? MedicineUnits;
        private decimal? MedicineDosUnits;
        private string MedicineUnitsType = "";
        private string MedicineQuantityPres = "";
       


        public FrmMedicamento(int? id = null, string MedicineName = "",
             DateTime Medicinedt = new DateTime(),
             int? MedicineQuantity = null,
             string MedicineQuantityPres = "",
             decimal? MedicineUnits = null,
             string MedicineUnitsType = "",
             decimal? MedicineDosQuan = null,
             decimal? MedicineDosUnits = null
          
             )
        {
            InitializeComponent();
            this.id = id;
            this.MedicineName = MedicineName;
            this.Medicinedt = Medicinedt;
            this.MedicineQuantity = MedicineQuantity;
            this.MedicineQuantityPres = MedicineQuantityPres;
            this.MedicineUnits = MedicineUnits;
            this.MedicineDosQuan = MedicineDosQuan;
            this.MedicineDosUnits = MedicineDosUnits;
        }

        /*WE'LL GET THE MEDICINE ID*/
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
                iddSupplier = int.Parse(
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

        private void Refresh()
        {
            DataSet1TableAdapters.MedicineTableAdapter ta =
                new DataSet1TableAdapters.MedicineTableAdapter();

            DataSet1.MedicineDataTable dt = ta.GetDataMedicine();

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[2].HeaderText = "Caducidad";
            dataGridView1.Columns[3].HeaderText = "Cantidad";
            dataGridView1.Columns[4].HeaderText = "Presentacion";

            dataGridView1.Columns[5].HeaderText = "Unidades";
            dataGridView1.Columns[6].HeaderText = "Cantidad Dosis";
            dataGridView1.Columns[7].HeaderText = "Unidades Dosis";

            dataGridView1.Columns[8].HeaderText = "Proveedor";
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

        private void txtProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (checkBox2.Checked)
            {
                //
                try
                {
                    DataSet1TableAdapters.SupplierTableAdapter ta = new DataSet1TableAdapters.SupplierTableAdapter();
                    DataSet1.SupplierDataTable dt = ta.GetDataByBuscarIDProveedor(txtProveedor.Text);
                    //ta.GetDataByIdSupplier(txtBusquedaProv.Text);


                    ta.FillByBuscarIDProveedor(dt, txtProveedor.Text);


                    dgvProveedor.DataSource = dt;

                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //
            }
            else
            {
                try
                {
                    DataSet1TableAdapters.SupplierTableAdapter ta = new DataSet1TableAdapters.SupplierTableAdapter();
                    DataSet1.SupplierDataTable dt = ta.GetDataByFilteringSupplier(txtProveedor.Text);


                    ta.FillByFilteringSupplier(dt, txtProveedor.Text);


                    dgvProveedor.DataSource = dt;

                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnLimpiarProv_Click(object sender, EventArgs e)
        {
            txtProveedor.Clear();
            RefreshSupplier();
            txtProveedor.Enabled = true;
            dgvProveedor.Enabled = true;
            btnElegir.Enabled = true;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscarMed.Clear();
            Refresh();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            int? id = GetId();
            int valorcillo;
       //     MessageBox.Show(id.ToString());
            if (id != null)
            {
                DataSet1TableAdapters.MedicineTableAdapter ta = new DataSet1TableAdapters.MedicineTableAdapter();
                DataSet1.MedicineDataTable pt = ta.GetDataByIdMedicine((int)id);

                DataSet1.MedicineRow row = (DataSet1.MedicineRow)pt.Rows[0];

                txtNombre.Text = row.MedicineName;


                udCantidad.Value = row.MedicineQuantity;
                txtPres.Text = row.MedicineQuantityPres;
                udUnidades.Value = row.MedicineUnits;
                //  txtTipoUnidad.Text = row.MaterialUnitType;
                clnFechaExp.SetDate(row.MedicineExpDate);
                txtTipoUnidad.Text = row.MedicineUnitsType;
                udUnidadesDosis.Value = row.MedicineDosUnits;
                udCantidadDosis.Value = row.MedicineDosQuan;

                valorcillo = row.idSupplier;
                // MessageBox.Show(valorcillo.ToString());
                //from here
                DataSet1TableAdapters.SupplierTableAdapter tas = new DataSet1TableAdapters.SupplierTableAdapter();
                DataSet1.SupplierDataTable pts = tas.GetDataByIdSupplier((int)valorcillo);
                //  DataSet1.SupplierRow rowsup = (DataSet1.SupplierRow)pts.Rows[0];
                //  txtProveedor.Text = rowsup.ToString();

                dgvProveedor.DataSource = pts;
            }
            else {
                MessageBox.Show("No hay registros");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string message = "Esta seguro que desea eliminar este registro?";
            string title = "Advertencia";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            
            //
            int? id = GetId();
            if (id == null)
            {
                MessageBox.Show("No hay registros");
            }
            else
            {
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    if (id != null)
                    {
                        DataSet1TableAdapters.MedicineTableAdapter ta = new DataSet1TableAdapters.MedicineTableAdapter();
                        try
                        {
                            ta.DeleteQueryMedicine((int)id);
                            Refresh();
                        }
                        catch (Exception mensaje)
                        {
                            MessageBox.Show(mensaje.ToString());
                        }
                    }
                }
                else
                {

                    // Do something  
                }
            }
        }

        private void btnElegir_Click(object sender, EventArgs e)
        {
            int? idS = GetIdSupplier();
          //  MessageBox.Show(idS.ToString());
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
            else {
                MessageBox.Show("No hay registros");
            }
        }

        private void FrmMedicamento_Load(object sender, EventArgs e)
        {
            Refresh();
            RefreshSupplier();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int valorIdSupplier = int.Parse(dgvProveedor.Rows[dgvProveedor.CurrentRow.Index].Cells[0].Value.ToString());
            // MessageBox.Show(idd.ToString());
            DataSet1TableAdapters.MedicineTableAdapter ta = new DataSet1TableAdapters.MedicineTableAdapter();
            //   MessageBox.Show(idd.ToString());
            if (string.IsNullOrWhiteSpace(txtNombre.Text))


            {

                MessageBox.Show("Verifique que todos los campos hayan sido llenados correctamente");
            }


            else
            if (idd == 0)
            {
                // ta.InsertQueryMaterial(txtNombre.Text.Trim());

                ta.InsertQueryMedicine
                    (txtNombre.Text.Trim(), 
                    clnFechaExp.SelectionRange.Start.ToShortDateString()
                    ,(int)udCantidad.Value, txtPres.Text.Trim(),
                   (decimal)udUnidades.Value, txtTipoUnidad.Text.Trim(),
                   (decimal)udCantidadDosis.Value,(decimal)udUnidadesDosis.Value,
                     (int)valorIdSupplier);
                txtNombre.Clear();
                udCantidad.Value = 0;
                udUnidades.Value = 0;
                clnFechaExp.SetDate(DateTime.Now);
                udCantidadDosis.Value = 0;
                udUnidadesDosis.Value = 0;
                txtTipoUnidad.Clear();
                txtProveedor.Clear();
                txtProveedor.Enabled = true;
                dgvProveedor.Enabled = true;
                btnElegir.Enabled = true;
                btnLimpiar.Enabled = true;
                udCantidad.Value = 0;
                idd = 0;
                Refresh();
                valorIdSupplier = 0;
                txtPres.Clear();
            }
            else
            {
                //  int valorIdSupplier = int.Parse(dgvProveedor.Rows[dgvProveedor.CurrentRow.Index].Cells[0].Value.ToString());


              

                    //
                ta.UpdateQueryMedicine
                    (txtNombre.Text.Trim(),
                    clnFechaExp.SelectionRange.Start.ToShortDateString()
                    , (int)udCantidad.Value, txtPres.Text.Trim(),
                   (decimal)udUnidades.Value, txtTipoUnidad.Text.Trim(),
                   (decimal)udCantidadDosis.Value, (decimal)udUnidadesDosis.Value,
                     (int)valorIdSupplier, (int)idd);

                txtNombre.Clear();
                udCantidad.Value = 0;
                udUnidades.Value = 0;
                clnFechaExp.SetDate(DateTime.Now);
                valorIdSupplier = 0;
                udUnidadesDosis.Value = 0;
                udCantidadDosis.Value = 0;
                udCantidad.Value = 0;
                txtPres.Clear();
                txtTipoUnidad.Clear();
                txtProveedor.Clear();
                txtProveedor.Enabled = true;
                dgvProveedor.Enabled = true;
                btnElegir.Enabled = true;
                btnLimpiar.Enabled = true;
                idd = 0;
                Refresh();
            }
        }
    }
}
