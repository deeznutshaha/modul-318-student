using System;
using System.Windows.Forms;
using SwissTransport;
using System.Net;

namespace OevApp
{
    public partial class frmOevApp : Form
    {
        Transport m_transport = new Transport();
        public frmOevApp()
        {
            InitializeComponent();
        }

        private void FuelleDropdownMitStationen(ComboBox suchendesElement)
        {
            try
            {
                string eingegebenerText = suchendesElement.Text;
                if (eingegebenerText.Length <= 3)
                    return;
                suchendesElement.Items.Clear();

                var stationen = m_transport.GetStations(eingegebenerText).StationList;
                foreach (var stationElement in stationen)
                    suchendesElement.Items.Add(stationElement.Name);
            }
            catch (WebException fehlermeldung)
            {
                MessageBox.Show("Sie haben zu viele Serveranfragen auf einmal gestellt.\nBitte versuchen Sie es erneut!\n\n" + fehlermeldung.Message, "Zu viele Anfragen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                lstAbfahrten.Items.Clear();
                if (String.IsNullOrEmpty(cmbStartstation.Text) || String.IsNullOrEmpty(cmbEndstation.Text))
                    return;
                var alleVerbindungen = m_transport.GetConnections(cmbStartstation.Text, cmbEndstation.Text).ConnectionList;
                int maximaleResultate = 5;
                if (alleVerbindungen.Count < maximaleResultate)
                    maximaleResultate = alleVerbindungen.Count;
                for (int verbindungsZaehler = 0; verbindungsZaehler < maximaleResultate; verbindungsZaehler++)
                {
                    var verbindungsElement = alleVerbindungen[verbindungsZaehler];
                    DateTime abfahrtsZeit = DateTime.Parse(verbindungsElement.From.Departure);
                    DateTime ankunftsZeit = DateTime.Parse(verbindungsElement.To.Arrival);

                    String[] infos = {verbindungsElement.From.Platform, abfahrtsZeit.ToString("HH:mm"), ankunftsZeit.ToString("HH:mm"), (ankunftsZeit-abfahrtsZeit).ToString()};
                    ListViewItem item = new ListViewItem(infos);
                    lstAbfahrten.Items.Add(item);
                }
                if (lstAbfahrten.Items.Count == 0)
                    lstAbfahrten.Items.Add("Keine Verbindung gefunden!");
                lstAbfahrten.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch (WebException fehlermeldung)
            {
                MessageBox.Show("Sie haben zu viele Serveranfragen auf einmal gestellt.\nBitte versuchen Sie es erneut!\n\n" + fehlermeldung.Message, "Zu viele Anfragen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSucheMonitor_Click(object sender, EventArgs e)
        {
            FuelleDropdownMitStationen(cmbStartMonitor);
            this.AcceptButton = btnGoMonitor;
        }

        private void btnGoMonitor_Click(object sender, EventArgs e)
        {
            try
            {
                lstAbfahrtenMonitor.Items.Clear();
                if (String.IsNullOrEmpty(cmbStartMonitor.Text))
                    return;
                var stationen = m_transport.GetStations(cmbStartMonitor.Text).StationList;
                string stationId = stationen[0].Id;
                var alleVerbindungen = m_transport.GetStationBoard(cmbStartMonitor.Text, stationId).Entries;
                int maximaleResultate = 20;
                if (alleVerbindungen.Count < maximaleResultate)
                    maximaleResultate = alleVerbindungen.Count;
                for (int verbindungsZaehler = 0; verbindungsZaehler < maximaleResultate; verbindungsZaehler++)
                {
                    var verbindungsElement = alleVerbindungen[verbindungsZaehler];
  
                    String[] infos = { verbindungsElement.Name, verbindungsElement.Stop.Departure.ToString("HH:mm"), verbindungsElement.To,   };
                    ListViewItem item = new ListViewItem(infos);
                    lstAbfahrtenMonitor.Items.Add(item);
                }
                if (lstAbfahrtenMonitor.Items.Count == 0)
                    lstAbfahrtenMonitor.Items.Add("Keine Verbindung gefunden!");
                lstAbfahrtenMonitor.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch (WebException fehlermeldung)
            {
                MessageBox.Show("Sie haben zu viele Serveranfragen auf einmal gestellt.\nBitte versuchen Sie es erneut!\n\n" + fehlermeldung.Message, "Zu viele Anfragen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbStartstation_DropDown(object sender, EventArgs e)
        {
            FuelleDropdownMitStationen(cmbStartstation);
        }

        private void cmbEndstation_DropDown(object sender, EventArgs e)
        {
            FuelleDropdownMitStationen(cmbEndstation);
        }

        private void cmbStartMonitor_DropDown(object sender, EventArgs e)
        {
            FuelleDropdownMitStationen(cmbStartMonitor);
        }

        private void tabInhaltsteuerung_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tab = ((TabControl)sender).Name;
        }
    }
}