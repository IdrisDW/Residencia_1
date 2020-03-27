using ProyectoResInv_1.DataSet1TableAdapters;
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

        private void RefreshCompound() {

            DataSet1TableAdapters.CompoundTableAdapter ta =
            new DataSet1TableAdapters.CompoundTableAdapter();

            DataSet1.CompoundDataTable dt = ta.GetDataByThreeInnerJoin
            ();
            BS_Test.DataSource = dt;
            dgvCompuesto.DataSource = BS_Test;
            dgvCompuesto.Columns.RemoveAt(0);

            dgvCompuesto.Columns[0].HeaderText = "Nombre de compuesto";
            dgvCompuesto.Columns[1].HeaderText = "Nombre de medicina";
            dgvCompuesto.Columns[2].HeaderText = "Unidades Necesarias";
            dgvCompuesto.Columns[3].HeaderText = "Id compuesto";

            dgvCompuesto.Columns[4].HeaderText = "Id Medicina";
            // DataSet1TableAdapters.CompoundTableAdapter ta =
            //   new DataSet1TableAdapters.CompoundTableAdapter();

            // DataSet1.CompoundDataTable dt = ta.GetDataByInnerJoin 
            // ();
            // BS_Test.DataSource = dt;
            //dgvCompuesto.DataSource = BS_Test;
            // dgvCompuesto.Columns.RemoveAt(0);
            // dgvCompuesto.DataSource = dt; this doesnt




        }//endRefreshCompound
        private void Refresh()
        {
            DataSet1TableAdapters.MedicineTableAdapter ta =
                new DataSet1TableAdapters.MedicineTableAdapter();

            DataSet1.MedicineDataTable dt = ta.GetDataMedicine();

            dgvCompuesto.DataSource = dt;
            dgvCompuesto.Columns[0].HeaderText = "Id";
            dgvCompuesto.Columns[1].HeaderText = "Nombre";
            dgvCompuesto.Columns[2].HeaderText = "Caducidad";
            dgvCompuesto.Columns[3].HeaderText = "Cantidad";

            dgvCompuesto.Columns[4].HeaderText = "Cantidad Presentacion";
            dgvCompuesto.Columns[5].HeaderText = "Unidades";

            dgvCompuesto.Columns[6].HeaderText = "Tipo Unidad";
            dgvCompuesto.Columns[7].HeaderText = "Cantidad Dosis";
            dgvCompuesto.Columns[8].HeaderText = "Unidades Dosis";
            dgvCompuesto.Columns[9].HeaderText = "Proveedor";

            //

        }


        /*WE'LL GET THE compound ID*/
        private int? GetId()
        {
            try
            {
                return null;
                //idd = int.Parse(
                //        dgvMedicamento.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()
                //        );
                //return int.Parse(
                //    dgvMedicamento.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()
                //    );

            }
            catch
            {

                return null;
            }


        }

        /*WE'LL GET THE medicine ID*/
        private int? GetIdMedicine()
        {

            try {

                return null;
            //{
            //    idd = int.Parse(
            //            dgvMedicamento.Rows[dgvMedicamento.CurrentRow.Index].Cells[0].Value.ToString()
            //            );
            //    return int.Parse(
            //        dgvMedicamento.Rows[dgvMedicamento.CurrentRow.Index].Cells[0].Value.ToString()
            //        );

            }
            catch
            {

                return null;
            }


        }

        private void RefreshMedicine() {
            DataSet1TableAdapters.MedicineTableAdapter dataSet = new DataSet1TableAdapters.MedicineTableAdapter();

            //DataSet1.MedicineDataTable pt2 = dataSet.GetDataByIdMedicine((int)idM);
            //medicineBindingSource2.DataSource = pt2;

            DataSet1.MedicineDataTable pt3 = dataSet.GetDataMedicine();


            dataGridView2.AutoGenerateColumns = false;
            medicineBindingSource2.DataSource = pt3;

         
            dataGridView2.Columns[1].HeaderText = "Id";
            dataGridView2.Columns[2].HeaderText = "Nombre";
            dataGridView2.Columns[3].HeaderText = "Caducidad";
            dataGridView2.Columns[4].HeaderText = "Cantidad";
            dataGridView2.Columns[5].HeaderText = "Presentacion";
        
            dataGridView2.Columns[6].HeaderText = "Unidades";
            dataGridView2.Columns[7].HeaderText = "Tipo de Unidades";
            dataGridView2.Columns[8].HeaderText = "Cantidad Dosis";
            dataGridView2.Columns[9].HeaderText = "Unidades Dosis";

            dataGridView2.Columns[10].HeaderText = "Proveedor";
            //DataSet1TableAdapters.MedicineTableAdapter dataSet = new DataSet1TableAdapters.MedicineTableAdapter();
            //DataSet1.MedicineDataTable pt3 = dataSet.GetDataMedicine();
            //dataGridView2.AutoGenerateColumns = false;
            //medicineBindingSource2.DataSource = pt3;
        }

        private void FrmCompuesto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.Compound' table. You can move, or remove it, as needed.
            this.compoundTableAdapter.FillCompound(this.dataSet11.Compound);
            // TODO: This line of code loads data into the 'analisisResidenciaDataSet.Medicine' table. You can move, or remove it, as needed.
            int? idM = GetIdMedicine();
            int valorcillo;
            RefreshMedicine();
        RefreshCompound();

            // DataSet1TableAdapters.MedicineTableAdapter dataSet = new DataSet1TableAdapters.MedicineTableAdapter();

            //DataSet1.MedicineDataTable pt2 = dataSet.GetDataByIdMedicine((int)idM);
            //medicineBindingSource2.DataSource = pt2;

            //DataSet1.MedicineDataTable pt3 = dataSet.GetDataMedicine();


            //dataGridView2.AutoGenerateColumns = false;
            //medicineBindingSource2.DataSource = pt3;
        //    dataGridView3.Columns[3].DefaultCellStyle.Format = "0.00##";
        }

        private void btnLimpiarProv_Click(object sender, EventArgs e)
        {
            txtBuscarMed.Clear();
          

        }

        private void txtBuscarMed_KeyPress(object sender, KeyPressEventArgs e)
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
                    medicineBindingSource2.DataSource = dt;

                    //  dgvProveedor.DataSource = dt;

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
              , txtBuscarMed.Text
              , txtBuscarMed.Text
              , txtBuscarMed.Text
              , txtBuscarMed.Text


                         );


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

                    //  dataGridView1.DataSource = dt;
                    medicineBindingSource2.DataSource = dt;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }//end button

    private void btnAgregar_Click(object sender, EventArgs e)
        {
            //
            // Se define una lista temporal de registro seleccionados
            //
            List<DataGridViewRow> rowSelected = new List<DataGridViewRow>();

            //
            // Se recorre ca registro de la grilla de origen
            //
            int cantMarcados = dataGridView2.Rows.Cast<DataGridViewRow>().Where(x => Convert.ToBoolean(x.Cells["Seleccion"].Value)).Count();
            if (   cantMarcados <= 5)
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    //
                    // Se recupera el campo que representa el checkbox, y se valida la seleccion
                    // agregandola a la lista temporal
                    //
                    DataGridViewCheckBoxCell cellSelecion = row.Cells["Seleccion"] as DataGridViewCheckBoxCell;




                    if (Convert.ToBoolean(cellSelecion.Value))
                    {
                        rowSelected.Add(row);
                    }
                }

                //
                // Se agrega el item seleccionado a la grilla de destino
                // eliminando la fila de la grilla original
                //

                // *********************************
                // *********************************

              

                //
                foreach (DataGridViewRow row in rowSelected)
                {

                    DateTime date = DateTime.Now;
                    DateTime safaera = Convert.ToDateTime(row.Cells[3].Value);
                    var blablabla = safaera.ToString("yyyy-MM-dd");
                  //  MessageBox.Show(blablabla.ToString());
                    //    ToShortDateString()

                    // MessageBox.Show(row.Cells[0].Value.ToString());
                    dataGridView3.Rows.Add(new object[] {false,
                                            row.Cells[1].Value,
                                            row.Cells[2].Value,
                                            blablabla.ToString(),
                                           // row.Cells[3].Value,
                                            row.Cells[4].Value,
                                            row.Cells[5].Value,
                                            row.Cells[6].Value,
                                             row.Cells[7].Value,
                                            row.Cells[8].Value,
                                            row.Cells[9].Value,
                                            row.Cells[10].Value

                });

                    dataGridView2.Rows.Remove(row);
                }
            }
            else {
                MessageBox.Show("Solo se pueden seleccionar 5 o menos medicamentos");
            }
            
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {

            //
            // Se define una lista temporal de registro seleccionados
            //
            List<DataGridViewRow> rowSelected = new List<DataGridViewRow>();

            //
            // Se recorre cada fila de la grilla de seleccion y se determian que registros estan checkeados
            //
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                DataGridViewCheckBoxCell cellSelecion = row.Cells["Selecciona"] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(cellSelecion.Value))
                {
                    rowSelected.Add(row);
                }
            }

            //
            // Se valida si hay algun registro por eliminar
            //
            if (rowSelected.Count > 0)
            {
                //
                // Se recupera el origen de datos que tiene asignada la grilla de productos
                //
                //   dtoProductos datos = dgvProductos.DataSource as dtoProductos;
                DataSet1 datoi = dataGridView2.DataSource as DataSet1;
                //
                /**/
                //this
                DataSet1TableAdapters.MedicineTableAdapter dataSet = new DataSet1TableAdapters.MedicineTableAdapter();
                DataSet1.MedicineDataTable pt3 = dataSet.GetDataMedicine();




                //to this
                /**/
                //
                // Se recorre cada item seleccionado y se arma programaticamente la fila del DataTable
                // se elimina el registro de la grilla de selecciones
                //
                foreach (DataGridViewRow row in rowSelected)
                {

                    // MessageBox.Show("and all that jazz");
                    // dtoProductos.ProductosRow productoRow = datos.Productos.NewProductosRow();
                    // datoi.Medicine.NewMedicineRow productoRow = datoi.Medicine.NewMedicineRow();
                    //  DataSet1.MedicineRow medicineRow = datoi.Medicine.NewMedicineRow();
                    //
                    //DataSet1TableAdapters.MedicineTableAdapter ta = new DataSet1TableAdapters.MedicineTableAdapter();
                    //DataSet1.MedicineDataTable pt = ta.GetDataByIdMedicine((int)idM);

                    //DataSet1.MedicineRow row = (DataSet1.MedicineRow)pt.Rows[0];
                    //MessageBox.Show(idM.ToString());

                    //DataSet1.MedicineDataTable pt2 = ta.GetDataByIdMedicine((int)idM);
                    //DataSet1.MedicineRow row2 = (DataSet1.MedicineRow)pt2.Rows[0];
                    DataSet1.MedicineRow row3;
                    //     row3 = (DataSet1.MedicineRow)pt3.Rows[0];
                    row3 = pt3.NewMedicineRow();

                    //
                    //medicineRow.id_Medicine = Convert.ToInt32(row.Cells[1].Value);
                    //medicineRow.MedicineName = Convert.ToString(row.Cells[2].Value);
                    //medicineRow.MedicineExpDate = Convert.ToDateTime(row.Cells[3].Value);
                    //medicineRow.MedicineQuantity = Convert.ToInt32(row.Cells[4].Value);
                    //medicineRow.MedicineQuantityPres = Convert.ToString(row.Cells[5].Value);
                    //medicineRow.MedicineUnits = Convert.ToDecimal(row.Cells[6].Value);
                    //medicineRow.MedicineUnitsType = Convert.ToString(row.Cells[7].Value);
                    //medicineRow.MedicineDosQuan = Convert.ToDecimal(row.Cells[8].Value);
                    //medicineRow.MedicineDosUnits = Convert.ToDecimal(row.Cells[9].Value);
                    //medicineRow.idSupplier= Convert.ToInt32(row.Cells[10].Value);
                    //living in

                    //  row3.id_Medicine = Convert.ToInt32(row.Cells[1].Value);


                    // HERE HERE HERE

                    row3.MedicineName = Convert.ToString(row.Cells[2].Value);


                    //DateTime date = DateTime.Now;
                    //DateTime safaera = Convert.ToDateTime(row.Cells[7].Value);
                    //var blablabla = safaera.ToString("yyyy-MM-dd");
                    //MessageBox.Show(blablabla.ToString());


                    row3.MedicineExpDate = Convert.ToDateTime(row.Cells[3].Value);
                    row3.MedicineQuantity = Convert.ToInt32(row.Cells[4].Value);
                    row3.MedicineQuantityPres = Convert.ToString(row.Cells[5].Value);

                    row3.MedicineUnits = Convert.ToDecimal(row.Cells[6].Value);
                    row3.MedicineUnitsType = Convert.ToString(row.Cells[7].Value);
                    row3.MedicineDosQuan = Convert.ToDecimal(row.Cells[8].Value);
                    row3.MedicineDosUnits = Convert.ToDecimal(row.Cells[9].Value);
                   row3.idSupplier = Convert.ToInt32(row.Cells[10].Value);
                   
                     


                    // END HERE

                    /* SAFAERAAA
                    row3.MedicineName = Convert.ToString(row.Cells[2].Value);
                    row3.MedicineQuantity = Convert.ToInt32(row.Cells[3].Value);
                    row3.MedicineUnits = Convert.ToDecimal(row.Cells[4].Value);
                    row3.MedicineDosQuan = Convert.ToDecimal(row.Cells[5].Value);
                    row3.MedicineDosUnits = Convert.ToDecimal(row.Cells[6].Value);

                    DateTime date = DateTime.Now;
                    DateTime safaera = Convert.ToDateTime(row.Cells[7].Value);
                    var blablabla = safaera.ToString("yyyy-MM-dd");
                    MessageBox.Show(blablabla.ToString());

                    
                    row3.MedicineExpDate = Convert.ToDateTime(row.Cells[7].Value);
                    row3.idSupplier = Convert.ToInt32(row.Cells[8].Value);
                    row3.MedicineUnitsType = Convert.ToString(row.Cells[9].Value);
                    row3.MedicineQuantityPres = Convert.ToString(row.Cells[10].Value);
                    */
                    //    row3.MedicineQuantity = Convert.ToInt32(row.Cells[4].Value);
                    // row3.MedicineQuantityPres = Convert.ToString(row.Cells[5].Value);
                    //   row3.MedicineUnits = Convert.ToDecimal(row.Cells[6].Value);
                    //  row3.MedicineUnitsType = Convert.ToString(row.Cells[7].Value);
                    //  row3.MedicineDosQuan = Convert.ToDecimal(row.Cells[8].Value);
                    //  row3.MedicineDosUnits = Convert.ToDecimal(row.Cells[9].Value);
                    //  row3.idSupplier = Convert.ToInt32(row.Cells[10].Value);
                    //beverlyhills
                    //  datoi.Medicine.Rows.Add(medicineRow);
                    // pt3.Rows.Add(row3);//THIS LINE WAS HERE FOR SOME REASON .. DO NOT REMOVE
                    // Rows.Add(medicineRow); 
                    dataGridView3.Rows.Remove(row);

                }

                //
                // Se binden los datos nuevamente, pero ahora con los nuevos registros
                // agregados del paso anterior
                //
                dataGridView2.AutoGenerateColumns = false;
                // dataGridView2.DataSource = datoi;
                dataGridView2.DataSource = pt3;
                //     dataGridView3.DataMember = "Productos";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dataGridView3.Rows.Count < 2)
            {
                MessageBox.Show("Agregar mas de 1 medicamento al compuesto");
            }
            else
            {
                //
                //  int valorId = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
                // MessageBox.Show(idd.ToString());
                DataSet1TableAdapters.CompoundTableAdapter ta = new DataSet1TableAdapters.CompoundTableAdapter();

                DataSet1TableAdapters.MedicineCompoundTableAdapter tc = new DataSet1TableAdapters.MedicineCompoundTableAdapter();
                if (string.IsNullOrWhiteSpace(txtNombre.Text))


                {

                    MessageBox.Show("Verifique que todos los campos hayan sido llenados correctamente");
                }
                //

                //

                else
               if (idd == 0)
                {
                    int algomas = 0;

                    ta.InsertQueryCompound(txtNombre.Text.Trim());


                    MessageBox.Show(ta.FillBySelectIdentCurrent().ToString());

                    txtNombre.Clear();

                    //refresh

                    //nae no ni

                    for (int i = 0; i < dataGridView3.Rows.Count; i++)
                    {
                        int idMedicina;
                        idMedicina = Convert.ToInt32(dataGridView3.Rows[i].Cells[1].Value);
                        decimal idCompoundsie = 0;

                        try
                        {
                            idMedicina = Convert.ToInt32(dataGridView3.Rows[i].Cells[1].Value);
                            idCompoundsie = Convert.ToDecimal(dataGridView3.Rows[i].Cells[11].Value);
                            algomas = Convert.ToInt32(ta.FillBySelectIdentCurrent().ToString());
                        }
                        catch (Exception always)
                        {
                            MessageBox.Show
                                ("Revisar que los campos sean correctos");
                        };

                        tc.InsertQueryMedicineCompound(idMedicina, algomas, idCompoundsie);

                        //MessageBox.Show(
                        //  (
                        //decimal.TryParse(dataGridView3.Rows[i].Cells[11].Value.ToString()
                        //    , out idCompound)
                        //    ;
                        //)
                        //.ToString()
                        //)
                        //;





                        //MessageBox.Show(Convert.ToInt32(dataGridView3.Rows[i].Cells[1].Value).ToString());

                        // MessageBox.Show(Convert.ToDecimal(dataGridView3.Rows[i].Cells[11].Value).ToString());





                        // tc.InsertQueryMedicineCompound( Convert.ToInt32(dataGridView3.Rows[i].Cells[1].Value), algomas,Convert.ToDecimal(dataGridView2.Rows[i].Cells[11].Value));
                        //   tc.InsertQueryMedicineCompound(idd, Convert.ToInt32(dataGridView3.Rows[i].Cells[1].Value),Convert.ToDecimal(dataGridView2.Rows[i].Cells[11].Value));
                        //StrQuery = @"INSERT INTO tableName VALUES ("
                        //    + dataGridView1.Rows[i].Cells["ColumnName"].Text + ", "
                        //    + dataGridView1.Rows[i].Cells["ColumnName"].Text + ");";
                        //comm.CommandText = StrQuery;
                        //comm.ExecuteNonQuery();
                    }//for
                    idd = 0;
                }

                else
                {

                    ta.UpdateQueryCompound
                    (txtNombre.Text.Trim(), (int)idd);
                    //Refresh();
                    txtNombre.Clear();
                    idd = 0;
                }
            }//else
            //dataGridView3.Columns[3].DefaultCellStyle.Format =  "0.00##";
            //MessageBox.Show(dataGridView3.Columns[3].DefaultCellStyle.Format = "0.00##".ToString()) ;
            //if (dataGridView3.Rows.Count > 1) {
            //    MessageBox.Show("aceptado");
            //}
            }//boton

        private void dataGridView3_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            e.Control.KeyPress -= new KeyPressEventHandler(Column11_KeyPress);
            if (dataGridView3.CurrentCell.ColumnIndex == 11) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column11_KeyPress);
                }
            }
        }

        private void Column11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            RefreshCompound();
        }

        private void txtBuscarComp_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                DataSet1TableAdapters.CompoundTableAdapter ta = new DataSet1TableAdapters.CompoundTableAdapter();

              
                DataSet1.CompoundDataTable dt =
          ta.GetDataByBusquedaThree(txtBuscarComp.Text,txtBuscarComp.Text,
          txtBuscarComp.Text, txtBuscarComp.Text, txtBuscarComp.Text);
                //  (txtNombre.Text.Trim(), (int)udCantidad.Value,
                //      clnFechaExp.SelectionRange.Start.ToShortDateString(), (decimal)udUnidades.Value,

                //   valorIdSupplier
                //  , (int)idd);

                ta.FillByBusquedaThree
                    (dt, txtBuscarComp.Text, txtBuscarComp.Text, txtBuscarComp.Text, txtBuscarComp.Text
                    , txtBuscarComp.Text
              );
               
                dgvCompuesto.DataSource = dt;
                dgvCompuesto.Columns.Remove("id_Compound");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //{
        //    DataSet1TableAdapters.MedicineTableAdapter ta =
        //        new DataSet1TableAdapters.MedicineTableAdapter();

        //    DataSet1.MedicineDataTable dt = ta.GetDataMedicine();
        //    dgvMedicamento.DataSource = dt;
        //    //   dgvMedicamento.Rows.Clear();
        //    //   foreach (DataRow item in dt.Rows) {
        //    //        int n = dgvMedicamento.Rows.Add();
        //    //      dgvMedicamento.Rows[n].Cells[1].Value = item["id"].ToString();
        //    //     }
        //    dgvMedicamento.Columns[0].HeaderText = "Id";
        //    dgvMedicamento.Columns[1].HeaderText = "Nombre";
        //    dgvMedicamento.Columns[2].HeaderText = "Caducidad";
        //    dgvMedicamento.Columns[3].HeaderText = "Cantidad";

        //    dgvMedicamento.Columns[4].HeaderText = "Presentacion";
        //    dgvMedicamento.Columns[5].HeaderText = "Unidades";

        //    dgvMedicamento.Columns[6].HeaderText = "Tipo Unidad";
        //    dgvMedicamento.Columns[7].HeaderText = "Cantidad Dosis";
        //    dgvMedicamento.Columns[8].HeaderText = "Unidades Dosis";
        //    dgvMedicamento.Columns[9].HeaderText = "Proveedor";

        //    //     dgvMedSelected.DataSource= dt;
        //    //create
        //    foreach (DataGridViewColumn dgvc in dataGridView1.Columns)
        //    {
        //        dgvMedSelected.Columns.Add(dgvc.Clone() as DataGridViewColumn);
        //    }



        //    //

        //    //
        //    //dgvMedSelected.Columns.Add("ColumnID", "Id");
        //    //dgvMedSelected.Columns.Add("ColumnName", "Nombre");
        //    //dgvMedSelected.Columns.Add("ColumnExp", "Id");
        //    //dgvMedSelected.Columns.Add("ColumnQuan", "Id");
        //    //dgvMedSelected.Columns.Add("ColumnPres", "Id");
        //    //dgvMedSelected.Columns.Add("ColumnUnit", "Id");
        //    //dgvMedSelected.Columns.Add("ColumnUnitType", "Id");
        //    //dgvMedSelected.Columns.Add("ColumnDosisQuan", "Id");
        //    //dgvMedSelected.Columns.Add("ColumnSupp", "Id");
        //    //here
        //    //dgvMedSelected.Columns[0].HeaderText = "Id";
        //    //dgvMedSelected.Columns[1].HeaderText = "Nombre";
        //    //dgvMedSelected.Columns[2].HeaderText = "Caducidad";
        //    //dgvMedSelected.Columns[3].HeaderText = "Cantidad";

        //    //dgvMedSelected.Columns[4].HeaderText = "Presentacion";
        //    //dgvMedSelected.Columns[5].HeaderText = "Unidades";

        //    //dgvMedSelected.Columns[6].HeaderText = "Tipo Unidad";
        //    //dgvMedSelected.Columns[7].HeaderText = "Cantidad Dosis";
        //    //dgvMedSelected.Columns[8].HeaderText = "Unidades Dosis";
        //    //dgvMedSelected.Columns[9].HeaderText = "Proveedor";


    }


    //private void txtMedicamento_KeyPress(object sender, KeyPressEventArgs e)
    //{

    //    if (checkBox2.Checked)
    //    {
    //        //
    //        try
    //        {
    //            DataSet1TableAdapters.MedicineTableAdapter ta = new DataSet1TableAdapters.MedicineTableAdapter();
    //            DataSet1.MedicineDataTable dt = ta.GetDataByBuscarIDMedicine(txtBuscarMed.Text);
    //            //ta.GetDataByIdSupplier(txtBusquedaProv.Text);


    //            ta.FillByBuscarIDMedicine(dt, txtBuscarMed.Text);


    //          //  dgvMedicamento.DataSource = dt;

    //        }
    //        catch (System.Exception ex)
    //        {
    //            MessageBox.Show(ex.Message);
    //        }
    //        //
    //    }
    //    else
    //    {

    //        try
    //        {
    //            DataSet1TableAdapters.MedicineTableAdapter ta = new DataSet1TableAdapters.MedicineTableAdapter();
    //            DataSet1.MedicineDataTable dt =
    //         ta.GetDataByMedicineFiltering(txtBuscarMed.Text//,//string
    //          , txtBuscarMed.Text
    //          , txtBuscarMed.Text
    //          , txtBuscarMed.Text
    //          , txtBuscarMed.Text
    //      , txtBuscarMed.Text
    //      , txtBuscarMed.Text
    //      , txtBuscarMed.Text
    //      , txtBuscarMed.Text


    //                 );
    //            //  (txtNombre.Text.Trim(), (int)udCantidad.Value,
    //            //      clnFechaExp.SelectionRange.Start.ToShortDateString(), (decimal)udUnidades.Value,

    //            //   valorIdSupplier
    //            //  , (int)idd);

    //            ta.FillByMedicineFiltering
    //                (dt, txtBuscarMed.Text

    //          , txtBuscarMed.Text
    //          , txtBuscarMed.Text
    //          , txtBuscarMed.Text
    //          , txtBuscarMed.Text
    //         , txtBuscarMed.Text
    //         , txtBuscarMed.Text
    //         , txtBuscarMed.Text
    //         , txtBuscarMed.Text
    //          );

    //         //   dgvMedicamento.DataSource = dt;

    //        }
    //        catch (System.Exception ex)
    //        {
    //            MessageBox.Show(ex.Message);
    //        }

    //    }


    //}

    //private void btnLimpiarProv_Click(object sender, EventArgs e)
    //{
    //    txtBuscarMed.Clear();
    //    RefreshMedicine();
    //}

    //private void FrmCompuesto_Load(object sender, EventArgs e)
    //    {
    //// TODO: This line of code loads data into the 'analisisResidenciaDataSet.Medicine' table. You can move, or remove it, as needed.
    //int? idM = GetIdMedicine();
    //int valorcillo;
    //DataSet1TableAdapters.MedicineTableAdapter dataSet = new DataSet1TableAdapters.MedicineTableAdapter();

    ////DataSet1.MedicineDataTable pt2 = dataSet.GetDataByIdMedicine((int)idM);
    ////medicineBindingSource2.DataSource = pt2;

    //DataSet1.MedicineDataTable pt3 = dataSet.GetDataMedicine();


    //dataGridView2.AutoGenerateColumns = false;
    //medicineBindingSource2.DataSource = pt3;


    //  DataSet1.MedicineDataTable pt2 = ta.GetDataByIdMedicine((int)idM);


    //DataSet1TableAdapters.MedicineTableAdapter dataSet = new DataSet1TableAdapters.MedicineTableAdapter();
    //DataSet1.MedicineDataTable pt2 = ta.GetDataByIdMedicine((int)idM);

    //     DataSet1 dataSet1 = new DataSet1();
    //medicineBindingSource2.DataSource =    dataSet1.Medicine.ToList();
    //  //   DataSet dataSet = new DataSet1();
    //   DataTable dt = new DataTable("Medicine");
    //   DataSet ds = new DataSet();
    //   ds.Tables.Add(dt);
    //   dataGridView2.DataSource = ds.Tables["Medicine"];
    ////   dataGridView2.DataSource = DataSet1.MedicineDataTable();
    //   dataGridView2.DataSource = dataSet.Tables[4];

    //   medicineDataTableBindingSource.DataSource = dataSet1.Medicine.ToList();
    // medicineBindingSource1.DataSource = dataSet1.Medicine.ToList();

    // dataSet1.Fill(dataGridViewLeft);


    //DataSet1TableAdapters.MedicineTableAdapter ta = new DataSet1TableAdapters.MedicineTableAdapter();
    //  ta.FillMedicine(dataGridViewLeft);


    // TODO: This line of code loads data into the 'dataSet11.Medicine' table. You can move, or remove it, as needed.
    // this.medicineTableAdapter.FillMedicine(this.dataSet11.Medicine);

    /*  foreach (DataGridViewColumn c in dgvMedicamento.Columns)
      {
          dgvMedSelected.Columns.Add(c.Clone() as DataGridViewColumn);
      }*/


    //
    //Refresh();
    //RefreshMedicine();
    //}

    //private void btnActualizar_Click(object sender, EventArgs e)
    //{
    //    Refresh();
    //}

    //int num = 0;
    //private void btnAgregar_Click(object sender, EventArgs e)
    //{


    //}
    //get it
    //int? idM = GetIdMedicine();
    //int valorcillo;
    // ends get it works

    //testing//

    /**/
    //DataGridViewRow dgvr = dgvMedSelected.Rows[dgvMedicamento.DataSource = dgvMedicamento];
    //DataTable dt = (DataTable)dgvMedSelected.DataSource;

    //var row = dt.NewRow();
    //row["cod_corr"] = txtRucDni.Text;
    //row["Nombres"] = dgvr.Cells["Nombres"].Value;
    ////resto
    //dt.Rows.Add(row);

    //dgvVinculados.DataSource = dt;

    /**/
    //end testing//



    //to work    
    //DataSet1TableAdapters.MedicineTableAdapter ta = new DataSet1TableAdapters.MedicineTableAdapter();
    //DataSet1.MedicineDataTable pt = ta.GetDataByIdMedicine((int)idM);

    //DataSet1.MedicineRow row = (DataSet1.MedicineRow)pt.Rows[0];

    //DataSet1TableAdapters.MedicineTableAdapter dataSet = new DataSet1TableAdapters.MedicineTableAdapter();
    //DataSet1.MedicineDataTable pt2 = ta.GetDataByIdMedicine((int)idM);

    //DataSet1.MedicineRow row2 = (DataSet1.MedicineRow)pt2.Rows[0];

    //end to work
    //  DataSet1.SupplierRow rowsup = (DataSet1.SupplierRow)pts.Rows[0];
    //  txtProveedor.Text = rowsup.ToString();
    /*

       //Obtenemos el DataTable del DGV1
       BindingSource source = (BindingSource)dataGridView1.DataSource;
       DataTable datos = ((DataSet)source.DataSource).Tables[0];

       //Creamos un nuevo DT con el filtro.
       DataTable seleccionados = datos.Select("Condicion = 'aceptado'").CopyToDataTable();

       //Asignamos al DGV2 el resultado
       dataGridView2.DataSource = seleccionados;
        */
    //get it
    //if (idM != null)
    //{

    //ends get it
    //drToAdd["Id"] = idM;

    //drToAdd["MedicineName"] = "Value1";
    ////  drToAdd["Medicine"] = "Value2";

    //dataTable.Rows.Add(drToAdd);
    //dataTable.AcceptChanges();


    //row2.MedicineName = row.MedicineName;
    //row2.MedicineExpDate = row.MedicineExpDate;
    //row2.MedicineQuantity = row.MedicineQuantity;
    //row2.MedicineQuantityPres = row.MedicineQuantityPres;
    //row2.MedicineUnits = row.MedicineUnits;
    //row2.MedicineUnitsType = row.MedicineUnitsType;
    //row2.MedicineDosQuan = row.MedicineDosQuan;
    //row2.MedicineDosUnits = row.MedicineDosUnits;
    //valorcillo = row.idSupplier;
    //row2.idSupplier = row.idSupplier;
    //pt2.AcceptChanges();
    // dgvMedSelected.Rows.Add();
    // dgvMedSelected.DataSource = pt2;


    //DataTable Dt = new DataTable();
    //Dt.Columns.Add("Column1");
    //Dt.Columns.Add("Column2");

    //DataRow dr = Dt.NewRow();
    //DataGridViewRow dgvR = (DataGridViewRow)dataGridView1.CurrentRow.Clone();
    //dr[0] = dgvR.Cells[0].Clone();
    //dr[1] = dgvR.Cells[1].Clone();

    //pt2.Rows.Add(row2);
    //dataGridView1.DataSource = pt2;                //
    //Agregar las Filas al DataRow y asignar el valor correspondiente. 
    //DataTable dt2 = new DataTable();
    //dt2 = dgvMedicamento.DataSource as DataTable;

    //   dt2.ImportRow(row);
    //   DataRow datarow;
    //  datarow = dt2.NewRow(); //Con esto le indica que es una nueva fila.


    //dt2.ImportRow(row2);
    //   dt2.Rows.Add(row2);

    //DataTable dataTable = (DataTable)dgvMedicamento.DataSource;
    //DataRow dragrega = dataTable.NewRow();
    //dragrega["MedicineName"] = row.MedicineName;
    //dragrega["MedicineExpDate"] = row.MedicineExpDate;
    //dragrega["MedicineQuantity"] = row.MedicineQuantity;
    //dragrega["MedicineQuantityPres"] = row.MedicineQuantityPres;
    //dragrega["MedicineUnits"] = row.MedicineUnits;
    //dragrega["MedicineUnitsType"] = row.MedicineUnitsType;
    //dragrega["MedicineDosQuan"] = row.MedicineDosQuan;
    //dragrega["MedicineDosUnits"] = row.MedicineDosUnits;
    //valorcillo = row.idSupplier;
    ////row2.idSupplier = row.idSupplier;
    //dragrega["idSupplier"] = valorcillo;
    //dataTable.Rows.Add(dragrega);
    //dataTable.AcceptChanges();

    //
    //  
    ////
    //DataTable dataTableM = (DataTable)dgvMedSelected.DataSource;
    //DataRow dragregaM = dataTableM.NewRow();


    //dragregaM["MedicineName"] = row.MedicineName;
    //dragregaM["MedicineExpDate"] = row.MedicineExpDate;
    //dragregaM["MedicineQuantity"] = row.MedicineQuantity;
    //dragregaM["MedicineQuantityPres"] = row.MedicineQuantityPres;
    //dragregaM["MedicineUnits"] = row.MedicineUnits;
    //dragregaM["MedicineUnitsType"] = row.MedicineUnitsType;
    //dragregaM["MedicineDosQuan"] = row.MedicineDosQuan;
    //dragregaM["MedicineDosUnits"] = row.MedicineDosUnits;
    //valorcillo = row.idSupplier;
    ////row2.idSupplier = row.idSupplier;
    //dragregaM["idSupplier"] = valorcillo;
    //dataTableM.Rows.Add(dragregaM);
    //dataTableM.AcceptChanges();
    //
    //
    //
    /*


     */


    // Adding columns in datagridview2
    //if (dgvMedSelected.RowCount == 0)
    //{
    //MessageBox.Show("whatever");
    // DataGridViewRow rowie = new DataGridViewRow();


    //      rowie = (DataGridViewRow)dgvMedSelected.Rows[0].Clone();

    //row2.MedicineName = row.MedicineName;
    //row2.MedicineExpDate = row.MedicineExpDate;
    //row2.MedicineQuantity = row.MedicineQuantity;
    //row2.MedicineQuantityPres = row.MedicineQuantityPres;
    //row2.MedicineUnits = row.MedicineUnits;
    //row2.MedicineUnitsType = row.MedicineUnitsType;
    //row2.MedicineDosQuan = row.MedicineDosQuan;
    //row2.MedicineDosUnits = row.MedicineDosUnits;
    //valorcillo = row.idSupplier;
    //row2.idSupplier = row.idSupplier;

    //dgvMedSelected.DataSource = pt2;

    //dgvMedSelected.Rows.Insert(0,
    //    row.MedicineName, 
    //    row.MedicineExpDate,
    //   row.MedicineQuantity,
    //    row.MedicineQuantityPres,
    //    row.MedicineUnits,
    //    row.MedicineUnitsType,
    //    row.MedicineDosQuan,
    //    row.MedicineDosUnits,
    //    row.idSupplier,
    //    row.idSupplier
    //    );
    //to here
    //DataRow rw = pt2.NewRow();
    ////row2["MedicineName"] = row.MedicineName;
    ////pt2.Rows.Add(rw);

    //pt2.Rows.InsertAt(rw, 0);

    //
    // num++;
    //

    //(DataGridViewRow)ta.GetDataByIdMedicine((int)idM).Rows[0];
    //    (DataGridViewRow)dgvMedSelected.Rows[0].Clone();
    //}


    //else
    //{
    //    //dgvMedSelected.RowCount
    //    row2.MedicineName = row.MedicineName;
    //    row2.MedicineExpDate = row.MedicineExpDate;
    //    row2.MedicineQuantity = row.MedicineQuantity;
    //    row2.MedicineQuantityPres = row.MedicineQuantityPres;
    //    row2.MedicineUnits = row.MedicineUnits;
    //    row2.MedicineUnitsType = row.MedicineUnitsType;
    //    row2.MedicineDosQuan = row.MedicineDosQuan;
    //    row2.MedicineDosUnits = row.MedicineDosUnits;
    //    valorcillo = row.idSupplier;
    //    row2.idSupplier = row.idSupplier;

    //    dgvMedSelected.DataSource = pt2;


    //}
    /*//cuz you tas...
    DataGridViewRow rowie = new DataGridViewRow();
    // Adding Rows in datagridview2
    for (int i = 0; i < dgvMedSelected.Rows.Count; i++)
    {
        rowie = (DataGridViewRow)dgvMedSelected.Rows[i].Clone();
        int intColIndex = 0;
        foreach (DataGridViewCell cell in dgvMedicamento.Rows[i].Cells)
        {
            rowie.Cells[intColIndex].Value = cell.Value;
            intColIndex++;
        }
        dgvMedSelected.Rows.Add(row);

    }*/






    //   {
    //foreach (DataGridViewRow r in dgvMedicamento.Rows)
    //{
    //dgvMedSelected.Rows.Add();
    //int index = dgvMedSelected.Rows.Count - 1;

    ////dgvMedSelected.DataSource = pt2;
    ////   row2.id_Medicine = row.id_Medicine.;

    //row2.MedicineName = row.MedicineName;
    //row2.MedicineExpDate = row.MedicineExpDate;
    //row2.MedicineQuantity = row.MedicineQuantity;
    //row2.MedicineQuantityPres = row.MedicineQuantityPres;
    //row2.MedicineUnits = row.MedicineUnits;
    //row2.MedicineUnitsType = row.MedicineUnitsType;
    //row2.MedicineDosQuan = row.MedicineDosQuan;
    //row2.MedicineDosUnits = row.MedicineDosUnits;
    //valorcillo = row.idSupplier;
    //row2.idSupplier = row.idSupplier;


    //DataSet1TableAdapters.SupplierTableAdapter tas = new DataSet1TableAdapters.SupplierTableAdapter();
    //DataSet1.SupplierDataTable pts = tas.GetDataByIdSupplier((int)valorcillo);


    //}

    //gets it
    //}



    //    else
    //    {
    //        MessageBox.Show("No hay registros");
    //    }




    //}
    //end gets it

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











