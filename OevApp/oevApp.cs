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

        /// <summary>
        /// Instanziert eine öV-App
        /// </summary>
        public frmOevApp()
        {
            InitializeComponent();
        }

        #region [ Events ]
        private void frmOevApp_Load(object sender, EventArgs e)
        {
            //Standartwerte für Benutzerfreundlichkeit setzen
            cmbStartstation.Select();
            datUhrzeit.Value = DateTime.Now;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(cmbStartstation.Text) || String.IsNullOrEmpty(cmbEndstation.Text))
                    return;
                Cursor.Current = Cursors.WaitCursor;
                lstAbfahrten.Items.Clear();
                //Datums- und Zeitwert für API-Request vorbereiten
                string suchDatum = datZeitauswahl.Value.ToString("yyyy-MM-dd");
                string suchZeit = datUhrzeit.Value.ToString("HH:mm");
                var verbindungsListe = m_transport.GetConnections(cmbStartstation.Text, cmbEndstation.Text, suchDatum, suchZeit).ConnectionList;

                //Resultat-Höchstzahl festlegen
                int maximaleResultate = 5;
                if (verbindungsListe.Count < maximaleResultate)
                    maximaleResultate = verbindungsListe.Count;

                //Resultate in Liste abfüllen
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
                lstAbfahrten.Select();
            }
            catch (Exception fehlerObjekt)
            {
                if (fehlerObjekt is WebException)
                {
                    MessageBox.Show("Sie haben zu viele Serveranfragen auf einmal gestellt.\nBitte versuchen Sie es erneut!\n\n" + fehlerObjekt.Message, "Zu viele Anfragen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Es ist ein Fehler beim Suchen der Verbindung aufgetreten!\n\n" + fehlerObjekt.Message, "Fehler beim Suchen der Verbindung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnGoMonitor_Click(object sender, EventArgs e)
        {
            try
            {
                string suchtext = cmbStartMonitor.Text;
                if (String.IsNullOrEmpty(suchtext))
                    return;
                Cursor.Current = Cursors.WaitCursor;
                lstAbfahrtenMonitor.Items.Clear();

                var station = m_transport.GetStations(suchtext).StationList[0];
                var verbindungsResultate = m_transport.GetStationBoard(suchtext, station.Id).Entries;

                //Maximale Resultate limitieren
                int maximaleResultate = 20;
                if (verbindungsResultate.Count < maximaleResultate)
                    maximaleResultate = verbindungsResultate.Count;

                //Ergebnisse in Listview füllen
                for (int verbindungsZaehler = 0; verbindungsZaehler < maximaleResultate; verbindungsZaehler++)
                {
                    var verbindungsElement = verbindungsResultate[verbindungsZaehler];
                    String[] darzustellendeInfos = { verbindungsElement.Name, verbindungsElement.Stop.Departure.ToString("HH:mm"), verbindungsElement.To, };
                    lstAbfahrtenMonitor.Items.Add(new ListViewItem(darzustellendeInfos));
                }

                //Benutzerfreundlichkeit optimieren
                cmbStartMonitor.Text = station.Name;
                if (lstAbfahrtenMonitor.Items.Count == 0)
                    lstAbfahrtenMonitor.Items.Add("Keine Verbindung gefunden!");
                lstAbfahrtenMonitor.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                lstAbfahrtenMonitor.Select();
            }
            catch (Exception fehlerObjekt)
            {
                if (fehlerObjekt is WebException)
                {
                    MessageBox.Show("Sie haben zu viele Serveranfragen auf einmal gestellt.\nBitte versuchen Sie es erneut!\n\n" + fehlerObjekt.Message, "Zu viele Anfragen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Es ist ein Fehler beim Suchen des Abfahrtsmonitor aufgetreten!\n\n" + fehlerObjekt.Message, "Fehler beim Suchen des Abfahrtsmonitor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            finally
            {
                Cursor.Current = Cursors.Default;
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
            //Benutzerfreundlichkeit optimieren
            var angewaehlterTabIndex = ((TabControl)sender).SelectedIndex;
            if (angewaehlterTabIndex == 0)
            {
                this.AcceptButton = btnGo;
                cmbStartstation.Select();
                datUhrzeit.Value = DateTime.Now;
            }
            else if (angewaehlterTabIndex == 1)
            {
                this.AcceptButton = btnGoMonitor;
                cmbStartMonitor.Select();
            }
            else if (angewaehlterTabIndex == 2)
            {
                this.AcceptButton = btnNaheStationen;
                txtStationInDerNaehe.Select();
            }
        }

        private void btnWechseln_Click(object sender, EventArgs e)
        {
            //Werte wechseln
            string werteZwischenspeicher = cmbStartstation.Text;
            cmbStartstation.Text = cmbEndstation.Text;
            cmbEndstation.Text = werteZwischenspeicher;
        }

        private void lblStartstation_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cmbStartstation.Text))
                ZeigeStationenposition(cmbStartstation.Text);
        }

        private void lblZielstation_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cmbEndstation.Text))
                ZeigeStationenposition(cmbEndstation.Text);
        }

        private void btnNaheStationen_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (txtStationInDerNaehe.Text.Length >= 3)
                {
                    lstNaheStationen.Items.Clear();
                    var startStation = m_transport.GetStations(txtStationInDerNaehe.Text).StationList[0];
                    var stationenInDerNaehe = m_transport.GetStations(startStation.Coordinate.XCoordinate, startStation.Coordinate.YCoordinate).StationList;

                    for (int stationenZaehler = 1; stationenZaehler < stationenInDerNaehe.Count; stationenZaehler++)
                    {
                        var stationenElement = stationenInDerNaehe[stationenZaehler];
                        String[] darzustellendeInfos = { stationenElement.Name, stationenElement.Distance.ToString() + " m" };
                        lstNaheStationen.Items.Add(new ListViewItem(darzustellendeInfos));
                    }
                    if (lstNaheStationen.Items.Count == 0)
                        lstNaheStationen.Items.Add("Keine Stationen gefunden!");
                    lstNaheStationen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    lstNaheStationen.Select();
                }
            }
            catch (Exception fehlerObjekt)
            {
                if (fehlerObjekt is WebException)
                {
                    MessageBox.Show("Sie haben zu viele Serveranfragen auf einmal gestellt.\nBitte versuchen Sie es erneut!\n\n" + fehlerObjekt.Message, "Zu viele Anfragen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Es ist ein Fehler beim Suchen von nahen Stationen aufgetreten!\n\n" + fehlerObjekt.Message, "Fehler bei nahen Stationen suchen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void lstNaheStationen_Click(object sender, EventArgs e)
        {
            string suchText = lstNaheStationen.SelectedItems[0].Text;
            if (!String.IsNullOrEmpty(suchText))
                ZeigeStationenposition(suchText);
        }
        #endregion

        #region [ Hilfsfunktionen ]
        /// <summary>
        /// Füllt DropDown mit Stationen, welche der Suche entspricht
        /// </summary>
        /// <param name="zuFuellendeCmb">Zu füllendes DropDown</param>
        private void FuelleDropdownMitStationen(ComboBox zuFuellendeCmb)
        {
            try
            {
                string suchtext = zuFuellendeCmb.Text;
                //Damit nicht zu viele Serveranfragen durchgeführt werden, wird erst ab 3 Zeichen gesucht
                if (suchtext.Length < 3)
                    return;
                Cursor.Current = Cursors.WaitCursor;
                zuFuellendeCmb.Items.Clear();
                var stationenListe = m_transport.GetStations(suchtext).StationList;
                foreach (var einzelneStation in stationenListe)
                    zuFuellendeCmb.Items.Add(einzelneStation.Name);
            }
            catch (Exception fehlerObjekt)
            {
                if (fehlerObjekt is WebException)
                {
                    MessageBox.Show("Sie haben zu viele Serveranfragen auf einmal gestellt.\nBitte versuchen Sie es erneut!\n\n" + fehlerObjekt.Message, "Zu viele Anfragen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Es ist ein Fehler beim Füllen der ComboBox aufgetreten!\n\n" + fehlerObjekt.Message, "Fehler in Combobox Abfüllen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void ZeigeStationenposition(string suchtext)
        {
            try
            {
                if (!String.IsNullOrEmpty(suchtext))
                {
                    Cursor.Current = Cursors.WaitCursor;
                    var aktuelleLocation = m_transport.GetStations(suchtext).StationList[0].Coordinate;
                    //Searchquery zusammenstellen & zusätzlich Kommas ersetzen, da der Double dies je nach Kulturinfo beinhaltet und GoogleMaps dies so nicht findet
                    string googleUrl = "https://www.google.ch/maps/?q=loc:" + aktuelleLocation.XCoordinate.ToString().Replace(",", ".") + "+" + aktuelleLocation.YCoordinate.ToString().Replace(",", ".");
                    Process.Start(googleUrl);
                }
            }
            catch (Exception fehlerObjekt)
            {
                if (fehlerObjekt is WebException)
                {
                    MessageBox.Show("Sie haben zu viele Serveranfragen auf einmal gestellt.\nBitte versuchen Sie es erneut!\n\n" + fehlerObjekt.Message, "Zu viele Anfragen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Es ist ein Fehler beim Anzeigen der Stationsposition aufgetreten!\n\n" + fehlerObjekt.Message, "Fehler beim Stationenposition anzeigen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        #endregion
    }
}