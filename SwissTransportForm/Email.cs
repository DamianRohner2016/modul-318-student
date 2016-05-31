using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace SwissTransportForm
{
    public partial class Email : Form
    {
        Mainform meltern;
        
        public Email( Mainform Eltern )
        {
            meltern = Eltern;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string absender = "dok514testmail@gmail.com";
            string empfaenger = adresse.Text;
            string betreff = betreff1.Text;
            string nachricht = textbox21.Text;
            string server = "smtp.gmail.com";
            int port = 587;
            string user = "dok514testmail@gmail.com";
            string passwort = "wasserfall";

            foreach (ListViewItem Item in meltern.Listview_Verbindungen.Items)
            {
                nachricht += Environment.NewLine;
                foreach (ListViewItem.ListViewSubItem subitem in Item.SubItems)
                {
                    nachricht += subitem.Text + "|";
                }
            }

            foreach (ListViewItem Item in meltern.Listview_Station.Items)
            {

            }

           sendMail( absender, empfaenger, betreff, nachricht, server, port, user, passwort);

            
        }

        public void sendMail(string absender, string empfaenger,
                              string betreff, string nachricht,
                              string server, int port,
                              string user, string passwort)
        {
            MailMessage Email = new MailMessage();

            //Absender
            Email.From = new MailAddress(absender);

            //Zieladresse
            Email.To.Add(empfaenger);

            //Betreff
            Email.Subject = betreff;

            //Nachricht
            Email.Body = nachricht;

            //Ausgangsserver
            SmtpClient MailClient = new SmtpClient(server, port);

            if (user.Length > 0 && user != string.Empty)
            {
                //Login konfigurieren
                MailClient.Credentials = new System.Net.NetworkCredential(user, passwort);
                MailClient.EnableSsl = true;
            }

            //Email absenden
            MailClient.Send(Email);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            meltern.tabControl1.Visible = true;

            this.Close();

        }
    }
}
