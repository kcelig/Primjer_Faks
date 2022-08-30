namespace Primjer_Faks
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbZenski = new System.Windows.Forms.RadioButton();
            this.rbMuski = new System.Windows.Forms.RadioButton();
            this.cbSmjer = new System.Windows.Forms.ComboBox();
            this.chkPutnik = new System.Windows.Forms.CheckBox();
            this.nuRazred = new System.Windows.Forms.NumericUpDown();
            this.lbUcenici = new System.Windows.Forms.ListBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spremiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otvoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zatvoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuRazred)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum rođenja:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Smjer:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(309, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Razred:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(393, 164);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(119, 49);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(155, 20);
            this.txtIme.TabIndex = 8;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(119, 81);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(155, 20);
            this.txtPrezime.TabIndex = 9;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(120, 115);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(154, 20);
            this.dtpDatum.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbZenski);
            this.groupBox1.Controls.Add(this.rbMuski);
            this.groupBox1.Location = new System.Drawing.Point(28, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 52);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spol:";
            // 
            // rbZenski
            // 
            this.rbZenski.AutoSize = true;
            this.rbZenski.Location = new System.Drawing.Point(83, 19);
            this.rbZenski.Name = "rbZenski";
            this.rbZenski.Size = new System.Drawing.Size(57, 17);
            this.rbZenski.TabIndex = 1;
            this.rbZenski.Text = "Ženski";
            this.rbZenski.UseVisualStyleBackColor = true;
            // 
            // rbMuski
            // 
            this.rbMuski.AutoSize = true;
            this.rbMuski.Checked = true;
            this.rbMuski.Location = new System.Drawing.Point(12, 19);
            this.rbMuski.Name = "rbMuski";
            this.rbMuski.Size = new System.Drawing.Size(53, 17);
            this.rbMuski.TabIndex = 0;
            this.rbMuski.TabStop = true;
            this.rbMuski.Text = "Muški";
            this.rbMuski.UseVisualStyleBackColor = true;
            // 
            // cbSmjer
            // 
            this.cbSmjer.FormattingEnabled = true;
            this.cbSmjer.Items.AddRange(new object[] {
            "Elektrotehnika",
            "Strojarstvo",
            "Graditeljstvo",
            "Gimnazija"});
            this.cbSmjer.Location = new System.Drawing.Point(394, 49);
            this.cbSmjer.Name = "cbSmjer";
            this.cbSmjer.Size = new System.Drawing.Size(155, 21);
            this.cbSmjer.TabIndex = 12;
            // 
            // chkPutnik
            // 
            this.chkPutnik.AutoSize = true;
            this.chkPutnik.Location = new System.Drawing.Point(394, 117);
            this.chkPutnik.Name = "chkPutnik";
            this.chkPutnik.Size = new System.Drawing.Size(56, 17);
            this.chkPutnik.TabIndex = 13;
            this.chkPutnik.Text = "Putnik";
            this.chkPutnik.UseVisualStyleBackColor = true;
            // 
            // nuRazred
            // 
            this.nuRazred.Location = new System.Drawing.Point(394, 81);
            this.nuRazred.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nuRazred.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuRazred.Name = "nuRazred";
            this.nuRazred.Size = new System.Drawing.Size(59, 20);
            this.nuRazred.TabIndex = 14;
            this.nuRazred.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbUcenici
            // 
            this.lbUcenici.FormattingEnabled = true;
            this.lbUcenici.Location = new System.Drawing.Point(37, 223);
            this.lbUcenici.Name = "lbUcenici";
            this.lbUcenici.ScrollAlwaysVisible = true;
            this.lbUcenici.Size = new System.Drawing.Size(512, 147);
            this.lbUcenici.TabIndex = 15;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(474, 164);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 16;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnOcisti_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(601, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datotekaToolStripMenuItem
            // 
            this.datotekaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spremiToolStripMenuItem,
            this.otvoriToolStripMenuItem,
            this.zatvoriToolStripMenuItem});
            this.datotekaToolStripMenuItem.Name = "datotekaToolStripMenuItem";
            this.datotekaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.datotekaToolStripMenuItem.Text = "Datoteka";
            // 
            // spremiToolStripMenuItem
            // 
            this.spremiToolStripMenuItem.Name = "spremiToolStripMenuItem";
            this.spremiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.spremiToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.spremiToolStripMenuItem.Text = "Spremi";
            this.spremiToolStripMenuItem.Click += new System.EventHandler(this.spremiToolStripMenuItem_Click);
            // 
            // otvoriToolStripMenuItem
            // 
            this.otvoriToolStripMenuItem.Name = "otvoriToolStripMenuItem";
            this.otvoriToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.otvoriToolStripMenuItem.Text = "Otvori";
            this.otvoriToolStripMenuItem.Click += new System.EventHandler(this.otvoriToolStripMenuItem_Click);
            // 
            // zatvoriToolStripMenuItem
            // 
            this.zatvoriToolStripMenuItem.Name = "zatvoriToolStripMenuItem";
            this.zatvoriToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.zatvoriToolStripMenuItem.Text = "Zatvori";
            this.zatvoriToolStripMenuItem.Click += new System.EventHandler(this.zatvoriToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Tekstualne datoteke|*.txt";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Tekstualne datoteke|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 421);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.lbUcenici);
            this.Controls.Add(this.nuRazred);
            this.Controls.Add(this.chkPutnik);
            this.Controls.Add(this.cbSmjer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evidencija učenika";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuRazred)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbZenski;
        private System.Windows.Forms.RadioButton rbMuski;
        private System.Windows.Forms.ComboBox cbSmjer;
        private System.Windows.Forms.CheckBox chkPutnik;
        private System.Windows.Forms.NumericUpDown nuRazred;
        private System.Windows.Forms.ListBox lbUcenici;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spremiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otvoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zatvoriToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

