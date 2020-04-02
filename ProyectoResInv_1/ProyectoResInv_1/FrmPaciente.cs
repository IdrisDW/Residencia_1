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
    public partial class FrmPaciente : Form
    {
        int idd;
        private int? id;
        private string PatientName = "", PatientLastName = "", PatientEmail;
        public FrmPaciente(int? id = null, string PatientName = "", string PatientLastName = "", string PatientEmail = "")
        {
            InitializeComponent();
            this.id = id;
            this.PatientName = PatientName;
            this.PatientLastName = PatientLastName;
            this.PatientEmail = PatientEmail;
        }

        private void FrmPaciente_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void cbxCargarTodo_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodo1(sender,e);
        }

        private void metodo1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten Letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void metodo2(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && (txtEmail.Text.Contains('@') ))
            {
                MessageBox.Show("Solo se permiten Letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        //
        private void metodo3(object sender, KeyPressEventArgs e)
        {
            // if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && (txtEmail.Text.Contains('@')))
            if (!(e.KeyChar != (char)Keys.Space))

            {
                MessageBox.Show("Formato incorrecto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

     



        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodo1(sender,e);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodo3(sender,e);
        }

        private void cbxCargarTodo_CheckedChanged_1(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtBuscarPac.Clear();
            Refresh();
        }
        
        private int? GetId()
        {
            try
            {
                //   MessageBox.Show("mensaje");
                idd = int.Parse(
                        dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()
                        );
                return int.Parse(
                    dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()
                    );

            }
            catch
            {
                //   MessageBox.Show("mensaje2");
                return null;
            }


        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            //MessageBox.Show(id.ToString());
            if (id != null)
            {
                DataSet1TableAdapters.PatientTableAdapter ta = new DataSet1TableAdapters.PatientTableAdapter();
                DataSet1.PatientDataTable pt = ta.GetDataByIdPatient((int)id);

                DataSet1.PatientRow row = (DataSet1.PatientRow)pt.Rows[0];
                txtNombre.Text = row.patientName;
                txtApellido.Text = row.patientLastName;
                txtEmail.Text = row.patientEmail;


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
                        DataSet1TableAdapters.PatientTableAdapter ta = new DataSet1TableAdapters.PatientTableAdapter();
                        try
                        {
                            ta.DeleteQueryPatient((int)id);
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

        private void txtBuscarPac_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {
                DataSet1TableAdapters.PatientTableAdapter ta = new DataSet1TableAdapters.PatientTableAdapter();
                DataSet1.PatientDataTable dt = ta.GetDataByFilteringP(txtBuscarPac.Text,txtBuscarPac.Text,txtBuscarPac.Text );


                ta.FillBy1FilteringP(dt, txtBuscarPac.Text, txtBuscarPac.Text,txtBuscarPac.Text);


                dataGridView1.DataSource = dt;

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

            private void Refresh()
        {
            DataSet1TableAdapters.PatientTableAdapter ta =
                new DataSet1TableAdapters.PatientTableAdapter();

            DataSet1.PatientDataTable dt = ta.GetDataPatient();

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[2].HeaderText = "Apellido";
            dataGridView1.Columns[3].HeaderText = "Email";
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {


            MessageBox.Show(idd.ToString());
            DataSet1TableAdapters.PatientTableAdapter ta = new DataSet1TableAdapters.PatientTableAdapter();
            MessageBox.Show(idd.ToString());
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || 
                string.IsNullOrWhiteSpace(txtEmail.Text) || (!(txtEmail.Text.Contains('@'))) || (!(txtEmail.Text.Contains('.')))
                   
                   
                    
                    )
            {

                MessageBox.Show("Verifique que todos los campos hayan sido llenados correctamente");
            }


            else
            if (idd == 0)
            {
                ta.InsertQueryPatient(txtNombre.Text.Trim(), txtApellido.Text.Trim(),txtEmail.Text.Trim());
                txtNombre.Clear();
                txtApellido.Clear();
                txtEmail.Clear();
                idd = 0;
                Refresh();

            }
            else
            {
                ta.UpdateQueryPatient(txtNombre.Text.Trim(), txtApellido.Text.Trim(), txtEmail.Text.Trim(), (int)idd);
                txtNombre.Clear();
                txtApellido.Clear();
                txtEmail.Clear();
                idd = 0;
                Refresh();

            }
        }
    }
}