/**/
    /**/
    //foreach (DataGridViewRow item in dgvMedicamento.Rows) {

    //  dgvMedSelected.Rows.Clear();
    //  if ((bool)item.Cells[0].Value == true) {
    //int n = dgvMedSelected.Rows.Add();
    //dgvMedSelected.Rows[n].Cells[0].Value = item.Cells[1];
    //dgvMedSelected.Rows[n].Cells[1].Value = item.Cells[2];
    //dgvMedSelected.Rows[n].Cells[2].Value = item.Cells[3];
    //dgvMedSelected.Rows[n].Cells[3].Value = item.Cells[4];
    //dgvMedSelected.Rows[n].Cells[4].Value = item.Cells[5];
    //dgvMedSelected.Rows[n].Cells[5].Value = item.Cells[6];
    //dgvMedSelected.Rows[n].Cells[6].Value = item.Cells[7];
    //dgvMedSelected.Rows[n].Cells[7].Value = item.Cells[8];
    //dgvMedSelected.Rows[n].Cells[8].Value = item.Cells[9];
    //dgvMedSelected.Rows[n].Cells[9].Value = item.Cells[10];

    //   }



    /*
    int? idM = GetIdMedicine();
    int valorcillo;
    int nuevo = 0;

    DataSet1TableAdapters.MedicineTableAdapter ta = new DataSet1TableAdapters.MedicineTableAdapter();
    DataSet1.MedicineDataTable pt = ta.GetDataByIdMedicine((int)idM);

    DataSet1.MedicineRow row = (DataSet1.MedicineRow)pt.Rows[0];
    MessageBox.Show(idM.ToString());

    DataSet1.MedicineDataTable pt2 = ta.GetDataByIdMedicine((int)idM);
    DataSet1.MedicineRow row2 = (DataSet1.MedicineRow)pt2.Rows[0];
    DataSet1.MedicineRow row3;
    //then you can copy the rows values one by one (working on the selectedrows collection)
    // MessageBox.Show(dgvMedicamento.Rows.Count.ToString());
    //

    //
    /*
    for (int fila = 0; fila < dgvMedicamento.Rows.Count; fila++)
   {
        for (int cells = 0; cells < dgvMedicamento.ColumnCount; cells++)
        {*/
    /*
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

/**/

    /**/
    //*********************//

    //MessageBox.Show(cells.ToString());

    //row2[cells]= row[cells.ToString()];
    //  row2.SetField(cells, row[cells.ToString()]);
    //        row2.ItemArray(row[cells.ToString()]);
    //  row3 = (DataSet1.MedicineRow)pt2.Rows[cells];//

    //.ItemArray.;
    // = row[cells.ToString()];
    //row[cells]
    //= dgvMedicamento.Rows[fila].Cells[cells].Value.ToString();
    /*       }
     }*/
    //   dgvMedSelected.DataSource = pt2;
    //  dgvMedSelected.SelectedRows[0].Cells[0].Value.ToString();
    //   nuevo++;

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
    //  }

    //private void btnQuitar_Click(object sender, EventArgs e)
    //{
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
    //}

    //private void cbxCargarTodo_CheckedChanged(object sender, EventArgs e)
    //    {
    //        Refresh();
    //    }

    //    private void btnLimpiarProd_Click(object sender, EventArgs e)
    //    {
    //        txtBuscarComp.Clear();
    //        Refresh();
    //    }


    //private void button1_Click(object sender, EventArgs e)
    //{
    //    //
    //    // Se define una lista temporal de registro seleccionados
    //    //
    //    List<DataGridViewRow> rowSelected = new List<DataGridViewRow>();

    //    //
    //    // Se recorre ca registro de la grilla de origen
    //    //
    //    foreach (DataGridViewRow row in dataGridView2.Rows)
    //    {
    //        //
    //        // Se recupera el campo que representa el checkbox, y se valida la seleccion
    //        // agregandola a la lista temporal
    //        //
    //        DataGridViewCheckBoxCell cellSelecion = row.Cells["Seleccion"] as DataGridViewCheckBoxCell;

    //        if (Convert.ToBoolean(cellSelecion.Value))
    //        {
    //            rowSelected.Add(row);
    //        }
    //    }

    //    //
    //    // Se agrega el item seleccionado a la grilla de destino
    //    // eliminando la fila de la grilla original
    //    //
    //    foreach (DataGridViewRow row in rowSelected)
    //    {
    //       // MessageBox.Show(row.Cells[0].Value.ToString());
    //        dataGridView3.Rows.Add(new object[] {false,
    //                                    row.Cells[1].Value,
    //                                    row.Cells[2].Value,
    //                                    row.Cells[3].Value,
    //                                    row.Cells[4].Value,
    //                                    row.Cells[5].Value,
    //                                    row.Cells[6].Value,
    //                                     row.Cells[7].Value,
    //                                    row.Cells[8].Value,
    //                                    row.Cells[9].Value,
    //                                    row.Cells[10].Value

    //        });

    //        dataGridView2.Rows.Remove(row);
    //    }
    //}//BTN1

    //private void button2_Click(object sender, EventArgs e)
    //    {

