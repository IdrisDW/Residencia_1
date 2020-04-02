using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace ProyectoResInv_1.Agenda
{
    class Notificar
    {
        public List<string> Users = new List<string>();
        public List<string> Emails = new List<string>();
        //datos?
        public List<string> Nombre = new List<string>();
        public List<string> Apellido = new List<string>();
        public List<string> Hora = new List<string>();


        public Notificar() {
            this.Observers = new List<object>(); 
        }

        private List<object> Observers { get; set; }


        public void ObtenerCorreos()
        {
            try
            {
                dsAnalisisResidenciaTableAdapters.ReservationTTableAdapter rta = 
                 new dsAnalisisResidenciaTableAdapters.ReservationTTableAdapter();

                dsAnalisisResidencia.ReservationTDataTable tableR = 
                rta.idPatient_Email(DateTime.Today.Day, DateTime.Today.Month, DateTime.Today.Year);

                for (int i = 0; i < tableR.Rows.Count; i++)     {
                    Users.Add(tableR.Rows[i]["idPatient"].ToString());
                    
                    Hora.Add(tableR.Rows[i]["ResStartTime"].ToString());
                }
               
               
                dsAnalisisResidenciaTableAdapters.PatientTableAdapter pta = 
                 new dsAnalisisResidenciaTableAdapters.PatientTableAdapter();

                dsAnalisisResidencia.PatientDataTable tableP;

                for (int i = 0; i < Users.Count; i++)   {
                    tableP = pta.GetEmailP(Convert.ToInt32(Users[i]));
                    for (int j = 0; j < tableP.Rows.Count; j++)     {
                        Emails.Add(tableP.Rows[j]["patientEmail"].ToString());
                        Nombre.Add(tableP.Rows[j]["patientName"].ToString());
                        Apellido.Add(tableP.Rows[j]["patientLastName"].ToString());
                    }
                }
                   Notify();
                
            }
            catch (Exception ex)
            {   }

            }



        //NOTIFICAR
        public void Notify()
        {
            int data=0;
            foreach (var user in Emails)
            {
                if (ValidarCorreo(user))
                {
                    EnviarCorreo(user,data);
                }
                data++;
            }

        }

        public bool ValidarCorreo(string correo)
        {
            try  {
                //Instancia a la clase MailAddress de libreria, recibe como valor un string
                MailAddress m = new MailAddress(correo);
                return true;
            }
            catch (FormatException)     {
                return false;
            }
        }

        public void EnviarCorreo(string correo,int data)
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress("mediobilogica.clinica@gmail.com");
            message.To.Add(correo);
            message.Subject = "Clinica Mediobiologica - Recordatorio de cita";
            message.Body = "Buen día, " + Nombre[data] +" "+ Apellido[data]
            +" le recordamos que su cita es hoy " + DateTime.Today.Day + "/"+ DateTime.Today.Month + "/"+ DateTime.Today.Year
            + " hora " + " " + Hora[data] + "."; //aviso
            //Agrega al correo un archivo PDF para enviar.
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("mediobilogica.clinica@gmail.com", "+X73_5RT!yrV"),
                EnableSsl = true
            };

            try
            {
                client.Send(message);
            }
            catch (Exception)
            {

            }
        }

    }
}
