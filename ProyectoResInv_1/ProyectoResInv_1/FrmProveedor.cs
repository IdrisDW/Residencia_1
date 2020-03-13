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
    public partial class FrmProveedor : Form
    {

        int idd;
        private int? id;
        private string SupplierName = "";

        //
        public FrmProveedor(int? id = null, string SupplierName = "")
        {
            InitializeComponent();
            this.id = id;
            this.SupplierName = SupplierName;
        }

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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
          


        }

        private void metodo1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Formato Incorrecto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtBusquedaProv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (checkBox1.Checked ) {
                //
                try
                {
                    DataSet1TableAdapters.SupplierTableAdapter ta = new DataSet1TableAdapters.SupplierTableAdapter();
                    DataSet1.SupplierDataTable dt = ta.GetDataByBuscarIDProveedor(txtBusquedaProv.Text);
                        //ta.GetDataByIdSupplier(txtBusquedaProv.Text);


                    ta.FillByBuscarIDProveedor( dt,txtBusquedaProv.Text);
                     

                    dataGridView1.DataSource = dt;

                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //
            }
            else {
                try
                {
                    DataSet1TableAdapters.SupplierTableAdapter ta = new DataSet1TableAdapters.SupplierTableAdapter();
                    DataSet1.SupplierDataTable dt = ta.GetDataByFilteringSupplier(txtBusquedaProv.Text);


                    ta.FillByFilteringSupplier(dt, txtBusquedaProv.Text);


                    dataGridView1.DataSource = dt;

                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            //
            /*
            try
            {
                DataSet1TableAdapters.SupplierTableAdapter ta = new DataSet1TableAdapters.SupplierTableAdapter();
                DataSet1.SupplierDataTable dt = ta.GetDataByFilteringSupplier(txtBusquedaProv.Text);


                ta.FillByFilteringSupplier(dt, txtBusquedaProv.Text);


                dataGridView1.DataSource = dt;

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/

        }

        private void cbxCargarTodo_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            DataSet1TableAdapters.SupplierTableAdapter ta =
                new DataSet1TableAdapters.SupplierTableAdapter();

            DataSet1.SupplierDataTable dt = ta.GetDataSupplier();

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "Nombre";

        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusquedaProv.Clear();
            Refresh();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(idd.ToString());
            DataSet1TableAdapters.SupplierTableAdapter ta = new DataSet1TableAdapters.SupplierTableAdapter();
            MessageBox.Show(idd.ToString());
            if (string.IsNullOrWhiteSpace(txtNombre.Text))


            {

                MessageBox.Show("Verifique que todos los campos hayan sido llenados correctamente");
            }


            else
            if (idd == 0)
            {
                ta.InsertQuerySupplier(txtNombre.Text.Trim());
                txtNombre.Clear();

                idd = 0;
                Refresh();

            }
            else
            {
                ta.UpdateQuerySupplier(txtNombre.Text.Trim(), (int)idd);
                txtNombre.Clear();

                idd = 0;

                Refresh();
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
            DialogResult result = MessageBox.Show(message, title, buttons);
            //
            int? id = GetId();

            if (result == DialogResult.Yes)
            {
                if (id != null)
                {
                    DataSet1TableAdapters.SupplierTableAdapter ta = new DataSet1TableAdapters.SupplierTableAdapter();
                    try
                    {
                        ta.DeleteQuerySupplier((int)id);
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

        private void btnEditar_Click(object sender, EventArgs e)
        {

            int? id = GetId();
            MessageBox.Show(id.ToString());
            if (id != null)
            {
                DataSet1TableAdapters.SupplierTableAdapter ta = new DataSet1TableAdapters.SupplierTableAdapter();
                DataSet1.SupplierDataTable pt = ta.GetDataByIdSupplier((int)id);

                DataSet1.SupplierRow row = (DataSet1.SupplierRow)pt.Rows[0];
                txtNombre.Text = row.SupplierName;


            }
        }

         
    }
}