//            //
//            // Se define una lista temporal de registro seleccionados
//            //
//            List<DataGridViewRow> rowSelected = new List<DataGridViewRow>();

//            //
//            // Se recorre cada fila de la grilla de seleccion y se determian que registros estan checkeados
//            //
//            foreach (DataGridViewRow row in dataGridView3.Rows)
//            {
//                DataGridViewCheckBoxCell cellSelecion = row.Cells["Selecciona"] as DataGridViewCheckBoxCell;

//                if (Convert.ToBoolean(cellSelecion.Value))
//                {
//                    rowSelected.Add(row);
//                }
//            }

//            //
//            // Se valida si hay algun registro por eliminar
//            //
//            if (rowSelected.Count > 0)
//            {
//                //
//                // Se recupera el origen de datos que tiene asignada la grilla de productos
//                //
//                              //   dtoProductos datos = dgvProductos.DataSource as dtoProductos;
//                DataSet1 datoi = dataGridView2.DataSource as DataSet1;
//                //
//                /**/
//                //this
//                DataSet1TableAdapters.MedicineTableAdapter dataSet = new DataSet1TableAdapters.MedicineTableAdapter();
//                DataSet1.MedicineDataTable pt3 = dataSet.GetDataMedicine();


                
               
//                //to this
//                /**/
//                //
//                // Se recorre cada item seleccionado y se arma programaticamente la fila del DataTable
//                // se elimina el registro de la grilla de selecciones
//                //
//                foreach (DataGridViewRow row in rowSelected)
//                {

