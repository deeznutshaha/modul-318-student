namespace OevApp
{
    partial class frmOevApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOevApp));
            this.tabInhaltssteuerelement = new System.Windows.Forms.TabControl();
            this.tabAkutelleVerbindungen = new System.Windows.Forms.TabPage();
            this.grpVerbindungseingabe = new System.Windows.Forms.GroupBox();
            this.lblUhr = new System.Windows.Forms.Label();
            this.lblTrennzeichen = new System.Windows.Forms.Label();
            this.numMinuten = new System.Windows.Forms.NumericUpDown();
            this.numStunden = new System.Windows.Forms.NumericUpDown();
            this.datZeitauswahl = new System.Windows.Forms.DateTimePicker();
            this.lblDatumZeit = new System.Windows.Forms.Label();
            this.btnWechseln = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.cmbEndstation = new System.Windows.Forms.ComboBox();
            this.cmbStartstation = new System.Windows.Forms.ComboBox();
            this.lblZielstation = new System.Windows.Forms.Label();
            this.lblStartstation = new System.Windows.Forms.Label();
            this.grpVerbindungsabfahrten = new System.Windows.Forms.GroupBox();
            this.lstAbfahrten = new System.Windows.Forms.ListView();
            this.colAbfahrt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStartstation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAnkunft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colZielstation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDauer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabAbfahrtsmonitor = new System.Windows.Forms.TabPage();
            this.grpMonitoreingabe = new System.Windows.Forms.GroupBox();
            this.btnGoMonitor = new System.Windows.Forms.Button();
            this.cmbStartMonitor = new System.Windows.Forms.ComboBox();
            this.lblStartMonitor = new System.Windows.Forms.Label();
            this.grpMonitorabfahrten = new System.Windows.Forms.GroupBox();
            this.lstAbfahrtenMonitor = new System.Windows.Forms.ListView();
            this.colBezeichnung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAbfahrtszeit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colZielort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabStationenInDerNaehe = new System.Windows.Forms.TabPage();
            this.grpStationInDerNaehe = new System.Windows.Forms.GroupBox();
            this.lstNaheStationen = new System.Windows.Forms.ListView();
            this.colStationenname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDistanz = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpEingabeInNaehe = new System.Windows.Forms.GroupBox();
            this.btnNaheStationen = new System.Windows.Forms.Button();
            this.txtStationInDerNaehe = new System.Windows.Forms.TextBox();
            this.lblSuchstation = new System.Windows.Forms.Label();
            this.ttpStandort = new System.Windows.Forms.ToolTip(this.components);
            this.tabInhaltssteuerelement.SuspendLayout();
            this.tabAkutelleVerbindungen.SuspendLayout();
            this.grpVerbindungseingabe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinuten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStunden)).BeginInit();
            this.grpVerbindungsabfahrten.SuspendLayout();
            this.tabAbfahrtsmonitor.SuspendLayout();
            this.grpMonitoreingabe.SuspendLayout();
            this.grpMonitorabfahrten.SuspendLayout();
            this.tabStationenInDerNaehe.SuspendLayout();
            this.grpStationInDerNaehe.SuspendLayout();
            this.grpEingabeInNaehe.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabInhaltssteuerelement
            // 
            this.tabInhaltssteuerelement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabInhaltssteuerelement.Controls.Add(this.tabAkutelleVerbindungen);
            this.tabInhaltssteuerelement.Controls.Add(this.tabAbfahrtsmonitor);
            this.tabInhaltssteuerelement.Controls.Add(this.tabStationenInDerNaehe);
            this.tabInhaltssteuerelement.Location = new System.Drawing.Point(12, 12);
            this.tabInhaltssteuerelement.Multiline = true;
            this.tabInhaltssteuerelement.Name = "tabInhaltssteuerelement";
            this.tabInhaltssteuerelement.SelectedIndex = 0;
            this.tabInhaltssteuerelement.Size = new System.Drawing.Size(460, 437);
            this.tabInhaltssteuerelement.TabIndex = 0;
            this.tabInhaltssteuerelement.SelectedIndexChanged += new System.EventHandler(this.tabInhaltsteuerung_SelectedIndexChanged);
            // 
            // tabAkutelleVerbindungen
            // 
            this.tabAkutelleVerbindungen.Controls.Add(this.grpVerbindungseingabe);
            this.tabAkutelleVerbindungen.Controls.Add(this.grpVerbindungsabfahrten);
            this.tabAkutelleVerbindungen.Location = new System.Drawing.Point(4, 22);
            this.tabAkutelleVerbindungen.Name = "tabAkutelleVerbindungen";
            this.tabAkutelleVerbindungen.Padding = new System.Windows.Forms.Padding(3);
            this.tabAkutelleVerbindungen.Size = new System.Drawing.Size(452, 411);
            this.tabAkutelleVerbindungen.TabIndex = 0;
            this.tabAkutelleVerbindungen.Text = "Akutelle Verbindungen";
            this.tabAkutelleVerbindungen.UseVisualStyleBackColor = true;
            // 
            // grpVerbindungseingabe
            // 
            this.grpVerbindungseingabe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpVerbindungseingabe.Controls.Add(this.lblUhr);
            this.grpVerbindungseingabe.Controls.Add(this.lblTrennzeichen);
            this.grpVerbindungseingabe.Controls.Add(this.numMinuten);
            this.grpVerbindungseingabe.Controls.Add(this.numStunden);
            this.grpVerbindungseingabe.Controls.Add(this.datZeitauswahl);
            this.grpVerbindungseingabe.Controls.Add(this.lblDatumZeit);
            this.grpVerbindungseingabe.Controls.Add(this.btnWechseln);
            this.grpVerbindungseingabe.Controls.Add(this.btnGo);
            this.grpVerbindungseingabe.Controls.Add(this.cmbEndstation);
            this.grpVerbindungseingabe.Controls.Add(this.cmbStartstation);
            this.grpVerbindungseingabe.Controls.Add(this.lblZielstation);
            this.grpVerbindungseingabe.Controls.Add(this.lblStartstation);
            this.grpVerbindungseingabe.Location = new System.Drawing.Point(4, 11);
            this.grpVerbindungseingabe.MinimumSize = new System.Drawing.Size(444, 119);
            this.grpVerbindungseingabe.Name = "grpVerbindungseingabe";
            this.grpVerbindungseingabe.Size = new System.Drawing.Size(444, 120);
            this.grpVerbindungseingabe.TabIndex = 2;
            this.grpVerbindungseingabe.TabStop = false;
            this.grpVerbindungseingabe.Text = "Eingabe";
            // 
            // lblUhr
            // 
            this.lblUhr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUhr.AutoSize = true;
            this.lblUhr.Location = new System.Drawing.Point(375, 88);
            this.lblUhr.Name = "lblUhr";
            this.lblUhr.Size = new System.Drawing.Size(24, 13);
            this.lblUhr.TabIndex = 9;
            this.lblUhr.Text = "Uhr";
            // 
            // lblTrennzeichen
            // 
            this.lblTrennzeichen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrennzeichen.AutoSize = true;
            this.lblTrennzeichen.Location = new System.Drawing.Point(309, 88);
            this.lblTrennzeichen.Name = "lblTrennzeichen";
            this.lblTrennzeichen.Size = new System.Drawing.Size(10, 13);
            this.lblTrennzeichen.TabIndex = 8;
            this.lblTrennzeichen.Text = ":";
            // 
            // numMinuten
            // 
            this.numMinuten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numMinuten.Location = new System.Drawing.Point(325, 84);
            this.numMinuten.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numMinuten.Name = "numMinuten";
            this.numMinuten.Size = new System.Drawing.Size(44, 20);
            this.numMinuten.TabIndex = 5;
            // 
            // numStunden
            // 
            this.numStunden.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numStunden.Location = new System.Drawing.Point(262, 84);
            this.numStunden.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numStunden.Name = "numStunden";
            this.numStunden.Size = new System.Drawing.Size(44, 20);
            this.numStunden.TabIndex = 4;
            // 
            // datZeitauswahl
            // 
            this.datZeitauswahl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datZeitauswahl.CalendarMonthBackground = System.Drawing.Color.White;
            this.datZeitauswahl.CustomFormat = "dd. MMMM yyyy";
            this.datZeitauswahl.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datZeitauswahl.Location = new System.Drawing.Point(85, 84);
            this.datZeitauswahl.Name = "datZeitauswahl";
            this.datZeitauswahl.Size = new System.Drawing.Size(145, 20);
            this.datZeitauswahl.TabIndex = 3;
            this.datZeitauswahl.Value = new System.DateTime(2017, 5, 22, 13, 13, 21, 160);
            // 
            // lblDatumZeit
            // 
            this.lblDatumZeit.AutoSize = true;
            this.lblDatumZeit.Location = new System.Drawing.Point(9, 86);
            this.lblDatumZeit.Name = "lblDatumZeit";
            this.lblDatumZeit.Size = new System.Drawing.Size(70, 13);
            this.lblDatumZeit.TabIndex = 4;
            this.lblDatumZeit.Text = "Datum / Zeit:";
            // 
            // btnWechseln
            // 
            this.btnWechseln.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWechseln.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnWechseln.FlatAppearance.BorderSize = 0;
            this.btnWechseln.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnWechseln.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnWechseln.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWechseln.Image = global::OevApp.Properties.Resources.ic_swap_vert_black_24dp_1x;
            this.btnWechseln.Location = new System.Drawing.Point(411, 33);
            this.btnWechseln.Name = "btnWechseln";
            this.btnWechseln.Size = new System.Drawing.Size(33, 37);
            this.btnWechseln.TabIndex = 2;
            this.btnWechseln.UseVisualStyleBackColor = true;
            this.btnWechseln.Click += new System.EventHandler(this.btnWechseln_Click);
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGo.FlatAppearance.BorderSize = 0;
            this.btnGo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.Image = global::OevApp.Properties.Resources.ic_search_black_24dp_1x;
            this.btnGo.Location = new System.Drawing.Point(411, 76);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(31, 37);
            this.btnGo.TabIndex = 6;
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // cmbEndstation
            // 
            this.cmbEndstation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEndstation.FormattingEnabled = true;
            this.cmbEndstation.Location = new System.Drawing.Point(85, 57);
            this.cmbEndstation.Name = "cmbEndstation";
            this.cmbEndstation.Size = new System.Drawing.Size(324, 21);
            this.cmbEndstation.TabIndex = 1;
            this.cmbEndstation.DropDown += new System.EventHandler(this.cmbEndstation_DropDown);
            // 
            // cmbStartstation
            // 
            this.cmbStartstation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStartstation.FormattingEnabled = true;
            this.cmbStartstation.Location = new System.Drawing.Point(85, 30);
            this.cmbStartstation.Name = "cmbStartstation";
            this.cmbStartstation.Size = new System.Drawing.Size(324, 21);
            this.cmbStartstation.TabIndex = 0;
            this.cmbStartstation.DropDown += new System.EventHandler(this.cmbStartstation_DropDown);
            // 
            // lblZielstation
            // 
            this.lblZielstation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblZielstation.AutoSize = true;
            this.lblZielstation.Location = new System.Drawing.Point(6, 57);
            this.lblZielstation.Name = "lblZielstation";
            this.lblZielstation.Size = new System.Drawing.Size(58, 13);
            this.lblZielstation.TabIndex = 1;
            this.lblZielstation.Text = "Zielstation:";
            this.ttpStandort.SetToolTip(this.lblZielstation, "Zeigt den Standort der ausgewählten Zielstation im Webbrowser an.");
            this.lblZielstation.Click += new System.EventHandler(this.lblZielstation_Click);
            // 
            // lblStartstation
            // 
            this.lblStartstation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStartstation.AutoSize = true;
            this.lblStartstation.Location = new System.Drawing.Point(6, 33);
            this.lblStartstation.Name = "lblStartstation";
            this.lblStartstation.Size = new System.Drawing.Size(63, 13);
            this.lblStartstation.TabIndex = 0;
            this.lblStartstation.Text = "Startstation:";
            this.ttpStandort.SetToolTip(this.lblStartstation, "Zeigt den Standort der ausgewählten Startstation im Webbrowser an.");
            this.lblStartstation.Click += new System.EventHandler(this.lblStartstation_Click);
            // 
            // grpVerbindungsabfahrten
            // 
            this.grpVerbindungsabfahrten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpVerbindungsabfahrten.Controls.Add(this.lstAbfahrten);
            this.grpVerbindungsabfahrten.Location = new System.Drawing.Point(4, 136);
            this.grpVerbindungsabfahrten.Name = "grpVerbindungsabfahrten";
            this.grpVerbindungsabfahrten.Size = new System.Drawing.Size(444, 264);
            this.grpVerbindungsabfahrten.TabIndex = 3;
            this.grpVerbindungsabfahrten.TabStop = false;
            this.grpVerbindungsabfahrten.Text = "Abfahrten";
            // 
            // lstAbfahrten
            // 
            this.lstAbfahrten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstAbfahrten.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAbfahrt,
            this.colStartstation,
            this.colAnkunft,
            this.colZielstation,
            this.colDauer});
            this.lstAbfahrten.FullRowSelect = true;
            this.lstAbfahrten.Location = new System.Drawing.Point(9, 19);
            this.lstAbfahrten.Name = "lstAbfahrten";
            this.lstAbfahrten.Size = new System.Drawing.Size(429, 239);
            this.lstAbfahrten.TabIndex = 7;
            this.lstAbfahrten.UseCompatibleStateImageBehavior = false;
            this.lstAbfahrten.View = System.Windows.Forms.View.Details;
            // 
            // colAbfahrt
            // 
            this.colAbfahrt.Text = "Abfahrt";
            this.colAbfahrt.Width = 46;
            // 
            // colStartstation
            // 
            this.colStartstation.Text = "Startstation";
            this.colStartstation.Width = 65;
            // 
            // colAnkunft
            // 
            this.colAnkunft.Text = "Ankunft";
            this.colAnkunft.Width = 49;
            // 
            // colZielstation
            // 
            this.colZielstation.Text = "Zielstation";
            // 
            // colDauer
            // 
            this.colDauer.Text = "Dauer";
            this.colDauer.Width = 205;
            // 
            // tabAbfahrtsmonitor
            // 
            this.tabAbfahrtsmonitor.Controls.Add(this.grpMonitoreingabe);
            this.tabAbfahrtsmonitor.Controls.Add(this.grpMonitorabfahrten);
            this.tabAbfahrtsmonitor.Location = new System.Drawing.Point(4, 22);
            this.tabAbfahrtsmonitor.Name = "tabAbfahrtsmonitor";
            this.tabAbfahrtsmonitor.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbfahrtsmonitor.Size = new System.Drawing.Size(452, 411);
            this.tabAbfahrtsmonitor.TabIndex = 1;
            this.tabAbfahrtsmonitor.Text = "Abfahrtsmonitor";
            this.tabAbfahrtsmonitor.UseVisualStyleBackColor = true;
            // 
            // grpMonitoreingabe
            // 
            this.grpMonitoreingabe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMonitoreingabe.Controls.Add(this.btnGoMonitor);
            this.grpMonitoreingabe.Controls.Add(this.cmbStartMonitor);
            this.grpMonitoreingabe.Controls.Add(this.lblStartMonitor);
            this.grpMonitoreingabe.Location = new System.Drawing.Point(4, 11);
            this.grpMonitoreingabe.Name = "grpMonitoreingabe";
            this.grpMonitoreingabe.Size = new System.Drawing.Size(444, 120);
            this.grpMonitoreingabe.TabIndex = 2;
            this.grpMonitoreingabe.TabStop = false;
            this.grpMonitoreingabe.Text = "Eingabe";
            // 
            // btnGoMonitor
            // 
            this.btnGoMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGoMonitor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGoMonitor.FlatAppearance.BorderSize = 0;
            this.btnGoMonitor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGoMonitor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGoMonitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoMonitor.Image = global::OevApp.Properties.Resources.ic_search_black_24dp_1x;
            this.btnGoMonitor.Location = new System.Drawing.Point(411, 76);
            this.btnGoMonitor.Name = "btnGoMonitor";
            this.btnGoMonitor.Size = new System.Drawing.Size(31, 37);
            this.btnGoMonitor.TabIndex = 3;
            this.btnGoMonitor.UseVisualStyleBackColor = true;
            this.btnGoMonitor.Click += new System.EventHandler(this.btnGoMonitor_Click);
            // 
            // cmbStartMonitor
            // 
            this.cmbStartMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStartMonitor.FormattingEnabled = true;
            this.cmbStartMonitor.Location = new System.Drawing.Point(85, 30);
            this.cmbStartMonitor.Name = "cmbStartMonitor";
            this.cmbStartMonitor.Size = new System.Drawing.Size(324, 21);
            this.cmbStartMonitor.TabIndex = 0;
            this.cmbStartMonitor.DropDown += new System.EventHandler(this.cmbStartMonitor_DropDown);
            // 
            // lblStartMonitor
            // 
            this.lblStartMonitor.AutoSize = true;
            this.lblStartMonitor.Location = new System.Drawing.Point(6, 33);
            this.lblStartMonitor.Name = "lblStartMonitor";
            this.lblStartMonitor.Size = new System.Drawing.Size(63, 13);
            this.lblStartMonitor.TabIndex = 0;
            this.lblStartMonitor.Text = "Startstation:";
            // 
            // grpMonitorabfahrten
            // 
            this.grpMonitorabfahrten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMonitorabfahrten.Controls.Add(this.lstAbfahrtenMonitor);
            this.grpMonitorabfahrten.Location = new System.Drawing.Point(4, 136);
            this.grpMonitorabfahrten.Name = "grpMonitorabfahrten";
            this.grpMonitorabfahrten.Size = new System.Drawing.Size(444, 264);
            this.grpMonitorabfahrten.TabIndex = 3;
            this.grpMonitorabfahrten.TabStop = false;
            this.grpMonitorabfahrten.Text = "Abfahrten";
            // 
            // lstAbfahrtenMonitor
            // 
            this.lstAbfahrtenMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstAbfahrtenMonitor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colBezeichnung,
            this.colAbfahrtszeit,
            this.colZielort});
            this.lstAbfahrtenMonitor.FullRowSelect = true;
            this.lstAbfahrtenMonitor.Location = new System.Drawing.Point(9, 19);
            this.lstAbfahrtenMonitor.Name = "lstAbfahrtenMonitor";
            this.lstAbfahrtenMonitor.Size = new System.Drawing.Size(429, 239);
            this.lstAbfahrtenMonitor.TabIndex = 4;
            this.lstAbfahrtenMonitor.UseCompatibleStateImageBehavior = false;
            this.lstAbfahrtenMonitor.View = System.Windows.Forms.View.Details;
            // 
            // colBezeichnung
            // 
            this.colBezeichnung.Text = "Bezeichnung";
            this.colBezeichnung.Width = 74;
            // 
            // colAbfahrtszeit
            // 
            this.colAbfahrtszeit.Text = "Abfahrtszeit";
            this.colAbfahrtszeit.Width = 67;
            // 
            // colZielort
            // 
            this.colZielort.Text = "Zielort";
            this.colZielort.Width = 284;
            // 
            // tabStationenInDerNaehe
            // 
            this.tabStationenInDerNaehe.Controls.Add(this.grpStationInDerNaehe);
            this.tabStationenInDerNaehe.Controls.Add(this.grpEingabeInNaehe);
            this.tabStationenInDerNaehe.Location = new System.Drawing.Point(4, 22);
            this.tabStationenInDerNaehe.Name = "tabStationenInDerNaehe";
            this.tabStationenInDerNaehe.Padding = new System.Windows.Forms.Padding(3);
            this.tabStationenInDerNaehe.Size = new System.Drawing.Size(452, 411);
            this.tabStationenInDerNaehe.TabIndex = 2;
            this.tabStationenInDerNaehe.Text = "In der Nähe";
            this.tabStationenInDerNaehe.UseVisualStyleBackColor = true;
            // 
            // grpStationInDerNaehe
            // 
            this.grpStationInDerNaehe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpStationInDerNaehe.Controls.Add(this.lstNaheStationen);
            this.grpStationInDerNaehe.Location = new System.Drawing.Point(4, 136);
            this.grpStationInDerNaehe.Name = "grpStationInDerNaehe";
            this.grpStationInDerNaehe.Size = new System.Drawing.Size(444, 264);
            this.grpStationInDerNaehe.TabIndex = 4;
            this.grpStationInDerNaehe.TabStop = false;
            this.grpStationInDerNaehe.Text = "Stationen in der Nähe";
            // 
            // lstNaheStationen
            // 
            this.lstNaheStationen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstNaheStationen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colStationenname,
            this.colDistanz});
            this.lstNaheStationen.FullRowSelect = true;
            this.lstNaheStationen.Location = new System.Drawing.Point(9, 19);
            this.lstNaheStationen.Name = "lstNaheStationen";
            this.lstNaheStationen.Size = new System.Drawing.Size(429, 239);
            this.lstNaheStationen.TabIndex = 2;
            this.lstNaheStationen.UseCompatibleStateImageBehavior = false;
            this.lstNaheStationen.View = System.Windows.Forms.View.Details;
            this.lstNaheStationen.Click += new System.EventHandler(this.lstNaheStationen_Click);
            // 
            // colStationenname
            // 
            this.colStationenname.Text = "Stationenname";
            this.colStationenname.Width = 83;
            // 
            // colDistanz
            // 
            this.colDistanz.Text = "Distanz";
            this.colDistanz.Width = 356;
            // 
            // grpEingabeInNaehe
            // 
            this.grpEingabeInNaehe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEingabeInNaehe.Controls.Add(this.btnNaheStationen);
            this.grpEingabeInNaehe.Controls.Add(this.txtStationInDerNaehe);
            this.grpEingabeInNaehe.Controls.Add(this.lblSuchstation);
            this.grpEingabeInNaehe.Location = new System.Drawing.Point(4, 11);
            this.grpEingabeInNaehe.MinimumSize = new System.Drawing.Size(444, 119);
            this.grpEingabeInNaehe.Name = "grpEingabeInNaehe";
            this.grpEingabeInNaehe.Size = new System.Drawing.Size(444, 120);
            this.grpEingabeInNaehe.TabIndex = 3;
            this.grpEingabeInNaehe.TabStop = false;
            this.grpEingabeInNaehe.Text = "Eingabe";
            // 
            // btnNaheStationen
            // 
            this.btnNaheStationen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNaheStationen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNaheStationen.FlatAppearance.BorderSize = 0;
            this.btnNaheStationen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNaheStationen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNaheStationen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNaheStationen.Image = global::OevApp.Properties.Resources.ic_location_searching_black_24dp_1x;
            this.btnNaheStationen.Location = new System.Drawing.Point(411, 76);
            this.btnNaheStationen.Name = "btnNaheStationen";
            this.btnNaheStationen.Size = new System.Drawing.Size(31, 37);
            this.btnNaheStationen.TabIndex = 1;
            this.btnNaheStationen.UseVisualStyleBackColor = true;
            this.btnNaheStationen.Click += new System.EventHandler(this.btnNaheStationen_Click);
            // 
            // txtStationInDerNaehe
            // 
            this.txtStationInDerNaehe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStationInDerNaehe.Location = new System.Drawing.Point(85, 30);
            this.txtStationInDerNaehe.Name = "txtStationInDerNaehe";
            this.txtStationInDerNaehe.Size = new System.Drawing.Size(324, 20);
            this.txtStationInDerNaehe.TabIndex = 0;
            // 
            // lblSuchstation
            // 
            this.lblSuchstation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSuchstation.AutoSize = true;
            this.lblSuchstation.Location = new System.Drawing.Point(6, 33);
            this.lblSuchstation.Name = "lblSuchstation";
            this.lblSuchstation.Size = new System.Drawing.Size(66, 13);
            this.lblSuchstation.TabIndex = 0;
            this.lblSuchstation.Text = "Suchstation:";
            // 
            // ttpStandort
            // 
            this.ttpStandort.ToolTipTitle = "Zeige Standort";
            // 
            // frmOevApp
            // 
            this.AcceptButton = this.btnGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.tabInhaltssteuerelement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "frmOevApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "öV App";
            this.tabInhaltssteuerelement.ResumeLayout(false);
            this.tabAkutelleVerbindungen.ResumeLayout(false);
            this.grpVerbindungseingabe.ResumeLayout(false);
            this.grpVerbindungseingabe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinuten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStunden)).EndInit();
            this.grpVerbindungsabfahrten.ResumeLayout(false);
            this.tabAbfahrtsmonitor.ResumeLayout(false);
            this.grpMonitoreingabe.ResumeLayout(false);
            this.grpMonitoreingabe.PerformLayout();
            this.grpMonitorabfahrten.ResumeLayout(false);
            this.tabStationenInDerNaehe.ResumeLayout(false);
            this.grpStationInDerNaehe.ResumeLayout(false);
            this.grpEingabeInNaehe.ResumeLayout(false);
            this.grpEingabeInNaehe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabInhaltssteuerelement;
        private System.Windows.Forms.TabPage tabAkutelleVerbindungen;
        private System.Windows.Forms.TabPage tabAbfahrtsmonitor;
        private System.Windows.Forms.GroupBox grpVerbindungseingabe;
        private System.Windows.Forms.ComboBox cmbEndstation;
        private System.Windows.Forms.ComboBox cmbStartstation;
        private System.Windows.Forms.Label lblZielstation;
        private System.Windows.Forms.Label lblStartstation;
        private System.Windows.Forms.GroupBox grpVerbindungsabfahrten;
        private System.Windows.Forms.GroupBox grpMonitoreingabe;
        private System.Windows.Forms.ComboBox cmbStartMonitor;
        private System.Windows.Forms.Label lblStartMonitor;
        private System.Windows.Forms.GroupBox grpMonitorabfahrten;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ListView lstAbfahrten;
        private System.Windows.Forms.ColumnHeader colAbfahrt;
        private System.Windows.Forms.ColumnHeader colAnkunft;
        private System.Windows.Forms.ColumnHeader colDauer;
        private System.Windows.Forms.Button btnGoMonitor;
        private System.Windows.Forms.ListView lstAbfahrtenMonitor;
        private System.Windows.Forms.ColumnHeader colBezeichnung;
        private System.Windows.Forms.ColumnHeader colAbfahrtszeit;
        private System.Windows.Forms.ColumnHeader colZielort;
        private System.Windows.Forms.ColumnHeader colStartstation;
        private System.Windows.Forms.ColumnHeader colZielstation;
        private System.Windows.Forms.Button btnWechseln;
        private System.Windows.Forms.ToolTip ttpStandort;
        private System.Windows.Forms.Label lblDatumZeit;
        private System.Windows.Forms.DateTimePicker datZeitauswahl;
        private System.Windows.Forms.NumericUpDown numMinuten;
        private System.Windows.Forms.NumericUpDown numStunden;
        private System.Windows.Forms.Label lblTrennzeichen;
        private System.Windows.Forms.Label lblUhr;
        private System.Windows.Forms.TabPage tabStationenInDerNaehe;
        private System.Windows.Forms.ListView lstNaheStationen;
        private System.Windows.Forms.ColumnHeader colStationenname;
        private System.Windows.Forms.ColumnHeader colDistanz;
        private System.Windows.Forms.Button btnNaheStationen;
        private System.Windows.Forms.TextBox txtStationInDerNaehe;
        private System.Windows.Forms.GroupBox grpEingabeInNaehe;
        private System.Windows.Forms.Label lblSuchstation;
        private System.Windows.Forms.GroupBox grpStationInDerNaehe;
    }
}

