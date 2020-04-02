using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProyectoResInv_1.Agenda
{
    public partial class FrmAgendaDoctor : Form
    {
 
        public FrmAgendaDoctor()
        {
            InitializeComponent();
        }
        private int? varIdD;

        internal static string vCompartidaFecha;
        internal static string vCompartidaHinicio;
        internal static string vCompartidaHfin;
        
        private void BtnBuscarMaterial_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(vCompartidaFecha))
            { MessageBox.Show("Debe escoger una fecha del calendario"); }
            if (string.IsNullOrEmpty(vCompartidaHinicio) || string.IsNullOrEmpty(vCompartidaHfin))
            { MessageBox.Show("Debe escoger una Hora"); }

            else { 
            FrmCita citaD = new FrmCita();
            citaD.ShowDialog();
            this.Show();
            }

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {   }

        private void FrmAgendaDoctor_Load(object sender, EventArgs e)
        {
            dataGViewReservation.ReadOnly = true;
            dataGViewReservation.MultiSelect = false;
            Update();
        }
        public void Update()
        {
            lblName.Text = FrmDoctores.variableCompartida;
            //Cargar Reservaciones
            dsAnalisisResidenciaTableAdapters.ReservationTTableAdapter rta =
                new dsAnalisisResidenciaTableAdapters.ReservationTTableAdapter();

            varIdD = FrmDoctores.varId;

            dsAnalisisResidencia.ReservationTDataTable rdt = rta.Getdoc_ReservationT(varIdD);
            
            dataGViewReservation.DataSource = rdt;
        }

        private void MCalendarAgendaDoc_DateChanged(object sender, DateRangeEventArgs e)
        {
            //Limpiar color de boton
            limpia();
            //vCompartidaFecha = mCalendarAgendaDoc.SelectionRange.Start.ToShortDateString();
            vCompartidaFecha = mCalendarAgendaDoc.SelectionStart.ToString("yyyy/MM/dd");
            dsAnalisisResidenciaTableAdapters.ReservationTTableAdapter rta =
            new dsAnalisisResidenciaTableAdapters.ReservationTTableAdapter();
            bool estado;
            estado = Convert.ToBoolean(rta.existe_Fecha(Convert.ToDateTime(vCompartidaFecha), varIdD));
            //Verificar si existe cita ese dia
            if(estado == true)  {
            NDisponible();  }

        }
        public void limpia()
        {
            btnNueve.BackColor = SystemColors.ButtonFace;
            btnDiez.BackColor = SystemColors.ButtonFace;
            btnOnce.BackColor = SystemColors.ButtonFace;
            btnDoce.BackColor = SystemColors.ButtonFace;
            btnTrece.BackColor = SystemColors.ButtonFace;
            btnCatorce.BackColor = SystemColors.ButtonFace;
            btnQuince.BackColor = SystemColors.ButtonFace;
            btnDieciseis.BackColor = SystemColors.ButtonFace;
        }
        public void NDisponible()
        {
            //Verificar Horas ocupadas
            dsAnalisisResidenciaTableAdapters.ReservationTTableAdapter rtaH =
           new dsAnalisisResidenciaTableAdapters.ReservationTTableAdapter();
            TimeSpan ts;

            if ((Convert.ToBoolean(rtaH.existe_Hora(Convert.ToDateTime(vCompartidaFecha), varIdD, TimeSpan.Parse("9:00"), TimeSpan.Parse("10:00")))) == true)
            {
                btnNueve.BackColor = Color.Red;
               }
            if ((Convert.ToBoolean(rtaH.existe_Hora(Convert.ToDateTime(vCompartidaFecha), varIdD, TimeSpan.Parse("10:00"), TimeSpan.Parse("11:00")))) == true)
            {
                btnDiez.BackColor = Color.Red;  }
            if ((Convert.ToBoolean(rtaH.existe_Hora(Convert.ToDateTime(vCompartidaFecha), varIdD, TimeSpan.Parse("11:00"), TimeSpan.Parse("12:00")))) == true)
            {
                btnOnce.BackColor = Color.Red;   }
            if ((Convert.ToBoolean(rtaH.existe_Hora(Convert.ToDateTime(vCompartidaFecha), varIdD, TimeSpan.Parse("12:00"), TimeSpan.Parse("13:00")))) == true)
            {
                btnDoce.BackColor = Color.Red;    }
            if ((Convert.ToBoolean(rtaH.existe_Hora(Convert.ToDateTime(vCompartidaFecha), varIdD, TimeSpan.Parse("13:00"), TimeSpan.Parse("14:00")))) == true)
            {
                btnTrece.BackColor = Color.Red;     }
            if ((Convert.ToBoolean(rtaH.existe_Hora(Convert.ToDateTime(vCompartidaFecha), varIdD, TimeSpan.Parse("14:00"), TimeSpan.Parse("15:00")))) == true)
            {
                btnCatorce.BackColor = Color.Red;   }
            if ((Convert.ToBoolean(rtaH.existe_Hora(Convert.ToDateTime(vCompartidaFecha), varIdD, TimeSpan.Parse("16:00"), TimeSpan.Parse("17:00")))) == true)
            {
                btnQuince.BackColor = Color.Red;    }
            if ((Convert.ToBoolean(rtaH.existe_Hora(Convert.ToDateTime(vCompartidaFecha), varIdD, TimeSpan.Parse("17:00"), TimeSpan.Parse("18:00")))) == true)
            {
                btnDieciseis.BackColor = Color.Red;  }

        }

        private void BtnNueve_Click(object sender, EventArgs e)
        {
            //(vCompartidaFecha, varIdD, vCompartidaHinicio, vCompartidaHfin)
            vCompartidaHinicio = "9:00";
            vCompartidaHfin = "10:00";
            //btnNueve.Click += new EventHandler(this.BtnNueve_Click);
            if (btnNueve.BackColor.Equals(Color.Red)) 
            { MessageBox.Show("ERROR:\n Hora no disponible, favor de escoger otra."); }

        }

        private void BtnDiez_Click(object sender, EventArgs e)
        {
            vCompartidaHinicio = "10:00";
            vCompartidaHfin = "11:00";
            if (btnDiez.BackColor.Equals(Color.Red))
            { MessageBox.Show("ERROR:\n Hora no disponible, favor de escoger otra."); }
        }

        private void BtnOnce_Click(object sender, EventArgs e)
        {
            vCompartidaHinicio = "11:00";
            vCompartidaHfin = "12:00";
            if (btnOnce.BackColor.Equals(Color.Red))
            { MessageBox.Show("ERROR:\n Hora no disponible, favor de escoger otra."); }
        }

        private void BtnDoce_Click(object sender, EventArgs e)
        {
            vCompartidaHinicio = "12:00";
            vCompartidaHfin = "13:00";
            if (btnDoce.BackColor.Equals(Color.Red))
            { MessageBox.Show("ERROR:\n Hora no disponible, favor de escoger otra."); }
        }

        private void BtnTrece_Click(object sender, EventArgs e)
        {
            vCompartidaHinicio = "13:00";
            vCompartidaHfin = "14:00";
            if (btnTrece.BackColor.Equals(Color.Red))
            { MessageBox.Show("ERROR:\n Hora no disponible, favor de escoger otra."); }
        }

        private void BtnCatorce_Click(object sender, EventArgs e)
        {
            vCompartidaHinicio = "14:00";
            vCompartidaHfin = "15:00";
            if (btnCatorce.BackColor.Equals(Color.Red))
            { MessageBox.Show("ERROR:\n Hora no disponible, favor de escoger otra."); }
        }

        private void BtnQuince_Click(object sender, EventArgs e)
        {
            vCompartidaHinicio = "15:00";
            vCompartidaHfin = "16:00";
            if (btnQuince.BackColor.Equals(Color.Red))
            { MessageBox.Show("ERROR:\n Hora no disponible, favor de escoger otra."); }
        }

        private void BtnDieciseis_Click(object sender, EventArgs e)
        {
            vCompartidaHinicio = "16:00";
            vCompartidaHfin = "17:00";
            if (btnDieciseis.BackColor.Equals(Color.Red))
            { MessageBox.Show("ERROR:\n Hora no disponible, favor de escoger otra."); }
        }

        private void BtnActualiza_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void BtnElimina_Click(object sender, EventArgs e)
        {
            //Eliminar la cita y al usuario
            if (dataGViewReservation.CurrentRow == null)
                return;

            int id = Convert.ToInt32(dataGViewReservation.CurrentRow.Cells["id_Reservation"].Value);
            
            dsAnalisisResidenciaTableAdapters.ReservationTTableAdapter rta =
            new dsAnalisisResidenciaTableAdapters.ReservationTTableAdapter();

            int idPfromReserv=Convert.ToInt32(rta.idPatient_fromReservation(id));
            
            rta.ReservationT_Delete(id);
            rta.Patient_Delete(idPfromReserv);
            dataGViewReservation.Rows.Remove(dataGViewReservation.CurrentRow);



        }
        //obteber Id
        private int? GetId()
        {
            try {
                return int.Parse(
                    dataGViewReservation.Rows[dataGViewReservation.CurrentRow.Index].Cells[0].Value.ToString()
                );
            }   catch   {
                return null;
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int? idEdit = GetId();

            if (idEdit != null)
            {
                FrmCita frm = new FrmCita(idEdit);
                frm.ShowDialog();
                Update();
            }
        }


    }
}
