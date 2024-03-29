﻿namespace DLWMS.WinForms.Studenti
{
    partial class frmStudentNovi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentNovi));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbSlikaStudenta = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBrojIndeksa = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenerisiLozinku = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cbAktivan = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.btnUcitajSliku = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbGodinaStudija = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSpol = new System.Windows.Forms.ComboBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDodajUlogu = new System.Windows.Forms.Button();
            this.dgvUloge = new System.Windows.Forms.DataGridView();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbUloge = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaStudenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUloge)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pbSlikaStudenta
            // 
            this.pbSlikaStudenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSlikaStudenta.Location = new System.Drawing.Point(19, 131);
            this.pbSlikaStudenta.Name = "pbSlikaStudenta";
            this.pbSlikaStudenta.Size = new System.Drawing.Size(212, 219);
            this.pbSlikaStudenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlikaStudenta.TabIndex = 24;
            this.pbSlikaStudenta.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(87, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(267, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 84);
            this.label3.TabIndex = 23;
            this.label3.Text = "Univerzitet \"Džemal Bijedić\"\r\nFakultet informacijskih tehnologija\r\nMostar";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Broj indeksa:";
            // 
            // txtBrojIndeksa
            // 
            this.txtBrojIndeksa.Location = new System.Drawing.Point(103, 18);
            this.txtBrojIndeksa.Name = "txtBrojIndeksa";
            this.txtBrojIndeksa.Size = new System.Drawing.Size(304, 23);
            this.txtBrojIndeksa.TabIndex = 0;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(901, 459);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(111, 23);
            this.btnSacuvaj.TabIndex = 21;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtBrojIndeksa);
            this.groupBox1.Controls.Add(this.btnGenerisiLozinku);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.cbAktivan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLozinka);
            this.groupBox1.Location = new System.Drawing.Point(237, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 129);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Korisnički podaci";
            // 
            // btnGenerisiLozinku
            // 
            this.btnGenerisiLozinku.Location = new System.Drawing.Point(376, 76);
            this.btnGenerisiLozinku.Name = "btnGenerisiLozinku";
            this.btnGenerisiLozinku.Size = new System.Drawing.Size(31, 23);
            this.btnGenerisiLozinku.TabIndex = 4;
            this.btnGenerisiLozinku.Text = "G";
            this.btnGenerisiLozinku.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(103, 47);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(304, 23);
            this.txtEmail.TabIndex = 1;
            // 
            // cbAktivan
            // 
            this.cbAktivan.AutoSize = true;
            this.cbAktivan.Location = new System.Drawing.Point(103, 106);
            this.cbAktivan.Name = "cbAktivan";
            this.cbAktivan.Size = new System.Drawing.Size(66, 19);
            this.cbAktivan.TabIndex = 3;
            this.cbAktivan.Text = "Aktivan";
            this.cbAktivan.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lozinka:";
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(103, 76);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(267, 23);
            this.txtLozinka.TabIndex = 2;
            // 
            // btnUcitajSliku
            // 
            this.btnUcitajSliku.Location = new System.Drawing.Point(19, 358);
            this.btnUcitajSliku.Name = "btnUcitajSliku";
            this.btnUcitajSliku.Size = new System.Drawing.Size(212, 23);
            this.btnUcitajSliku.TabIndex = 20;
            this.btnUcitajSliku.Text = "Učitaj sliku";
            this.btnUcitajSliku.UseVisualStyleBackColor = true;
            this.btnUcitajSliku.Click += new System.EventHandler(this.btnUcitajSliku_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Godina studija:";
            // 
            // cmbGodinaStudija
            // 
            this.cmbGodinaStudija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGodinaStudija.FormattingEnabled = true;
            this.cmbGodinaStudija.Location = new System.Drawing.Point(103, 115);
            this.cmbGodinaStudija.Name = "cmbGodinaStudija";
            this.cmbGodinaStudija.Size = new System.Drawing.Size(193, 23);
            this.cmbGodinaStudija.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Datum rođenja:";
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(103, 85);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(193, 23);
            this.dtpDatumRodjenja.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ime:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(103, 25);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(304, 23);
            this.txtIme.TabIndex = 0;
            this.txtIme.TextChanged += new System.EventHandler(this.txtIme_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Prezime:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(103, 55);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(304, 23);
            this.txtPrezime.TabIndex = 1;
            this.txtPrezime.TextChanged += new System.EventHandler(this.txtPrezime_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbSpol);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cmbGodinaStudija);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dtpDatumRodjenja);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtIme);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtPrezime);
            this.groupBox2.Location = new System.Drawing.Point(237, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 173);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Podaci o studentu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Spol";
            // 
            // cmbSpol
            // 
            this.cmbSpol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpol.FormattingEnabled = true;
            this.cmbSpol.Location = new System.Drawing.Point(103, 144);
            this.cmbSpol.Name = "cmbSpol";
            this.cmbSpol.Size = new System.Drawing.Size(193, 23);
            this.cmbSpol.TabIndex = 17;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDodajUlogu);
            this.groupBox3.Controls.Add(this.dgvUloge);
            this.groupBox3.Controls.Add(this.cmbUloge);
            this.groupBox3.Location = new System.Drawing.Point(687, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 302);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Uloge";
            // 
            // btnDodajUlogu
            // 
            this.btnDodajUlogu.Location = new System.Drawing.Point(199, 32);
            this.btnDodajUlogu.Name = "btnDodajUlogu";
            this.btnDodajUlogu.Size = new System.Drawing.Size(116, 23);
            this.btnDodajUlogu.TabIndex = 26;
            this.btnDodajUlogu.Text = "Dodaj ulogu";
            this.btnDodajUlogu.UseVisualStyleBackColor = true;
            this.btnDodajUlogu.Click += new System.EventHandler(this.btnDodajUlogu_Click);
            // 
            // dgvUloge
            // 
            this.dgvUloge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUloge.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv});
            this.dgvUloge.Location = new System.Drawing.Point(16, 89);
            this.dgvUloge.Name = "dgvUloge";
            this.dgvUloge.RowTemplate.Height = 25;
            this.dgvUloge.Size = new System.Drawing.Size(299, 106);
            this.dgvUloge.TabIndex = 27;
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Uloga";
            this.Naziv.Name = "Naziv";
            // 
            // cmbUloge
            // 
            this.cmbUloge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUloge.FormattingEnabled = true;
            this.cmbUloge.Location = new System.Drawing.Point(16, 33);
            this.cmbUloge.Name = "cmbUloge";
            this.cmbUloge.Size = new System.Drawing.Size(162, 23);
            this.cmbUloge.TabIndex = 19;
            // 
            // frmStudentNovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 494);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pbSlikaStudenta);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUcitajSliku);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmStudentNovi";
            this.Text = "frmStudentNovi";
            this.Load += new System.EventHandler(this.frmStudentNovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaStudenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUloge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private PictureBox pbSlikaStudenta;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label6;
        private TextBox txtBrojIndeksa;
        private Button btnSacuvaj;
        private GroupBox groupBox1;
        private Button btnGenerisiLozinku;
        private Label label4;
        private TextBox txtEmail;
        private CheckBox cbAktivan;
        private Label label2;
        private TextBox txtLozinka;
        private Button btnUcitajSliku;
        private Label label9;
        private ComboBox cmbGodinaStudija;
        private Label label8;
        private DateTimePicker dtpDatumRodjenja;
        private Label label5;
        private TextBox txtIme;
        private Label label7;
        private TextBox txtPrezime;
        private GroupBox groupBox2;
        private ErrorProvider err;
        private Label label1;
        private ComboBox cmbSpol;
        private GroupBox groupBox3;
        private Button btnDodajUlogu;
        private DataGridView dgvUloge;
        private DataGridViewTextBoxColumn Naziv;
        private ComboBox cmbUloge;
    }
}