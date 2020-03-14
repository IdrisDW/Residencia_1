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
    public partial class FormProductos : Form
    {

        int idd; int iddSupplier;
        private int? id;
        private string ProductName = "";
        private int? ProductQuantity;
        DateTime Productdt = new DateTime().Date;
        private decimal? ProductUnits;
        private string ProductUnitType;
        private string ProdSupplier = "";

        public FormProductos(int? id = null, string ProductName = "", 
              int? ProductQuantity = null,
              DateTime Productdt = new DateTime(),
              decimal? ProductUnits = null,
                
              string ProdSupplier = "",
               string ProductUnitType = ""
             )
        {
            InitializeComponent();
            this.id = id;
            this.ProductName = ProductName;
            this.ProductQuantity = ProductQuantity;
            this.Productdt = Productdt;
            this.ProductUnits = ProductUnits;
            this.ProdSupplier = ProdSupplier;
            this.ProductUnitType= ProductUnitType;
           
        }

        private void Refresh()
        {
            DataSet1TableAdapters.ProductTableAdapter ta =
                new DataSet1TableAdapters.ProductTableAdapter();

            DataSet1.ProductDataTable dt = ta.GetDataProduct();

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[2].HeaderText = "Cantidad";
            dataGridView1.Columns[3].HeaderText = "Presentacion";
            dataGridView1.Columns[4].HeaderText = "Caducidad";
            dataGridView1.Columns[5].HeaderText = "Unidades";
            dataGridView1.Columns[6].HeaderText = "Tipo Unidad";
            dataGridView1.Columns[7].HeaderText = "Proveedor";
             
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

        private void RefreshSupplier()
        {
            DataSet1TableAdapters.SupplierTableAdapter ta =
                new DataSet1TableAdapters.SupplierTableAdapter();

            DataSet1.SupplierDataTable dt = ta.GetDataSupplier();

            dgvProveedor.DataSource = dt;
            dgvProveedor.Columns[0].HeaderText = "Id";
            dgvProveedor.Columns[1].HeaderText = "Nombre";

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            Refresh();
            RefreshSupplier();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscarProd.Clear();
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

        private void btnElegir_Click(object sender, EventArgs e)
        {
            int? idS = GetIdSupplier();
            // MessageBox.Show(idS.ToString());
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
            else
            {
                MessageBox.Show("No hay registros");
            
        
        }
    }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            int? id = GetId();
            int valorcillo;
         //   MessageBox.Show(id.ToString());
            if (id != null)
            {
                DataSet1TableAdapters.ProductTableAdapter ta = new DataSet1TableAdapters.ProductTableAdapter();
                DataSet1.ProductDataTable pt = ta.GetDataByIdProduct((int)id);

                DataSet1.ProductRow row = (DataSet1.ProductRow)pt.Rows[0];
                txtNombre.Text = row.ProductName;
                udCantidad.Value = row.ProductQuantity;
               udUnidades.Value = row.ProductUnits;
               txtTipoUnidad.Text = row.ProductUnitType;
                clnFechaExp.SetDate(row.ProductExpDate);


                valorcillo =  row.idSupplier;
                // MessageBox.Show(valorcillo.ToString());
                //from here
                DataSet1TableAdapters.SupplierTableAdapter tas = new DataSet1TableAdapters.SupplierTableAdapter();
                DataSet1.SupplierDataTable pts = tas.GetDataByIdSupplier((int)valorcillo);
              //  DataSet1.SupplierRow rowsup = (DataSet1.SupplierRow)pts.Rows[0];
                //  txtProveedor.Text = rowsup.ToString();

                dgvProveedor.DataSource = pts;
                //   dgvProveedor.Rows[dgvProveedor.CurrentRow.Index].Cells[0].Value.Equals(valorcillo);




                //DataSet1TableAdapters.SupplierTableAdapter tas = new DataSet1TableAdapters.SupplierTableAdapter();
                //  DataSet1.SupplierDataTable pts = tas.GetDataByIdSupplier((int)iddSupplier);
                // txtProveedor.Text = pts.ToString();
                //iddSupplier= row.idSupplier;
                //  DataSet1.SupplierRow rowsup = (DataSet1.SupplierRow)pts.Rows[0];

                //  rowsup.id_Supplier = iddSupplier; 

                //
                // int.Parse(dgvProveedor.Rows[dgvProveedor.CurrentRow.Index].Cells[0].Value.ToString());
                //DataSet1.SupplierRow rowsup = (DataSet1.SupplierRow)pts.Rows[0];
                //rowsup.id_Supplier = row.idSupplier; 

            }
            else
            {
                MessageBox.Show("No hay registros");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string message = "Esta seguro que desea eliminar este registro?";
            string title = "Advertencia";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            //
            int? id = GetId();

            if (result == DialogResult.Yes)
            {
                if (id != null)
                {
                    DataSet1TableAdapters.ProductTableAdapter ta = new DataSet1TableAdapters.ProductTableAdapter();
                    try
                    {
                        ta.DeleteQueryProduct((int)id);
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int valorIdSupplier = int.Parse(dgvProveedor.Rows[dgvProveedor.CurrentRow.Index].Cells[0].Value.ToString());
            // MessageBox.Show(idd.ToString());
            DataSet1TableAdapters.ProductTableAdapter ta = new DataSet1TableAdapters.ProductTableAdapter();
            //   MessageBox.Show(idd.ToString());
            if (string.IsNullOrWhiteSpace(txtNombre.Text))


            {

                MessageBox.Show("Verifique que todos los campos hayan sido llenados correctamente");
            }


            else
            if (idd == 0)
            {
                // ta.InsertQueryMaterial(txtNombre.Text.Trim());

                ta.InsertQueryProduct(txtNombre.Text.Trim(), (int)udCantidad.Value, clnFechaExp.SelectionRange.Start.ToShortDateString(), (decimal)udUnidades.Value, (int)valorIdSupplier, txtTipoUnidad.Text.Trim(), txtPresentacion.Text.Trim());
                txtNombre.Clear();
                udCantidad.Value = 0;
                udUnidades.Value = 0;
                clnFechaExp.SetDate(DateTime.Now);

                txtTipoUnidad.Clear();
                txtProveedor.Clear();
                txtProveedor.Enabled = true;
                dgvProveedor.Enabled = true;
                btnElegir.Enabled = true;
                btnLimpiar.Enabled = true;
                idd = 0;
                Refresh();
                valorIdSupplier = 0;
                txtPresentacion.Clear();
            }
            else
            {
                //  int valorIdSupplier = int.Parse(dgvProveedor.Rows[dgvProveedor.CurrentRow.Index].Cells[0].Value.ToString());

                ta.UpdateQueryProduct(txtNombre.Text.Trim(), (int)udCantidad.Value, txtPresentacion.Text.Trim(),
                    clnFechaExp.SelectionRange.Start.ToShortDateString(), (decimal)udUnidades.Value,
                     txtTipoUnidad.Text.Trim(),
                   valorIdSupplier
                   
                    
                    , (int)idd);

        

                txtNombre.Clear();
                udCantidad.Value = 0;
                udUnidades.Value = 0;
                clnFechaExp.SetDate(DateTime.Now);
                valorIdSupplier = 0;

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

        private void txtBuscarProd_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {
                DataSet1TableAdapters.ProductTableAdapter ta = new DataSet1TableAdapters.ProductTableAdapter();
                DataSet1.ProductDataTable dt =
             ta.GetDataByProductFiltering(txtBuscarProd.Text//,//string
              , txtBuscarProd.Text
              , txtBuscarProd.Text
              , txtBuscarProd.Text
              , txtBuscarProd.Text,
              txtBuscarProd.Text,
              txtBuscarProd.Text
                     //   ,txtBuscarMat.Text,// clnFechaExp.SelectionRange.Start.ToShortDateString(),
                     //   , Convert.ToDecimal(txtBuscarMat.Text),//decimal
                     //   , Convert.ToInt32(txtBuscarMat.Text)//int
                     //,Convert.ToInt32(txtBuscarMat.Text)//int
                     //   ,txtBuscarMat.Text,// clnFechaExp.SelectionRange.Start.ToShortDateString(),
                     //   , Convert.ToDecimal(txtBuscarMat.Text),//decimal
                     //   , Convert.ToInt32(txtBuscarMat.Text)//int
                     );
                //  (txtNombre.Text.Trim(), (int)udCantidad.Value,
                //      clnFechaExp.SelectionRange.Start.ToShortDateString(), (decimal)udUnidades.Value,

                //   valorIdSupplier
                //  , (int)idd);

                ta.FillByProductFiltering(dt, txtBuscarProd.Text//,

              , txtBuscarProd.Text
              , txtBuscarProd.Text
              , txtBuscarProd.Text
              , txtBuscarProd.Text,
              txtBuscarProd.Text,
              txtBuscarProd.Text
              );

                dataGridView1.DataSource = dt;

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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


            //try
            //{
            //    DataSet1TableAdapters.SupplierTableAdapter ta = new DataSet1TableAdapters.SupplierTableAdapter();
            //    DataSet1.SupplierDataTable dt = ta.GetDataByFilteringSupplier(txtProveedor.Text);


            //    ta.FillByFilteringSupplier(dt, txtProveedor.Text);


            //    dgvProveedor.DataSource = dt;

            //}
            //catch (System.Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
