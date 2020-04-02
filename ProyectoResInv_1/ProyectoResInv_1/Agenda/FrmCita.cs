using System;
using System.Windows.Forms;

namespace ProyectoResInv_1.Agenda
{
    public partial class FrmCita : Form
    {
        private int? idEdit;
        public FrmCita(int? idEdit=null)
        {
            InitializeComponent();
            this.idEdit = idEdit;
        }
        

        private int? varIdDR, varIdPR;
        private int idCurrent;
        internal static string varnombre;
        internal static string varapellido;
        internal static string varemail;
        private void FrmCita_Load(object sender, EventArgs e)
        {
            if(idEdit!= null)
            {


                dsAnalisisResidenciaTableAdapters.ReservationTTableAdapter rta =
                new dsAnalisisResidenciaTableAdapters.ReservationTTableAdapter();
                dsAnalisisResidencia.ReservationTDataTable dtr = rta.GetDataIdOpR((int)idEdit);
                dsAnalisisResidencia.ReservationTRow row = (dsAnalisisResidencia.ReservationTRow)dtr.Rows[0];
                txtHinicioC.Text = Convert.ToString(row.ResStartTime);
                txtHfinC.Text = Convert.ToString(row.ResFinishTime);
                txtFecha.Text = row.ResDate.ToShortDateString();


                idCurrent = Convert.ToInt32(rta.idPatient_fromReservation(idEdit));

                dsAnalisisResidenciaTableAdapters.PatientTableAdapter pta =
                new dsAnalisisResidenciaTableAdapters.PatientTableAdapter();
                dsAnalisisResidencia.PatientDataTable dtp = pta.GetDataIdOp((int)idCurrent);
                dsAnalisisResidencia.PatientRow row1 = (dsAnalisisResidencia.PatientRow)dtp.Rows[0];
                txtNombreC.Text = row1.patientName;
                txtApellidoC.Text = row1.patientLastName;
                txtEmailC.Text = row1.patientEmail;

            }
            else { 
            txtFecha.Text = FrmAgendaDoctor.vCompartidaFecha;
            txtHinicioC.Text = FrmAgendaDoctor.vCompartidaHinicio;
            txtHfinC.Text = FrmAgendaDoctor.vCompartidaHfin;
            txtFecha.ReadOnly = true;
            txtHinicioC.ReadOnly = true;
            txtHfinC.ReadOnly = true;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //Guardar en la B.D
            //patient
            dsAnalisisResidenciaTableAdapters.PatientTableAdapter pta =
            new dsAnalisisResidenciaTableAdapters.PatientTableAdapter();
            
            //nuevo
            if (idEdit == null) {
            pta.AddPatient(txtNombreC.Text, txtApellidoC.Text, txtEmailC.Text);
            varIdPR = Convert.ToInt32(pta.ObtPatient());
            //Reservation

            varnombre = txtNombreC.Text;
            varapellido = txtApellidoC.Text;
            varemail = txtEmailC.Text;

            varIdDR = FrmDoctores.varId;
            dsAnalisisResidenciaTableAdapters.ReservationTTableAdapter rta =
            new dsAnalisisResidenciaTableAdapters.ReservationTTableAdapter();
            
            rta.AddReservation(varIdDR, varIdPR,txtHinicioC.Text,txtHfinC.Text,txtFecha.Text);
            }

            //editar
            else
            {
                dsAnalisisResidenciaTableAdapters.ReservationTTableAdapter rta =
            new dsAnalisisResidenciaTableAdapters.ReservationTTableAdapter();

                idCurrent = Convert.ToInt32(rta.idPatient_fromReservation(idEdit));
                //paciente
                pta.EditPatient(txtNombreC.Text, txtApellidoC.Text, txtEmailC.Text, idCurrent);
                //reservacion
                rta.EditReservation(txtHinicioC.Text, txtHfinC.Text, txtFecha.Text, (int)idEdit);

            }
            this.Close();
            //FrmCitaResumen confirm = new FrmCitaResumen();
            //confirm.ShowDialog();
            //this.Show();
            
        }
    }
}