//                   // MessageBox.Show("and all that jazz");
//                    // dtoProductos.ProductosRow productoRow = datos.Productos.NewProductosRow();
//                    // datoi.Medicine.NewMedicineRow productoRow = datoi.Medicine.NewMedicineRow();
//                                     //  DataSet1.MedicineRow medicineRow = datoi.Medicine.NewMedicineRow();
//                    //
//                    //DataSet1TableAdapters.MedicineTableAdapter ta = new DataSet1TableAdapters.MedicineTableAdapter();
//                    //DataSet1.MedicineDataTable pt = ta.GetDataByIdMedicine((int)idM);

//                    //DataSet1.MedicineRow row = (DataSet1.MedicineRow)pt.Rows[0];
//                    //MessageBox.Show(idM.ToString());

//                    //DataSet1.MedicineDataTable pt2 = ta.GetDataByIdMedicine((int)idM);
//                    //DataSet1.MedicineRow row2 = (DataSet1.MedicineRow)pt2.Rows[0];
//                    DataSet1.MedicineRow row3;
//               //     row3 = (DataSet1.MedicineRow)pt3.Rows[0];
//                    row3 = pt3.NewMedicineRow();

//                    //
//                    //medicineRow.id_Medicine = Convert.ToInt32(row.Cells[1].Value);
//                    //medicineRow.MedicineName = Convert.ToString(row.Cells[2].Value);
//                    //medicineRow.MedicineExpDate = Convert.ToDateTime(row.Cells[3].Value);
//                    //medicineRow.MedicineQuantity = Convert.ToInt32(row.Cells[4].Value);
//                    //medicineRow.MedicineQuantityPres = Convert.ToString(row.Cells[5].Value);
//                    //medicineRow.MedicineUnits = Convert.ToDecimal(row.Cells[6].Value);
//                    //medicineRow.MedicineUnitsType = Convert.ToString(row.Cells[7].Value);
//                    //medicineRow.MedicineDosQuan = Convert.ToDecimal(row.Cells[8].Value);
//                    //medicineRow.MedicineDosUnits = Convert.ToDecimal(row.Cells[9].Value);
//                    //medicineRow.idSupplier= Convert.ToInt32(row.Cells[10].Value);
//                    //living in

