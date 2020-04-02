using System;
using System.Windows.Forms;

namespace ProyectoResInv_1.Agenda
{
    public partial class FrmDoctores : Form
    {
        public FrmDoctores()
        {
            InitializeComponent();
        }
        internal static string variableCompartida;
        internal static int? varId;
        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            varId = GetId();
            //if (id != null)
            //{
            //    MessageBox.Show("Aqui " + id);
            //}

            FrmAgendaDoctor agendaD = new FrmAgendaDoctor();
            agendaD.ShowDialog();
            this.Show();
           
        }

        private void FrmDoctores_Load(object sender, EventArgs e)
        {
            //CARGAR ENVIO DE CORREOS
            Notificar notify = new Notificar();
            notify.ObtenerCorreos();

            //MOSTRAR DOCTORES
            dsAnalisisResidenciaTableAdapters.DoctorTableAdapter ta =
                new dsAnalisisResidenciaTableAdapters.DoctorTableAdapter();
            dsAnalisisResidencia.DoctorDataTable dt = ta.GetData();
            comboxDoctores.DataSource = dt;
            comboxDoctores.ValueMember = "id_Doctor";//columna que se guardará
           comboxDoctores.DisplayMember = "DoctorName"; //columna que desees mostrar en el combo

        }

        private void ComboxDoctores_SelectedIndexChanged(object sender, EventArgs e)
        {
            //pasar nombre de la seleccionada
            if (comboxDoctores.SelectedValue != null)
            {
                variableCompartida = comboxDoctores.Text;

            }
        }

        private int? GetId()
        {
            try
            {
                return int.Parse(comboxDoctores.SelectedValue.ToString());
            }
            catch
            {
                return null;
            }
        }



    }
}
