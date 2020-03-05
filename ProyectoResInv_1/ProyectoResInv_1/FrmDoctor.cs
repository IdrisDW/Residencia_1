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
    public partial class FrmDoctor : Form
    {


        private int? id;
        private string DoctorName = "", DoctorLastName = "";
        public FrmDoctor(int? id = null, string DoctorName = "", string DoctorLastName = "")
        {
            InitializeComponent();
            this.id = id;
            this.DoctorName = DoctorName;
            this.DoctorLastName = DoctorLastName;
        }


        private void Refresh() {
            DataSet1TableAdapters.DoctorTableAdapter ta =
                new DataSet1TableAdapters.DoctorTableAdapter();

            DataSet1.DoctorDataTable dt = ta.GetDataDoctor();

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[2].HeaderText = "Apellido";
        }


        private void FrmDoctor_Load(object sender, EventArgs e)
        {

            Refresh();

            /* Refresh();
             if (id != null) {
                 DataSet1TableAdapters.DoctorTableAdapter ta =
               new DataSet1TableAdapters.DoctorTableAdapter();

                 DataSet1.DoctorDataTable dt = ta.GetDataByIdDoctor((int)id);
                 DataSet1.DoctorRow row = (DataSet1.DoctorRow)dt.Rows[0];

                 txtNombre.Text = row.DoctorName;
                 txtApellido.Text = row.DoctorLastName;


             }*/
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        int idd;
        private int? GetId() {
            try {
             //   MessageBox.Show("mensaje");
                idd = int.Parse(
                        dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()
                        );
                return int.Parse(
                    dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()
                    );

            }
            catch {
             //   MessageBox.Show("mensaje2");
                return null;
            }


        }
        string docName, docLastName;
        private int? GetDoctorName()
        {
            try
            {

                docName =
                         dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString()
                         ;
                return int.Parse(
                    dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString()
                    );

            }
            catch
            {

                return null;
            }


        }//getdoctorName

        private int? GetDoctorLastName()
        {
            try
            {

                docLastName =
                         dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString()
                         ;
                return int.Parse(
                    dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString()
                    );

            }
            catch
            {

                return null;
            }


        }//getdoctorLastName

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            MessageBox.Show(id.ToString());
            if (id != null)
            {
                DataSet1TableAdapters.DoctorTableAdapter ta = new DataSet1TableAdapters.DoctorTableAdapter();
                DataSet1.DoctorDataTable dt = ta.GetDataByIdDoctor((int)id);
                DataSet1.DoctorRow row = (DataSet1.DoctorRow)dt.Rows[0];

                txtNombre.Text = row.DoctorName;
                txtApellido.Text = row.DoctorLastName;
            }


        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(idd.ToString());
            DataSet1TableAdapters.DoctorTableAdapter ta = new DataSet1TableAdapters.DoctorTableAdapter();
            MessageBox.Show(idd.ToString());
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
            {

                MessageBox.Show("Verifique que ningun campo este vacio");
            }


            else
            if (idd == 0)
            {
                ta.InsertQueryDoctor(txtNombre.Text.Trim(), txtApellido.Text.Trim());
                txtNombre.Clear();
                txtApellido.Clear();
                idd = 0;

            }
            else
            {
                ta.UpdateQueryDoctor(txtNombre.Text.Trim(), txtApellido.Text.Trim(), (int)idd);
                txtNombre.Clear();
                txtApellido.Clear();
                idd = 0;
            }

            // this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            string message = "Estas seguro que desea eliminar este registro?";
            string title = "Advertencia";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            //
            int? id = GetId();

            if (result == DialogResult.Yes)
            {
                if (id != null)
                {
                    DataSet1TableAdapters.DoctorTableAdapter ta = new DataSet1TableAdapters.DoctorTableAdapter();
                    try
                    {
                        ta.DeleteQueryDoctor((int)id);
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

                //


                //  ta.DeleteQueryDoctor((int)id);

            
        }
    

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            /*  if ((e.KeyChar >= 33 && e.KeyChar <= 64 || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 163) || (e.KeyChar >= 166 && e.KeyChar <=255))) {
                  MessageBox.Show("Solo letras","Advertencia",MessageBoxButtons.OK , MessageBoxIcon.Exclamation);

                  e.Handled = true;
                  return;
              }*/
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten Letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
         //   else if (e.KeyChar == (char)Keys.Tab)
          //  {
            //    txtApellido.Focus();
            //}
        }

        private void cbxCargarTodo_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void txtBuscarDoctor_TextChanged(object sender, EventArgs e)
        {
           

            //
              //  DataSet1TableAdapters.DoctorTableAdapter ta = new DataSet1TableAdapters.DoctorTableAdapter();

               // MessageBox.Show(ta.Equals(" SELECT * FROM DOCTOR WHERE doctorName LIKE '%" + txtBuscarDoctor + "%' +OR doctorLastName LIKE '%" + txtBuscarDoctor + "%'   ").ToString());
                //dataGridView1.DataSource = ta.Equals(" SELECT * FROM DOCTOR WHERE doctorName LIKE '%" + txtBuscarDoctor + "%' +OR doctorLastName LIKE '%" + txtBuscarDoctor + "%'   ");
                //


                // DataSet1.DoctorDataTable dt = ta.GetDataDoctor();

                // dataGridView1.DataSource = dt;

                /*

                    DataView dv;
                    dv = new DataView(ds.Tables[0], "type = 'business' ", "type Desc", DataViewRowState.CurrentRows);
                    dataGridView1.DataSource = dv;

                 */
                /*
               DataSet1TableAdapters.DoctorTableAdapter ta = new DataSet1TableAdapters.DoctorTableAdapter();
               dataGridView1 = new dataGridView1(ta);

               //from here
               string dataOutput = "";
               string[] busqueda = this.txtBuscarDoctor.Text.Split(' ');

               foreach (string palabra in busqueda) {
                   if (dataOutput.Length == 0)
                   {
                       dataOutput = "(DoctorName LIKE '%" + palabra + "%' OR DoctorLastName LIKE '%" + palabra + "%')";
                   }
                   else {
                       dataOutput += " AND (DoctorName LIKE '%" + palabra + "%' OR DoctorLastName LIKE '%" + palabra + "%')";
                   }
               }*/
            
            }

        private void txtBuscarDoctor_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            try
            {
                DataSet1TableAdapters.DoctorTableAdapter ta = new DataSet1TableAdapters.DoctorTableAdapter();
                DataSet1.DoctorDataTable dt = ta.GetDataByFilteringD(txtBuscarDoctor.Text, txtBuscarDoctor.Text);
                 
           //     DataSet1.DoctorRow row = (DataSet1.DoctorRow)dt.Rows[0];
                /**/

                //Cargamos el resultado en el DataTable
             //   ta.Fill(dt);
                ta.FillBy1FilteringD( dt, txtBuscarDoctor.Text,txtBuscarDoctor.Text);

                //Cargamos el DGV
                dataGridView1.DataSource = dt;


                /**/
                //    txtNombre.Text = row.DoctorName;
                //    txtApellido.Text = row.DoctorLastName;
                /*
                DataSet1TableAdapters.DoctorTableAdapter ta = new DataSet1TableAdapters.DoctorTableAdapter();
                DataSet1.DoctorDataTable dt = ta.GetDataByFilteringD(txtBuscarDoctor.Text, txtBuscarDoctor.Text);
                DataSet1.DoctorRow row = (DataSet1.DoctorRow)dt.Rows[0];
                txtNombre.Text = row.DoctorName;
                txtApellido.Text = row.DoctorLastName;
                */



            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtBuscarDoctor.Clear();
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
                {
                    MessageBox.Show("Solo se permiten Letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            
        }

        





        

        private void button2_Click(object sender, EventArgs e)
        {
             
              
            }
        }
}
