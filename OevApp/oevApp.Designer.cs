﻿namespace OevApp
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
            this.tabInhaltssteuerelement = new System.Windows.Forms.TabControl();
            this.tabAkutelleVerbindungen = new System.Windows.Forms.TabPage();
            this.grpVerbindungseingabe = new System.Windows.Forms.GroupBox();
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
            this.btnGoMonitor = new System.Windows.Forms.Button();
            this.grpMonitoreingabe = new System.Windows.Forms.GroupBox();
            this.cmbStartMonitor = new System.Windows.Forms.ComboBox();
            this.lblStartMonitor = new System.Windows.Forms.Label();
            this.grpMonitorabfahrten = new System.Windows.Forms.GroupBox();
            this.lstAbfahrtenMonitor = new System.Windows.Forms.ListView();
            this.colBezeichnung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAbfahrtszeit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colZielort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnWechseln = new System.Windows.Forms.Button();
            this.tabInhaltssteuerelement.SuspendLayout();
            this.tabAkutelleVerbindungen.SuspendLayout();
            this.grpVerbindungseingabe.SuspendLayout();
            this.grpVerbindungsabfahrten.SuspendLayout();
            this.tabAbfahrtsmonitor.SuspendLayout();
            this.grpMonitoreingabe.SuspendLayout();
            this.grpMonitorabfahrten.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabInhaltssteuerelement
            // 
            this.tabInhaltssteuerelement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabInhaltssteuerelement.Controls.Add(this.tabAkutelleVerbindungen);
            this.tabInhaltssteuerelement.Controls.Add(this.tabAbfahrtsmonitor);
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
            this.grpVerbindungseingabe.Controls.Add(this.btnWechseln);
            this.grpVerbindungseingabe.Controls.Add(this.btnGo);
            this.grpVerbindungseingabe.Controls.Add(this.cmbEndstation);
            this.grpVerbindungseingabe.Controls.Add(this.cmbStartstation);
            this.grpVerbindungseingabe.Controls.Add(this.lblZielstation);
            this.grpVerbindungseingabe.Controls.Add(this.lblStartstation);
            this.grpVerbindungseingabe.Location = new System.Drawing.Point(4, 11);
            this.grpVerbindungseingabe.MinimumSize = new System.Drawing.Size(444, 119);
            this.grpVerbindungseingabe.Name = "grpVerbindungseingabe";
            this.grpVerbindungseingabe.Size = new System.Drawing.Size(444, 119);
            this.grpVerbindungseingabe.TabIndex = 2;
            this.grpVerbindungseingabe.TabStop = false;
            this.grpVerbindungseingabe.Text = "Eingabe";
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(374, 84);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(64, 23);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "GO";
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
            this.lstAbfahrten.TabIndex = 0;
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
            this.colDauer.Width = 152;
            // 
            // tabAbfahrtsmonitor
            // 
            this.tabAbfahrtsmonitor.Controls.Add(this.btnGoMonitor);
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
            // btnGoMonitor
            // 
            this.btnGoMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGoMonitor.Location = new System.Drawing.Point(378, 95);
            this.btnGoMonitor.Name = "btnGoMonitor";
            this.btnGoMonitor.Size = new System.Drawing.Size(64, 23);
            this.btnGoMonitor.TabIndex = 3;
            this.btnGoMonitor.Text = "GO";
            this.btnGoMonitor.UseVisualStyleBackColor = true;
            this.btnGoMonitor.Click += new System.EventHandler(this.btnGoMonitor_Click);
            // 
            // grpMonitoreingabe
            // 
            this.grpMonitoreingabe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMonitoreingabe.Controls.Add(this.cmbStartMonitor);
            this.grpMonitoreingabe.Controls.Add(this.lblStartMonitor);
            this.grpMonitoreingabe.Location = new System.Drawing.Point(4, 11);
            this.grpMonitoreingabe.Name = "grpMonitoreingabe";
            this.grpMonitoreingabe.Size = new System.Drawing.Size(444, 117);
            this.grpMonitoreingabe.TabIndex = 2;
            this.grpMonitoreingabe.TabStop = false;
            this.grpMonitoreingabe.Text = "Eingabe";
            // 
            // cmbStartMonitor
            // 
            this.cmbStartMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStartMonitor.FormattingEnabled = true;
            this.cmbStartMonitor.Location = new System.Drawing.Point(85, 30);
            this.cmbStartMonitor.Name = "cmbStartMonitor";
            this.cmbStartMonitor.Size = new System.Drawing.Size(353, 21);
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
            this.grpMonitorabfahrten.Location = new System.Drawing.Point(4, 128);
            this.grpMonitorabfahrten.Name = "grpMonitorabfahrten";
            this.grpMonitorabfahrten.Size = new System.Drawing.Size(444, 272);
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
            this.lstAbfahrtenMonitor.Location = new System.Drawing.Point(9, 20);
            this.lstAbfahrtenMonitor.Name = "lstAbfahrtenMonitor";
            this.lstAbfahrtenMonitor.Size = new System.Drawing.Size(433, 246);
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
            this.colZielort.Width = 295;
            // 
            // btnWechseln
            // 
            this.btnWechseln.FlatAppearance.BorderSize = 0;
            this.btnWechseln.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWechseln.Image = global::OevApp.Properties.Resources.ic_swap_vert_black_24dp_1x;
            this.btnWechseln.Location = new System.Drawing.Point(411, 42);
            this.btnWechseln.Name = "btnWechseln";
            this.btnWechseln.Size = new System.Drawing.Size(27, 23);
            this.btnWechseln.TabIndex = 2;
            this.btnWechseln.UseVisualStyleBackColor = true;
            this.btnWechseln.Click += new System.EventHandler(this.btnWechseln_Click);
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
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "frmOevApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "öV App";
            this.tabInhaltssteuerelement.ResumeLayout(false);
            this.tabAkutelleVerbindungen.ResumeLayout(false);
            this.grpVerbindungseingabe.ResumeLayout(false);
            this.grpVerbindungseingabe.PerformLayout();
            this.grpVerbindungsabfahrten.ResumeLayout(false);
            this.tabAbfahrtsmonitor.ResumeLayout(false);
            this.grpMonitoreingabe.ResumeLayout(false);
            this.grpMonitoreingabe.PerformLayout();
            this.grpMonitorabfahrten.ResumeLayout(false);
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
    }
}
