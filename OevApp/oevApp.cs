using System;
using System.Windows.Forms;
using SwissTransport;
using System.Net;
using System.Diagnostics;

namespace OevApp
{
    public partial class frmOevApp : Form
    {
        Transport m_transport = new Transport();
        public frmOevApp()
        {
            InitializeComponent();
            numStunden.Value = Convert.ToDecimal(DateTime.Now.ToString("HH"));
            numMinuten.Value = Convert.ToDecimal(DateTime.Now.ToString("mm"));            
        }

        private void FuelleDropdownMitStationen(ComboBox zuFuellendeCmb)
        {
            try
            {
                string suchtext = zuFuellendeCmb.Text;
                if (suchtext.Length <= 3)
                    return;
                zuFuellendeCmb.Items.Clear();

                var stationenListe = m_transport.GetStations(suchtext).StationList;
                foreach (var einzelneStation in stationenListe)
                    zuFuellendeCmb.Items.Add(einzelneStation.Name);
            }
            catch (WebException fehlerObjekt)
            {
                MessageBox.Show("Sie haben zu viele Serveranfragen auf einmal gestellt.\nBitte versuchen Sie es erneut!\n\n" + fehlerObjekt.Message, "Zu viele Anfragen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                lstAbfahrten.Items.Clear();
                if (String.IsNullOrEmpty(cmbStartstation.Text) || String.IsNullOrEmpty(cmbEndstation.Text))
                    return;
                string suchDatum = datZeitauswahl.Value.ToString("yyyy-MM-dd");
                string suchZeit = numStunden.Value + ":" + numMinuten.Value;
                var verbindungsListe = m_transport.GetConnections(cmbStartstation.Text, cmbEndstation.Text, suchDatum, suchZeit).ConnectionList;
                int maximaleResultate = 5;
                if (verbindungsListe.Count < maximaleResultate)
                    maximaleResultate = verbindungsListe.Count;
                for (int verbindunsZaehler = 0; verbindunsZaehler < maximaleResultate; verbindunsZaehler++)
                {
                    var verbindungsObjekt = verbindungsListe[verbindunsZaehler];
                    if (verbindunsZaehler == 0)
                    {
                        cmbStartstation.Text = verbindungsObjekt.From.Station.Name;
                        cmbEndstation.Text = verbindungsObjekt.To.Station.Name;
                    }

                    DateTime abfahrtsZeit = DateTime.Parse(verbindungsObjekt.From.Departure);
                    DateTime ankunftsZeit = DateTime.Parse(verbindungsObjekt.To.Arrival);

                    String[] darzustellendeInfos = { abfahrtsZeit.ToString("HH:mm"), verbindungsObjekt.From.Station.Name, ankunftsZeit.ToString("HH:mm"), verbindungsObjekt.To.Station.Name, (ankunftsZeit - abfahrtsZeit).ToString() };
                    lstAbfahrten.Items.Add(new ListViewItem(darzustellendeInfos));
                }

                if (lstAbfahrten.Items.Count == 0)
                    lstAbfahrten.Items.Add("Keine Verbindung gefunden!");
                lstAbfahrten.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch (WebException fehlerObjekt)
            {
                MessageBox.Show("Sie haben zu viele Serveranfragen auf einmal gestellt.\nBitte versuchen Sie es erneut!\n\n" + fehlerObjekt.Message, "Zu viele Anfragen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string suchtext = cmbStartMonitor.Text;
                if (String.IsNullOrEmpty(suchtext))
                    return;
                var station = m_transport.GetStations(suchtext).StationList[0];
                var verbindungsResultate = m_transport.GetStationBoard(suchtext, station.Id).Entries;
                cmbStartMonitor.Text = station.Name;
                int maximaleResultate = 20;
                if (verbindungsResultate.Count < maximaleResultate)
                    maximaleResultate = verbindungsResultate.Count;
                for (int verbindungsZaehler = 0; verbindungsZaehler < maximaleResultate; verbindungsZaehler++)
                {
                    var verbindungsElement = verbindungsResultate[verbindungsZaehler];
                    String[] darzustellendeInfos = { verbindungsElement.Name, verbindungsElement.Stop.Departure.ToString("HH:mm"), verbindungsElement.To, };
                    lstAbfahrtenMonitor.Items.Add(new ListViewItem(darzustellendeInfos));
                }
                if (lstAbfahrtenMonitor.Items.Count == 0)
                    lstAbfahrtenMonitor.Items.Add("Keine Verbindung gefunden!");
                lstAbfahrtenMonitor.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch (WebException fehlerObjekt)
            {
                MessageBox.Show("Sie haben zu viele Serveranfragen auf einmal gestellt.\nBitte versuchen Sie es erneut!\n\n" + fehlerObjekt.Message, "Zu viele Anfragen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            var angewaehlterTabIndex = ((TabControl)sender).SelectedIndex;
            if (angewaehlterTabIndex == 0)
                this.AcceptButton = btnGo;
            else if (angewaehlterTabIndex == 1)
                this.AcceptButton = btnGoMonitor;
            else if (angewaehlterTabIndex == 2)
                this.AcceptButton = btnNaheStationen;
        }

        private void btnWechseln_Click(object sender, EventArgs e)
        {
            string werteZwischenspeicher = cmbStartstation.Text;
            cmbStartstation.Text = cmbEndstation.Text;
            cmbEndstation.Text = werteZwischenspeicher;
        }

        private void lblStartstation_Click(object sender, EventArgs e)
        {
            ZeigeStationenposition(cmbStartstation.Text);
        }

        private void lblZielstation_Click(object sender, EventArgs e)
        {
            ZeigeStationenposition(cmbEndstation.Text);
        }

        private void ZeigeStationenposition(string suchtext)
        {
            try
            {
                if (!String.IsNullOrEmpty(suchtext))
                {
                    var aktuelleLocation = m_transport.GetStations(suchtext).StationList[0].Coordinate;
                    //Searchquery zusammenstellen, zusätzlich Kommas ersetzen, da der Double dies je nach Kulturinfo beinhaltet und GoogleMaps dies so nicht findet
                    string googleUrl = "https://www.google.ch/maps/?q=loc:" + aktuelleLocation.XCoordinate.ToString().Replace(",", ".") + "+" + aktuelleLocation.YCoordinate.ToString().Replace(",", ".");
                    Process.Start(googleUrl);
                }
            }
            catch (WebException fehlerObjekt)
            {
                MessageBox.Show("Sie haben zu viele Serveranfragen auf einmal gestellt.\nBitte versuchen Sie es erneut!\n\n" + fehlerObjekt.Message, "Zu viele Anfragen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNaheStationen_Click(object sender, EventArgs e)
        {
            lstNaheStationen.Items.Clear();
            var startStation = m_transport.GetStations(txtStationInDerNaehe.Text).StationList[0];
            var stationenInDerNaehe = m_transport.GetStations(startStation.Coordinate.XCoordinate, startStation.Coordinate.YCoordinate).StationList;

            for(int stationenZaehler = 1; stationenZaehler < stationenInDerNaehe.Count; stationenZaehler++)
            {
                var stationenElement = stationenInDerNaehe[stationenZaehler];
                String[] darzustellendeInfos = {stationenElement.Name, stationenElement.Distance.ToString() + " m"};
                lstNaheStationen.Items.Add(new ListViewItem(darzustellendeInfos));
            }
            lstNaheStationen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void lstNaheStationen_Click(object sender, EventArgs e)
        {
            if(lstNaheStationen.SelectedItems != null)
            {
                ZeigeStationenposition(lstNaheStationen.SelectedItems[0].Text);
            }
        }
    }
}