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
        public FrmDoctor(int? id=null)
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.DoctorTableAdapter ta_doctor = new DataSet1TableAdapters.DoctorTableAdapter();
            ta_doctor.InsertQueryDoctor(txtNombre.Text.Trim(), txtApellido.Text.Trim());
         
            // this.Close();
        }

        private void FrmDoctor_Load(object sender, EventArgs e)
        {
         //   Refresh();
            if (id != null) {
                DataSet1TableAdapters.DoctorTableAdapter ta =
              new DataSet1TableAdapters.DoctorTableAdapter();

              DataSet1.DoctorDataTable dt=  ta.GetDataByIdDoctor((int)id);
                DataSet1.DoctorRow row = (DataSet1.DoctorRow)dt.Rows[0];

                txtNombre.Text = row.DoctorName;
                txtApellido.Text = row.DoctorLastName;


            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private int? GetId() {
            try {
                return int.Parse(
                    dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()
                    );

            }
            catch   {
                return null;
            }


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.DoctorTableAdapter ta = new DataSet1TableAdapters.DoctorTableAdapter();
            if (id == null)
            {
                ta.InsertQueryDoctor(txtNombre.Text.Trim(), txtApellido.Text.Trim());


            }
            else
            {
                ta.UpdateQueryDoctor(txtNombre.Text.Trim(), txtApellido.Text.Trim(), (int)id);
            }
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null) {
                DataSet1TableAdapters.DoctorTableAdapter ta = new DataSet1TableAdapters.DoctorTableAdapter();
                ta.DeleteQueryDoctor((int)id);
            }
        }
    }
}
