using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoResInv_1.Agenda
{
    public partial class FrmCitaResumen : Form
    {
        public FrmCitaResumen()
        {
            InitializeComponent();
        }

        private int? varIdP;
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //dsAnalisisResidenciaTableAdapters.PatientTableAdapter pta =
            //    new dsAnalisisResidenciaTableAdapters.PatientTableAdapter();
            //    varIdP = pta.ObtPatient();


            //dsAnalisisResidenciaTableAdapters.ReservationTTableAdapter rta =
            //    new dsAnalisisResidenciaTableAdapters.ReservationTTableAdapter();
            //rta.AddReservation(FrmDoctores.varId,varIdP, txtHinicioC.Text, txtHfinC.Text, txtFecha.Text);

            this.Close();
        }

        private void FrmCitaResumen_Load(object sender, EventArgs e)
        {
            txtNombreC.Text = FrmCita.varnombre;
            txtApellidoC.Text = FrmCita.varapellido;
            txtEmailC.Text = FrmCita.varemail;
            txtFecha.Text = FrmAgendaDoctor.vCompartidaFecha;
            txtHinicioC.Text = FrmAgendaDoctor.vCompartidaHinicio;
            txtHfinC.Text = FrmAgendaDoctor.vCompartidaHfin;
        }
    }
}