//                  //  row3.id_Medicine = Convert.ToInt32(row.Cells[1].Value);
//                    row3.MedicineName = Convert.ToString(row.Cells[2].Value);
//                    row3.MedicineQuantity = Convert.ToInt32(row.Cells[3].Value);
//                    row3.MedicineUnits = Convert.ToDecimal(row.Cells[4].Value);
//                    row3.MedicineDosQuan = Convert.ToDecimal(row.Cells[5].Value);
//                    row3.MedicineDosUnits = Convert.ToDecimal(row.Cells[6].Value);
//                    row3.MedicineExpDate = Convert.ToDateTime(row.Cells[7].Value);
//                    row3.idSupplier = Convert.ToInt32(row.Cells[8].Value);
//                    row3.MedicineUnitsType = Convert.ToString(row.Cells[9].Value);
//                    row3.MedicineQuantityPres = Convert.ToString(row.Cells[10].Value);

//                    //    row3.MedicineQuantity = Convert.ToInt32(row.Cells[4].Value);
//                   // row3.MedicineQuantityPres = Convert.ToString(row.Cells[5].Value);
//                 //   row3.MedicineUnits = Convert.ToDecimal(row.Cells[6].Value);
//                  //  row3.MedicineUnitsType = Convert.ToString(row.Cells[7].Value);
//                  //  row3.MedicineDosQuan = Convert.ToDecimal(row.Cells[8].Value);
//                  //  row3.MedicineDosUnits = Convert.ToDecimal(row.Cells[9].Value);
//                  //  row3.idSupplier = Convert.ToInt32(row.Cells[10].Value);
//                    //beverlyhills
//                    //  datoi.Medicine.Rows.Add(medicineRow);
//// pt3.Rows.Add(row3);//THIS LINE WAS HERE FOR SOME REASON .. DO NOT REMOVE
//                          // Rows.Add(medicineRow); 
//                    dataGridView3.Rows.Remove(row);
              
//                }

//                //
//                // Se binden los datos nuevamente, pero ahora con los nuevos registros
//                // agregados del paso anterior
//                //
//                dataGridView2.AutoGenerateColumns = false;
//                // dataGridView2.DataSource = datoi;
//      dataGridView2.DataSource = pt3;
//                //     dataGridView3.DataMember = "Productos";
//            }
       // }


    
   

}