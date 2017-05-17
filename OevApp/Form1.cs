using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;
using System.Globalization;

namespace OevApp
{
    public partial class frmOevApp : Form
    {
        Transport transport;
        public frmOevApp()
        {
            InitializeComponent();
        }


        private void frmOevApp_Load(object sender, EventArgs e)
        {
            transport = new Transport();
        }

        public void FuelleDropdownMitStationen(ComboBox suchendesElement)
        {
            //try
            //{
                string eingegebenerText = suchendesElement.Text;
                if (eingegebenerText.Length <= 3) return;
                suchendesElement.Items.Clear();
                var stationen = transport.GetStations(eingegebenerText).StationList;
                foreach (var stationElement in stationen)
                    suchendesElement.Items.Add(stationElement.Name);
                //suchendesElement.DroppedDown = true;
            //}
            //catch (Web)
            //{

            //}
        }



        private void btnSucheStation_Click(object sender, EventArgs e)
        {
            FuelleDropdownMitStationen(cmbStartstation);
            FuelleDropdownMitStationen(cmbEndstation);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            var alleVerbindungen = transport.GetConnections(cmbStartstation.Text, cmbEndstation.Text).ConnectionList;
            foreach(var verbindung in alleVerbindungen)
            {
                String[] infos = {verbindung.From.Departure, verbindung.To.Arrival, verbindung.Duration};
                ListViewItem item = new ListViewItem(infos);
                lstAbfahrten.Items.Add(item);
            }
        }
    }
}
