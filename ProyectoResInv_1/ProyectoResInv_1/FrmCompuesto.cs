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
    public partial class FrmCompuesto : Form
    {
        int idd; int iddSupplier;
        private int? id;

        public FrmCompuesto()
        {
            InitializeComponent();
        }


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
             
            dataGridView1.Columns[4].HeaderText = "Cantidad Presentacion";
            dataGridView1.Columns[5].HeaderText = "Unidades";

            dataGridView1.Columns[6].HeaderText = "Tipo Unidad";
            dataGridView1.Columns[7].HeaderText = "Cantidad Dosis";
            dataGridView1.Columns[8].HeaderText = "Unidades Dosis";
            dataGridView1.Columns[9].HeaderText = "Proveedor";

        }


        /*WE'LL GET THE compound ID*/
        private int? GetId()
        {
            try
            {
                idd = int.Parse(
                        dgvMedicamento.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()
                        );
                return int.Parse(
                    dgvMedicamento.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()
                    );

            }
            catch
            {

                return null;
            }


        }

        /*WE'LL GET THE medicine ID*/
        private int? GetIdMedicine()
        {

            try
            {
                idd = int.Parse(
                        dgvMedicamento.Rows[dgvMedicamento.CurrentRow.Index].Cells[0].Value.ToString()
                        );
                return int.Parse(
                    dgvMedicamento.Rows[dgvMedicamento.CurrentRow.Index].Cells[0].Value.ToString()
                    );

            }
            catch
            {

                return null;
            }


        }

        private void RefreshMedicine()
        {
            DataSet1TableAdapters.MedicineTableAdapter ta =
                new DataSet1TableAdapters.MedicineTableAdapter();

            DataSet1.MedicineDataTable dt = ta.GetDataMedicine();
            dgvMedicamento.DataSource = dt;
            dgvMedicamento.Columns[0].HeaderText = "Id";
            dgvMedicamento.Columns[1].HeaderText = "Nombre";
            dgvMedicamento.Columns[2].HeaderText = "Caducidad";
            dgvMedicamento.Columns[3].HeaderText = "Cantidad";

            dgvMedicamento.Columns[4].HeaderText = "Presentacion";
            dgvMedicamento.Columns[5].HeaderText = "Unidades";

            dgvMedicamento.Columns[6].HeaderText = "Tipo Unidad";
            dgvMedicamento.Columns[7].HeaderText = "Cantidad Dosis";
            dgvMedicamento.Columns[8].HeaderText = "Unidades Dosis";
            dgvMedicamento.Columns[9].HeaderText = "Proveedor";

        }


        private void txtMedicamento_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (checkBox2.Checked)
            {
                //
                try
                {
                    DataSet1TableAdapters.MedicineTableAdapter ta = new DataSet1TableAdapters.MedicineTableAdapter();
                    DataSet1.MedicineDataTable dt = ta.GetDataByBuscarIDMedicine(txtBuscarMed.Text);
                    //ta.GetDataByIdSupplier(txtBusquedaProv.Text);


                    ta.FillByBuscarIDMedicine(dt, txtBuscarMed.Text);


                    dgvMedicamento.DataSource = dt;

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
                DataSet1TableAdapters.MedicineTableAdapter ta = new DataSet1TableAdapters.MedicineTableAdapter();
                DataSet1.MedicineDataTable dt =
             ta.GetDataByMedicineFiltering(txtBuscarMed.Text//,//string
              , txtBuscarMed.Text
              , txtBuscarMed.Text
              , txtBuscarMed.Text
              , txtBuscarMed.Text
          ,  txtBuscarMed.Text
          ,   txtBuscarMed.Text
          , txtBuscarMed.Text
          , txtBuscarMed.Text

              
                     );
                //  (txtNombre.Text.Trim(), (int)udCantidad.Value,
                //      clnFechaExp.SelectionRange.Start.ToShortDateString(), (decimal)udUnidades.Value,

                //   valorIdSupplier
                //  , (int)idd);

                ta.FillByMedicineFiltering
                    (dt, txtBuscarMed.Text  

              , txtBuscarMed.Text
              , txtBuscarMed.Text
              , txtBuscarMed.Text
              , txtBuscarMed.Text
             , txtBuscarMed.Text
             , txtBuscarMed.Text
             , txtBuscarMed.Text
             , txtBuscarMed.Text
              );

                dgvMedicamento.DataSource = dt;

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
            }


        }

        private void btnLimpiarProv_Click(object sender, EventArgs e)
        {
            txtBuscarMed.Clear();
            RefreshMedicine();
        }

        private void FrmCompuesto_Load(object sender, EventArgs e)
        {
            Refresh();
            RefreshMedicine();
            foreach (DataGridViewColumn c in dgvMedicamento.Columns)
            {
                dgvMedSelected.Columns.Add(c.Clone() as DataGridViewColumn);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int? idM = GetIdMedicine();
            int valorcillo;
            DataSet1TableAdapters.MedicineTableAdapter ta = new DataSet1TableAdapters.MedicineTableAdapter();
            DataSet1.MedicineDataTable pt = ta.GetDataByIdMedicine((int)idM);

            DataSet1.MedicineRow row = (DataSet1.MedicineRow)pt.Rows[0];
            MessageBox.Show(idM.ToString());

            //then you can copy the rows values one by one (working on the selectedrows collection)
            for (int fila = 0; fila < dgvMedicamento.Rows.Count; fila++)
            {
                for (int filas = 0; filas < dgvMedicamento.ColumnCount; filas++)
                {
                    row[filas] = dgvMedicamento.Rows[fila].Cells[filas].Value.ToString();
                }
            }


                /*
                int? idM = GetIdMedicine();
                int valorcillo;
                //    MessageBox.Show(idM.ToString());
                if (idM != null)
                {
                    foreach (DataGridViewRow roww in dgvMedicamento.Rows)
                    {


                    DataSet1TableAdapters.MedicineTableAdapter ta = new DataSet1TableAdapters.MedicineTableAdapter();
                    DataSet1.MedicineDataTable pt = ta.GetDataByIdMedicine((int)idM);

                    DataSet1.MedicineRow row = (DataSet1.MedicineRow)pt.Rows[0];


                    DataSet1TableAdapters.MedicineTableAdapter dataSet = new DataSet1TableAdapters.MedicineTableAdapter();
                    DataSet1.MedicineDataTable pt2 = ta.GetDataByIdMedicine((int)idM);
                    DataSet1.MedicineRow row2 = (DataSet1.MedicineRow)pt2.Rows[0];

                        //   row2.id_Medicine = row.id_Medicine.;

                    row2.MedicineName = row.MedicineName;
                    row2.MedicineExpDate = row.MedicineExpDate;
                    row2.MedicineQuantity = row.MedicineQuantity;
                    row2.MedicineQuantityPres = row.MedicineQuantityPres;
                    row2.MedicineUnits = row.MedicineUnits;
                    row2.MedicineUnitsType = row.MedicineUnitsType;
                    row2.MedicineDosQuan = row.MedicineDosQuan;
                    row2.MedicineDosUnits = row.MedicineDosUnits;
                    valorcillo = row.idSupplier;
                    row2.idSupplier = row.idSupplier;



                    // MessageBox.Show(valorcillo.ToString());
                    //from here
                    DataSet1TableAdapters.SupplierTableAdapter tas = new DataSet1TableAdapters.SupplierTableAdapter();
                    DataSet1.SupplierDataTable pts = tas.GetDataByIdSupplier((int)valorcillo);
                        //  DataSet1.SupplierRow rowsup = (DataSet1.SupplierRow)pts.Rows[0];
                        //  txtProveedor.Text = rowsup.ToString();

                        dgvMedSelected.DataSource = pt2;
                    }

                }//foreach
                else
                {
                    MessageBox.Show("No hay registros");
                }
                /*
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
                 */
            }

            private void btnQuitar_Click(object sender, EventArgs e)
        {
            /*
             
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
             */
        }

        private void cbxCargarTodo_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnLimpiarProd_Click(object sender, EventArgs e)
        {
            txtBuscarComp.Clear();
            Refresh();
        }
    }
}
