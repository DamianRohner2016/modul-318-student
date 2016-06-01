using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32;
using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransportForm
{
    public partial class Mainform : Form
    {
        
        public Mainform()
        {
            InitializeComponent();
        }

        //--//Verbindungen suchen//--//
        private void but_search_Click(object sender, EventArgs e)
        {

            //Destinationen Initialisieren
            var transport = new Transport();
            string Dest_1 = destination_from.Text;
            string Dest_2 = destination_to.Text;
            string time = time_from.Text;
            string date = date_con.Value.ToString("yyyy-MM-dd");

            if ( time != null)
            {

                var Listconnection = transport.GetDateTimeConnections(Dest_1, Dest_2, date, time);

                //Loop über Verbindungen
                foreach (Connection current in Listconnection.ConnectionList)
                {

                    //Fahrtdauer umformatieren
                    string loc_duration = current.Duration;
                    loc_duration = loc_duration.Remove(0, 6);
                    loc_duration = loc_duration.Remove(loc_duration.Length - 3, 3);

                    //Abfahrtzeit umformatieren
                    string dateTime = current.From.Departure;
                    DateTime dt = Convert.ToDateTime(dateTime);

                    //Liestview mit Daten befüllen
                    ListViewItem newconnection = new ListViewItem();
                    newconnection.Text = (current.From.Station.Name);
                    newconnection.SubItems.Add(current.To.Station.Name);
                    newconnection.SubItems.Add(loc_duration + " min");
                    newconnection.SubItems.Add(current.From.Platform);
                    newconnection.SubItems.Add(dt.Hour + ":" + dt.Minute);
                    Listview_Verbindungen.Items.Add(newconnection);


                }

            }else{


                //Verbindungsliste beschaffen
                var Listconnection = transport.GetConnections(Dest_1, Dest_2);

                //Loop über Verbindungen
                foreach (Connection current in Listconnection.ConnectionList)
                {

                    //Fahrtdauer umformatieren
                    string loc_duration = current.Duration;
                    loc_duration = loc_duration.Remove(0, 6);
                    loc_duration = loc_duration.Remove(loc_duration.Length - 3, 3);

                    //Abfahrtzeit umformatieren
                    string dateTime = current.From.Departure;
                    DateTime dt = Convert.ToDateTime(dateTime);

                    //Liestview mit Daten befüllen
                    ListViewItem newconnection = new ListViewItem();
                    newconnection.Text = (current.From.Station.Name);
                    newconnection.SubItems.Add(current.To.Station.Name);
                    newconnection.SubItems.Add(loc_duration + " min");
                    newconnection.SubItems.Add(current.From.Platform);
                    newconnection.SubItems.Add(dt.Hour + ":" + dt.Minute);
                    Listview_Verbindungen.Items.Add(newconnection);


                }
            }            
        }

        //--//Abfahrten von gewünschter Station//--//
        private void button2_Click(object sender, EventArgs e)
        {
            //Transport initialisieren
            var transportNew = new Transport();
            var stationnew = transportNew.GetStations(destination_text.Text);

            //Stationen abloopen
            foreach ( Station currently in stationnew.StationList)
            {
                var stationsboard = transportNew.GetStationBoard(currently.Name, currently.Id);

                //Stationboard abloopen
                foreach ( StationBoard current in stationsboard.Entries)
                {
                    var ListconnectionNew = transportNew.GetConnections(current.Name, current.To);

                    //Verbindungen abloopen
                    foreach ( Connection con in ListconnectionNew.ConnectionList)
                    {
                        //Duration umformatieren
                        string loc_dur = con.Duration;
                        loc_dur = loc_dur.Remove(0, 6);
                        loc_dur = loc_dur.Remove(loc_dur.Length - 3, 3);

                        //Abfahrt umformatieren
                        string dateTime = con.From.Departure;
                        string Time = con.To.Arrival;
                        DateTime td = Convert.ToDateTime(Time);
                        DateTime dt = Convert.ToDateTime(dateTime);

                        //Liste abfüllen
                        ListViewItem newconnection = new ListViewItem();
                        newconnection.Text = (con.From.Station.Name);
                        newconnection.SubItems.Add(con.To.Station.Name);
                        newconnection.SubItems.Add(loc_dur + " min");
                        newconnection.SubItems.Add(con.From.Platform);
                        newconnection.SubItems.Add(dt.Hour + ":" + dt.Minute);
                        newconnection.SubItems.Add(td.Hour + ":" + td.Minute);
                        Listview_Station.Items.Add(newconnection);

                    }
                }
            }
        }

        //Wird bei Starten des Formulars ausgeführt
        private void Mainform_Load(object sender, EventArgs e)
        {
            //Autocomplete für Stationsliste
            destination_text.AutoCompleteMode = AutoCompleteMode.Suggest;
            destination_text.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //Autocomplete für Nach
            destination_from.AutoCompleteMode = AutoCompleteMode.Suggest;
            destination_from.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //Autocomplete für Von
            destination_to.AutoCompleteMode = AutoCompleteMode.Suggest;
            destination_to.AutoCompleteSource = AutoCompleteSource.CustomSource;

            WebBrowserVersionEmulation();
        }

        //Autocomplete Methode
        private void autoCompleteStations(TextBox textBox)
        {
            if (textBox.Text.Length >= 3)
            {
                //Autocomplete für Station
                var transport = new Transport();
                List<String> suggestetStations = new List<string>();
                List<Station> stations = transport.GetStations(textBox.Text).StationList;
                AutoCompleteStringCollection source = new AutoCompleteStringCollection();

                //Stationen abloopen
                foreach (Station station in stations)
                {
                    source.Add(station.Name);
                }
                //Quelle zuweisen
                textBox.AutoCompleteCustomSource = source;
            }
        }

        //Bei Textänderung ausführen
        private void destination_from_TextChanged(object sender, EventArgs e)
        {
            autoCompleteStations(destination_from);
        }

        //Bei Textänderung ausführen
        private void destination_to_TextChanged(object sender, EventArgs e)
        {
            autoCompleteStations(destination_to);
        }

        //Bei Textänderung ausführen
        private void destination_text_TextChanged(object sender, EventArgs e)
        {
            autoCompleteStations(destination_text);
        }

        //Webbrowser Emulation -> von Stack Overflow übernommen
        private static void WebBrowserVersionEmulation()
        {
            const string BROWSER_EMULATION_KEY =
            @"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION";
      
            String appname = Process.GetCurrentProcess().ProcessName + ".exe";
            const int browserEmulationMode = 9999;

            RegistryKey browserEmulationKey =
                Registry.CurrentUser.OpenSubKey(BROWSER_EMULATION_KEY, RegistryKeyPermissionCheck.ReadWriteSubTree) ??
                Registry.CurrentUser.CreateSubKey(BROWSER_EMULATION_KEY);

            if (browserEmulationKey != null)
            {
                browserEmulationKey.SetValue(appname, browserEmulationMode, RegistryValueKind.DWord);
                browserEmulationKey.Close();
            }
        }

        //Bei Klick auf Map
        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {

            //Variablen
            var transport = new Transport();
            string dest = "Luzern";

            //Falls keine Destination angegeben wurde soll bei default Luzern angezeigt werden
            if (String.IsNullOrEmpty(destination_from.Text))
            {
                if (String.IsNullOrEmpty(destination_text.Text))
                {

                }else
                {
                    dest = destination_text.Text;
                }
            }else
            {
                dest = destination_from.Text;
            }
            var station = transport.GetStations(dest).StationList[0];

            //URL Change
            webBrowser1.Url = new Uri("https://www.google.ch/maps/@" + station.Coordinate.XCoordinate + "," + station.Coordinate.YCoordinate + "," + "13z");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Applikation schliessen
            this.Close();
        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Tabcontrol unsichtbar stellen
            tabControl1.Visible = false;

            //Neues Fenster anzeigen
            Email newMDIChild = new Email(this);
            newMDIChild.MdiParent = this;
            newMDIChild.Show();

        }

    }
}
