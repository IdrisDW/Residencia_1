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
        public FrmDoctor(int? id = null)
        {
            InitializeComponent();
            this.id = id;
        }


        private void Refresh() {
            DataSet1TableAdapters.DoctorTableAdapter ta =
                new DataSet1TableAdapters.DoctorTableAdapter();

            DataSet1.DoctorDataTable dt = ta.GetDataDoctor();

            dataGridView1.DataSource = dt;


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
                MessageBox.Show("mensaje");
            idd=    int.Parse(
                    dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()
                    );
                return int.Parse(
                    dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()
                    );

            }
            catch {
                MessageBox.Show("mensaje2");
                return null;
            }


        }

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
            MessageBox.Show( idd.ToString());
            DataSet1TableAdapters.DoctorTableAdapter ta = new DataSet1TableAdapters.DoctorTableAdapter();
            MessageBox.Show( idd.ToString());
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
            {

                MessageBox.Show("Verifique que ningun campo este vacio");
            }


            else
            if (idd == null)
            {
                ta.InsertQueryDoctor(txtNombre.Text.Trim(), txtApellido.Text.Trim());


            }
            else
            {
                ta.UpdateQueryDoctor(txtNombre.Text.Trim(), txtApellido.Text.Trim(), (int)idd);
            }

            // this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null) {
                DataSet1TableAdapters.DoctorTableAdapter ta = new DataSet1TableAdapters.DoctorTableAdapter();
                ta.DeleteQueryDoctor((int)id);
            }
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

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
                {
                    MessageBox.Show("Solo se permiten Letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            
        }
    }
}
