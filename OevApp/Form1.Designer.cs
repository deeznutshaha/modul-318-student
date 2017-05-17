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
            this.tabInhaltsteuerung = new System.Windows.Forms.TabControl();
            this.tabAkutelleVerbindungen = new System.Windows.Forms.TabPage();
            this.grpEingabe = new System.Windows.Forms.GroupBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnSucheStation = new System.Windows.Forms.Button();
            this.cmbEndstation = new System.Windows.Forms.ComboBox();
            this.cmbStartstation = new System.Windows.Forms.ComboBox();
            this.lblZielstation = new System.Windows.Forms.Label();
            this.lblStartstation = new System.Windows.Forms.Label();
            this.grpAbfahrten = new System.Windows.Forms.GroupBox();
            this.lstAbfahrten = new System.Windows.Forms.ListView();
            this.colAbfahrt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAnkunft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDauer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabAbfahrtsmonitor = new System.Windows.Forms.TabPage();
            this.grpEingabeMonitor = new System.Windows.Forms.GroupBox();
            this.cmbStartMonitor = new System.Windows.Forms.ComboBox();
            this.lblStartMonitor = new System.Windows.Forms.Label();
            this.grpAbfahrtenMonitor = new System.Windows.Forms.GroupBox();
            this.colPlattform = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSucheMonitor = new System.Windows.Forms.Button();
            this.btnGoMonitor = new System.Windows.Forms.Button();
            this.lstAbfahrtenMonitor = new System.Windows.Forms.ListView();
            this.colBusnummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAbfahrtszeit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colZielort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabInhaltsteuerung.SuspendLayout();
            this.tabAkutelleVerbindungen.SuspendLayout();
            this.grpEingabe.SuspendLayout();
            this.grpAbfahrten.SuspendLayout();
            this.tabAbfahrtsmonitor.SuspendLayout();
            this.grpEingabeMonitor.SuspendLayout();
            this.grpAbfahrtenMonitor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabInhaltsteuerung
            // 
            this.tabInhaltsteuerung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabInhaltsteuerung.Controls.Add(this.tabAkutelleVerbindungen);
            this.tabInhaltsteuerung.Controls.Add(this.tabAbfahrtsmonitor);
            this.tabInhaltsteuerung.Location = new System.Drawing.Point(12, 12);
            this.tabInhaltsteuerung.Multiline = true;
            this.tabInhaltsteuerung.Name = "tabInhaltsteuerung";
            this.tabInhaltsteuerung.SelectedIndex = 0;
            this.tabInhaltsteuerung.Size = new System.Drawing.Size(460, 437);
            this.tabInhaltsteuerung.TabIndex = 0;
            // 
            // tabAkutelleVerbindungen
            // 
            this.tabAkutelleVerbindungen.Controls.Add(this.grpEingabe);
            this.tabAkutelleVerbindungen.Controls.Add(this.grpAbfahrten);
            this.tabAkutelleVerbindungen.Location = new System.Drawing.Point(4, 22);
            this.tabAkutelleVerbindungen.Name = "tabAkutelleVerbindungen";
            this.tabAkutelleVerbindungen.Padding = new System.Windows.Forms.Padding(3);
            this.tabAkutelleVerbindungen.Size = new System.Drawing.Size(452, 411);
            this.tabAkutelleVerbindungen.TabIndex = 0;
            this.tabAkutelleVerbindungen.Text = "Akutelle Verbindungen";
            this.tabAkutelleVerbindungen.UseVisualStyleBackColor = true;
            // 
            // grpEingabe
            // 
            this.grpEingabe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEingabe.Controls.Add(this.btnGo);
            this.grpEingabe.Controls.Add(this.btnSucheStation);
            this.grpEingabe.Controls.Add(this.cmbEndstation);
            this.grpEingabe.Controls.Add(this.cmbStartstation);
            this.grpEingabe.Controls.Add(this.lblZielstation);
            this.grpEingabe.Controls.Add(this.lblStartstation);
            this.grpEingabe.Location = new System.Drawing.Point(4, 11);
            this.grpEingabe.MinimumSize = new System.Drawing.Size(444, 119);
            this.grpEingabe.Name = "grpEingabe";
            this.grpEingabe.Size = new System.Drawing.Size(444, 119);
            this.grpEingabe.TabIndex = 2;
            this.grpEingabe.TabStop = false;
            this.grpEingabe.Text = "Eingabe";
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
            // btnSucheStation
            // 
            this.btnSucheStation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSucheStation.Location = new System.Drawing.Point(374, 30);
            this.btnSucheStation.Name = "btnSucheStation";
            this.btnSucheStation.Size = new System.Drawing.Size(64, 48);
            this.btnSucheStation.TabIndex = 2;
            this.btnSucheStation.Text = "Suche Stationen";
            this.btnSucheStation.UseVisualStyleBackColor = true;
            this.btnSucheStation.Click += new System.EventHandler(this.btnSucheStation_Click);
            // 
            // cmbEndstation
            // 
            this.cmbEndstation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEndstation.FormattingEnabled = true;
            this.cmbEndstation.Location = new System.Drawing.Point(85, 57);
            this.cmbEndstation.Name = "cmbEndstation";
            this.cmbEndstation.Size = new System.Drawing.Size(283, 21);
            this.cmbEndstation.TabIndex = 1;
            // 
            // cmbStartstation
            // 
            this.cmbStartstation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStartstation.FormattingEnabled = true;
            this.cmbStartstation.Location = new System.Drawing.Point(85, 30);
            this.cmbStartstation.Name = "cmbStartstation";
            this.cmbStartstation.Size = new System.Drawing.Size(283, 21);
            this.cmbStartstation.TabIndex = 0;
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
            // grpAbfahrten
            // 
            this.grpAbfahrten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAbfahrten.Controls.Add(this.lstAbfahrten);
            this.grpAbfahrten.Location = new System.Drawing.Point(4, 136);
            this.grpAbfahrten.Name = "grpAbfahrten";
            this.grpAbfahrten.Size = new System.Drawing.Size(444, 264);
            this.grpAbfahrten.TabIndex = 3;
            this.grpAbfahrten.TabStop = false;
            this.grpAbfahrten.Text = "Abfahrten";
            // 
            // lstAbfahrten
            // 
            this.lstAbfahrten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstAbfahrten.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPlattform,
            this.colAbfahrt,
            this.colAnkunft,
            this.colDauer});
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
            // colAnkunft
            // 
            this.colAnkunft.Text = "Ankunft";
            this.colAnkunft.Width = 49;
            // 
            // colDauer
            // 
            this.colDauer.Text = "Dauer";
            this.colDauer.Width = 277;
            // 
            // tabAbfahrtsmonitor
            // 
            this.tabAbfahrtsmonitor.Controls.Add(this.btnGoMonitor);
            this.tabAbfahrtsmonitor.Controls.Add(this.grpEingabeMonitor);
            this.tabAbfahrtsmonitor.Controls.Add(this.grpAbfahrtenMonitor);
            this.tabAbfahrtsmonitor.Location = new System.Drawing.Point(4, 22);
            this.tabAbfahrtsmonitor.Name = "tabAbfahrtsmonitor";
            this.tabAbfahrtsmonitor.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbfahrtsmonitor.Size = new System.Drawing.Size(452, 411);
            this.tabAbfahrtsmonitor.TabIndex = 1;
            this.tabAbfahrtsmonitor.Text = "Abfahrtsmonitor";
            this.tabAbfahrtsmonitor.UseVisualStyleBackColor = true;
            // 
            // grpEingabeMonitor
            // 
            this.grpEingabeMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEingabeMonitor.Controls.Add(this.btnSucheMonitor);
            this.grpEingabeMonitor.Controls.Add(this.cmbStartMonitor);
            this.grpEingabeMonitor.Controls.Add(this.lblStartMonitor);
            this.grpEingabeMonitor.Location = new System.Drawing.Point(4, 11);
            this.grpEingabeMonitor.Name = "grpEingabeMonitor";
            this.grpEingabeMonitor.Size = new System.Drawing.Size(444, 111);
            this.grpEingabeMonitor.TabIndex = 2;
            this.grpEingabeMonitor.TabStop = false;
            this.grpEingabeMonitor.Text = "Eingabe";
            // 
            // cmbStartMonitor
            // 
            this.cmbStartMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStartMonitor.FormattingEnabled = true;
            this.cmbStartMonitor.Location = new System.Drawing.Point(85, 30);
            this.cmbStartMonitor.Name = "cmbStartMonitor";
            this.cmbStartMonitor.Size = new System.Drawing.Size(283, 21);
            this.cmbStartMonitor.TabIndex = 0;
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
            // grpAbfahrtenMonitor
            // 
            this.grpAbfahrtenMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAbfahrtenMonitor.Controls.Add(this.lstAbfahrtenMonitor);
            this.grpAbfahrtenMonitor.Location = new System.Drawing.Point(4, 128);
            this.grpAbfahrtenMonitor.Name = "grpAbfahrtenMonitor";
            this.grpAbfahrtenMonitor.Size = new System.Drawing.Size(444, 272);
            this.grpAbfahrtenMonitor.TabIndex = 3;
            this.grpAbfahrtenMonitor.TabStop = false;
            this.grpAbfahrtenMonitor.Text = "Abfahrten";
            // 
            // colPlattform
            // 
            this.colPlattform.Text = "Plattform";
            this.colPlattform.Width = 53;
            // 
            // btnSucheMonitor
            // 
            this.btnSucheMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSucheMonitor.Location = new System.Drawing.Point(374, 30);
            this.btnSucheMonitor.Name = "btnSucheMonitor";
            this.btnSucheMonitor.Size = new System.Drawing.Size(64, 48);
            this.btnSucheMonitor.TabIndex = 3;
            this.btnSucheMonitor.Text = "Suche Stationen";
            this.btnSucheMonitor.UseVisualStyleBackColor = true;
            this.btnSucheMonitor.Click += new System.EventHandler(this.btnSucheMonitor_Click);
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
            // lstAbfahrtenMonitor
            // 
            this.lstAbfahrtenMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstAbfahrtenMonitor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colBusnummer,
            this.colAbfahrtszeit,
            this.colZielort});
            this.lstAbfahrtenMonitor.Location = new System.Drawing.Point(9, 20);
            this.lstAbfahrtenMonitor.Name = "lstAbfahrtenMonitor";
            this.lstAbfahrtenMonitor.Size = new System.Drawing.Size(433, 246);
            this.lstAbfahrtenMonitor.TabIndex = 4;
            this.lstAbfahrtenMonitor.UseCompatibleStateImageBehavior = false;
            this.lstAbfahrtenMonitor.View = System.Windows.Forms.View.Details;
            // 
            // colBusnummer
            // 
            this.colBusnummer.Text = "Busnummer";
            this.colBusnummer.Width = 67;
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
            // frmOevApp
            // 
            this.AcceptButton = this.btnSucheStation;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.tabInhaltsteuerung);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "frmOevApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "öV App";
            this.tabInhaltsteuerung.ResumeLayout(false);
            this.tabAkutelleVerbindungen.ResumeLayout(false);
            this.grpEingabe.ResumeLayout(false);
            this.grpEingabe.PerformLayout();
            this.grpAbfahrten.ResumeLayout(false);
            this.tabAbfahrtsmonitor.ResumeLayout(false);
            this.grpEingabeMonitor.ResumeLayout(false);
            this.grpEingabeMonitor.PerformLayout();
            this.grpAbfahrtenMonitor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabInhaltsteuerung;
        private System.Windows.Forms.TabPage tabAkutelleVerbindungen;
        private System.Windows.Forms.TabPage tabAbfahrtsmonitor;
        private System.Windows.Forms.GroupBox grpEingabe;
        private System.Windows.Forms.ComboBox cmbEndstation;
        private System.Windows.Forms.ComboBox cmbStartstation;
        private System.Windows.Forms.Label lblZielstation;
        private System.Windows.Forms.Label lblStartstation;
        private System.Windows.Forms.GroupBox grpAbfahrten;
        private System.Windows.Forms.GroupBox grpEingabeMonitor;
        private System.Windows.Forms.ComboBox cmbStartMonitor;
        private System.Windows.Forms.Label lblStartMonitor;
        private System.Windows.Forms.GroupBox grpAbfahrtenMonitor;
        private System.Windows.Forms.Button btnSucheStation;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ListView lstAbfahrten;
        private System.Windows.Forms.ColumnHeader colAbfahrt;
        private System.Windows.Forms.ColumnHeader colAnkunft;
        private System.Windows.Forms.ColumnHeader colDauer;
        private System.Windows.Forms.ColumnHeader colPlattform;
        private System.Windows.Forms.Button btnSucheMonitor;
        private System.Windows.Forms.Button btnGoMonitor;
        private System.Windows.Forms.ListView lstAbfahrtenMonitor;
        private System.Windows.Forms.ColumnHeader colBusnummer;
        private System.Windows.Forms.ColumnHeader colAbfahrtszeit;
        private System.Windows.Forms.ColumnHeader colZielort;
    }
}

