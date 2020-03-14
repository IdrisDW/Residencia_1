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
        int idd;int iddSupplier;
        private int? id;
        private string MaterialName = "";
        private int? MaterialQuantity;
        DateTime Materialdt = new DateTime().Date;
       // private string MaterialExpDate = "";
        private decimal? MaterialUnits;
        private string MatSupplier = "";
        private string MatQuanPres = "";

        public FrmMaterial(int? id = null, string MaterialName = "", int? MaterialQuantity = null,
       DateTime Materialdt = new DateTime() ,
          decimal? MaterialUnits = null,
          string MatSupplier = "", string MatQuanPres="")
        {
            InitializeComponent();
            this.id = id;
            this.MaterialName = MaterialName;
            this.MaterialQuantity = MaterialQuantity;
            this.Materialdt= Materialdt;
            this.MaterialUnits = MaterialUnits;
            this.MatSupplier = MatSupplier;
            this.MatQuanPres = MatQuanPres;
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
            dataGridView1.Columns[3].HeaderText = "Presentacion";
             
            dataGridView1.Columns[4].HeaderText = "Unidades";
            dataGridView1.Columns[5].HeaderText = "Caducidad";
         

            dataGridView1.Columns[6].HeaderText = "Proveedor";
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
            if (checkBox1.Checked)
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


            //    ta.FillByFilteringSupplier(dt,txtProveedor.Text);


            //    dgvProveedor.DataSource = dt;

            //}
            //catch (System.Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
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
        //
        private void button1_Click(object sender, EventArgs e)
        {

            int? idS = GetIdSupplier();
       //    MessageBox.Show(idS.ToString());
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

        string fecha;
        private void clnFechaExp_DateChanged(object sender, DateRangeEventArgs e)
        {
            fecha = clnFechaExp.SelectionRange.Start.ToShortDateString();
           // MessageBox.Show(fecha.ToString());
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int valorIdSupplier = int.Parse(dgvProveedor.Rows[dgvProveedor.CurrentRow.Index].Cells[0].Value.ToString());
           // MessageBox.Show(idd.ToString());
            DataSet1TableAdapters.MaterialTableAdapter ta = new DataSet1TableAdapters.MaterialTableAdapter();
         //   MessageBox.Show(idd.ToString());
            if (string.IsNullOrWhiteSpace(txtNombre.Text) )


            {

                MessageBox.Show("Verifique que todos los campos hayan sido llenados correctamente");
            }


            else
            if (idd == 0)
            {
                // ta.InsertQueryMaterial(txtNombre.Text.Trim());
              
                ta.InsertQueryMaterial(txtNombre.Text.Trim(),(int)udCantidad.Value, clnFechaExp.SelectionRange.Start.ToShortDateString(),
                    (decimal)udUnidades.Value,(int)valorIdSupplier, txtPresentacion.Text.Trim());
                txtNombre.Clear();
                 udCantidad.Value = 0;
                udUnidades.Value = 0 ;
                 
                clnFechaExp.SetDate(DateTime.Now);


                txtProveedor.Clear();
                txtProveedor.Enabled = true;
                dgvProveedor.Enabled = true;
                btnElegir.Enabled = true;
                btnLimpiar.Enabled = true;
                idd = 0;
                Refresh();
                
                txtPresentacion.Clear();
            }
            else {
              //  int valorIdSupplier = int.Parse(dgvProveedor.Rows[dgvProveedor.CurrentRow.Index].Cells[0].Value.ToString());

                ta.UpdateQueryMaterial(txtNombre.Text.Trim(), (int)udCantidad.Value,
                    clnFechaExp.SelectionRange.Start.ToShortDateString(), (decimal)udUnidades.Value,

                   valorIdSupplier 
                    , txtPresentacion.Text.Trim(),(int)idd);

 

                txtNombre.Clear();
                udCantidad.Value = 0;
                udUnidades.Value = 0;
                clnFechaExp.SetDate(DateTime.Now);

                txtPresentacion.Clear();
                txtProveedor.Clear();
               
                txtProveedor.Enabled = true;
                dgvProveedor.Enabled = true;
                btnElegir.Enabled = true;
                btnLimpiar.Enabled = true;
                idd = 0;
                Refresh();
            }
            /*
             
            
            
             */
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            int? id = GetId();
            int valorcillo;
            //MessageBox.Show(id.ToString());
            if (id != null)
            {
                DataSet1TableAdapters.MaterialTableAdapter ta = new DataSet1TableAdapters.MaterialTableAdapter();
                DataSet1.MaterialDataTable pt = ta.GetDataByIdMaterial((int)id);

                DataSet1.MaterialRow row = (DataSet1.MaterialRow)pt.Rows[0];
               
                txtNombre.Text = row.MaterialName;


                udCantidad.Value = row.MaterialQuantity;
                udUnidades.Value = row.MaterialUnits;
              //  txtTipoUnidad.Text = row.MaterialUnitType;
                clnFechaExp.SetDate(row.MaterialExpDate);


                valorcillo = row.idSupplier;
                // MessageBox.Show(valorcillo.ToString());
                //from here
                DataSet1TableAdapters.SupplierTableAdapter tas = new DataSet1TableAdapters.SupplierTableAdapter();
                DataSet1.SupplierDataTable pts = tas.GetDataByIdSupplier((int)valorcillo);
                //  DataSet1.SupplierRow rowsup = (DataSet1.SupplierRow)pts.Rows[0];
                //  txtProveedor.Text = rowsup.ToString();

                dgvProveedor.DataSource = pts;
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
                    DataSet1TableAdapters.MaterialTableAdapter ta = new DataSet1TableAdapters.MaterialTableAdapter();
                    try
                    {
                        ta.DeleteQueryMaterial((int)id);
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

        private void txtBuscarMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                DataSet1TableAdapters.MaterialTableAdapter ta = new DataSet1TableAdapters.MaterialTableAdapter();
                DataSet1.MaterialDataTable dt =
             ta.GetDataByMaterialFiltering(txtBuscarMat.Text//,//string
              , txtBuscarMat.Text 
              ,txtBuscarMat.Text
              , txtBuscarMat.Text
              , txtBuscarMat.Text
              ,txtBuscarMat.Text
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

                ta.FillByMaterialFiltering(dt, txtBuscarMat.Text//,
                   
              ,  txtBuscarMat.Text 
              , txtBuscarMat.Text
              , txtBuscarMat.Text
              , txtBuscarMat.Text
              ,txtBuscarMat.Text
              );

                dataGridView1.DataSource = dt;

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
