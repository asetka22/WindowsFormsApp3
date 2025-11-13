namespace WindowsFormsApp3
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
            this.rbDesktop = new System.Windows.Forms.RadioButton();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.gbProizvodi = new System.Windows.Forms.GroupBox();
            this.rbLaptop = new System.Windows.Forms.RadioButton();
            this.rbMobilni = new System.Windows.Forms.RadioButton();
            this.rbGPS = new System.Windows.Forms.RadioButton();
            this.lblMemorija = new System.Windows.Forms.Label();
            this.lblProcesor = new System.Windows.Forms.Label();
            this.lblProizvodac = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.cbEuro = new System.Windows.Forms.CheckBox();
            this.cbKuna = new System.Windows.Forms.CheckBox();
            this.gbPlacanje = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbKartice = new System.Windows.Forms.ListBox();
            this.gbOsobniPodaci = new System.Windows.Forms.GroupBox();
            this.lblImePrezime = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.mtbZiroRacun = new System.Windows.Forms.MaskedTextBox();
            this.mKalendar = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.gbProizvodi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.gbPlacanje.SuspendLayout();
            this.gbOsobniPodaci.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.Location = new System.Drawing.Point(216, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Online kupovina";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbDesktop
            // 
            this.rbDesktop.AutoSize = true;
            this.rbDesktop.Location = new System.Drawing.Point(6, 19);
            this.rbDesktop.Name = "rbDesktop";
            this.rbDesktop.Size = new System.Drawing.Size(109, 17);
            this.rbDesktop.TabIndex = 1;
            this.rbDesktop.TabStop = true;
            this.rbDesktop.Text = "Desktop racunalo";
            this.rbDesktop.UseVisualStyleBackColor = true;
            this.rbDesktop.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // gbProizvodi
            // 
            this.gbProizvodi.Controls.Add(this.rbGPS);
            this.gbProizvodi.Controls.Add(this.rbMobilni);
            this.gbProizvodi.Controls.Add(this.rbLaptop);
            this.gbProizvodi.Controls.Add(this.rbDesktop);
            this.gbProizvodi.Location = new System.Drawing.Point(12, 24);
            this.gbProizvodi.Name = "gbProizvodi";
            this.gbProizvodi.Size = new System.Drawing.Size(125, 126);
            this.gbProizvodi.TabIndex = 2;
            this.gbProizvodi.TabStop = false;
            this.gbProizvodi.Text = "Proizvodi";
            this.gbProizvodi.Enter += new System.EventHandler(this.gbProizvodi_Enter);
            // 
            // rbLaptop
            // 
            this.rbLaptop.AutoSize = true;
            this.rbLaptop.Location = new System.Drawing.Point(6, 42);
            this.rbLaptop.Name = "rbLaptop";
            this.rbLaptop.Size = new System.Drawing.Size(58, 17);
            this.rbLaptop.TabIndex = 2;
            this.rbLaptop.TabStop = true;
            this.rbLaptop.Text = "Laptop";
            this.rbLaptop.UseVisualStyleBackColor = true;
            // 
            // rbMobilni
            // 
            this.rbMobilni.AutoSize = true;
            this.rbMobilni.Location = new System.Drawing.Point(6, 65);
            this.rbMobilni.Name = "rbMobilni";
            this.rbMobilni.Size = new System.Drawing.Size(91, 17);
            this.rbMobilni.TabIndex = 3;
            this.rbMobilni.TabStop = true;
            this.rbMobilni.Text = "Mobilni uređaj";
            this.rbMobilni.UseVisualStyleBackColor = true;
            // 
            // rbGPS
            // 
            this.rbGPS.AutoSize = true;
            this.rbGPS.Location = new System.Drawing.Point(6, 88);
            this.rbGPS.Name = "rbGPS";
            this.rbGPS.Size = new System.Drawing.Size(80, 17);
            this.rbGPS.TabIndex = 4;
            this.rbGPS.TabStop = true;
            this.rbGPS.Text = "GPS uređaj";
            this.rbGPS.UseVisualStyleBackColor = true;
            this.rbGPS.CheckedChanged += new System.EventHandler(this.rbGPS_CheckedChanged);
            // 
            // lblMemorija
            // 
            this.lblMemorija.AutoSize = true;
            this.lblMemorija.Location = new System.Drawing.Point(173, 137);
            this.lblMemorija.Name = "lblMemorija";
            this.lblMemorija.Size = new System.Drawing.Size(52, 13);
            this.lblMemorija.TabIndex = 5;
            this.lblMemorija.Text = "Memorija:";
            this.lblMemorija.Visible = false;
            // 
            // lblProcesor
            // 
            this.lblProcesor.AutoSize = true;
            this.lblProcesor.Location = new System.Drawing.Point(173, 93);
            this.lblProcesor.Name = "lblProcesor";
            this.lblProcesor.Size = new System.Drawing.Size(52, 13);
            this.lblProcesor.TabIndex = 6;
            this.lblProcesor.Text = "Procesor:";
            this.lblProcesor.Visible = false;
            // 
            // lblProizvodac
            // 
            this.lblProizvodac.AutoSize = true;
            this.lblProizvodac.Location = new System.Drawing.Point(173, 47);
            this.lblProizvodac.Name = "lblProizvodac";
            this.lblProizvodac.Size = new System.Drawing.Size(64, 13);
            this.lblProizvodac.TabIndex = 7;
            this.lblProizvodac.Text = "Proizvođač:";
            this.lblProizvodac.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(176, 153);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(176, 112);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(171, 21);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.Visible = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(176, 66);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(171, 21);
            this.comboBox3.TabIndex = 10;
            this.comboBox3.Visible = false;
            // 
            // pbSlika
            // 
            this.pbSlika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSlika.Location = new System.Drawing.Point(361, 24);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(225, 202);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 11;
            this.pbSlika.TabStop = false;
            // 
            // cbEuro
            // 
            this.cbEuro.AutoSize = true;
            this.cbEuro.Location = new System.Drawing.Point(6, 19);
            this.cbEuro.Name = "cbEuro";
            this.cbEuro.Size = new System.Drawing.Size(48, 17);
            this.cbEuro.TabIndex = 12;
            this.cbEuro.Text = "Euro";
            this.cbEuro.UseVisualStyleBackColor = true;
            this.cbEuro.CheckedChanged += new System.EventHandler(this.cbEuro_CheckedChanged);
            // 
            // cbKuna
            // 
            this.cbKuna.AutoSize = true;
            this.cbKuna.Location = new System.Drawing.Point(68, 19);
            this.cbKuna.Name = "cbKuna";
            this.cbKuna.Size = new System.Drawing.Size(51, 17);
            this.cbKuna.TabIndex = 14;
            this.cbKuna.Text = "Kuna";
            this.cbKuna.UseVisualStyleBackColor = true;
            this.cbKuna.CheckedChanged += new System.EventHandler(this.cbKuna_CheckedChanged);
            // 
            // gbPlacanje
            // 
            this.gbPlacanje.Controls.Add(this.gbOsobniPodaci);
            this.gbPlacanje.Controls.Add(this.lbKartice);
            this.gbPlacanje.Controls.Add(this.label2);
            this.gbPlacanje.Controls.Add(this.cbKuna);
            this.gbPlacanje.Controls.Add(this.cbEuro);
            this.gbPlacanje.Location = new System.Drawing.Point(18, 192);
            this.gbPlacanje.Name = "gbPlacanje";
            this.gbPlacanje.Size = new System.Drawing.Size(322, 187);
            this.gbPlacanje.TabIndex = 15;
            this.gbPlacanje.TabStop = false;
            this.gbPlacanje.Text = "Placanje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Placanje karticom:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbKartice
            // 
            this.lbKartice.FormattingEnabled = true;
            this.lbKartice.Location = new System.Drawing.Point(4, 66);
            this.lbKartice.Name = "lbKartice";
            this.lbKartice.Size = new System.Drawing.Size(105, 108);
            this.lbKartice.TabIndex = 16;
            // 
            // gbOsobniPodaci
            // 
            this.gbOsobniPodaci.Controls.Add(this.mtbZiroRacun);
            this.gbOsobniPodaci.Controls.Add(this.lblImePrezime);
            this.gbOsobniPodaci.Controls.Add(this.lblAdresa);
            this.gbOsobniPodaci.Controls.Add(this.label5);
            this.gbOsobniPodaci.Controls.Add(this.textBox1);
            this.gbOsobniPodaci.Controls.Add(this.textBox2);
            this.gbOsobniPodaci.Location = new System.Drawing.Point(125, 18);
            this.gbOsobniPodaci.Name = "gbOsobniPodaci";
            this.gbOsobniPodaci.Size = new System.Drawing.Size(192, 156);
            this.gbOsobniPodaci.TabIndex = 17;
            this.gbOsobniPodaci.TabStop = false;
            this.gbOsobniPodaci.Text = "Osobni podatci:";
            this.gbOsobniPodaci.Enter += new System.EventHandler(this.gbOsobniPodaci_Enter);
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.AutoSize = true;
            this.lblImePrezime.Location = new System.Drawing.Point(6, 16);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(71, 13);
            this.lblImePrezime.TabIndex = 16;
            this.lblImePrezime.Text = "Ime i prezime:";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(6, 57);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(43, 13);
            this.lblAdresa.TabIndex = 17;
            this.lblAdresa.Text = "Adresa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Žiro račun:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 20);
            this.textBox1.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 20);
            this.textBox2.TabIndex = 20;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // mtbZiroRacun
            // 
            this.mtbZiroRacun.Location = new System.Drawing.Point(9, 112);
            this.mtbZiroRacun.Mask = "000-0000000000000-00";
            this.mtbZiroRacun.Name = "mtbZiroRacun";
            this.mtbZiroRacun.Size = new System.Drawing.Size(179, 20);
            this.mtbZiroRacun.TabIndex = 21;
            // 
            // mKalendar
            // 
            this.mKalendar.Location = new System.Drawing.Point(361, 238);
            this.mKalendar.Name = "mKalendar";
            this.mKalendar.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 429);
            this.Controls.Add(this.mKalendar);
            this.Controls.Add(this.gbPlacanje);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.lblMemorija);
            this.Controls.Add(this.lblProcesor);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.gbProizvodi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProizvodac);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            this.gbProizvodi.ResumeLayout(false);
            this.gbProizvodi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.gbPlacanje.ResumeLayout(false);
            this.gbPlacanje.PerformLayout();
            this.gbOsobniPodaci.ResumeLayout(false);
            this.gbOsobniPodaci.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbDesktop;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.GroupBox gbProizvodi;
        private System.Windows.Forms.RadioButton rbGPS;
        private System.Windows.Forms.RadioButton rbMobilni;
        private System.Windows.Forms.RadioButton rbLaptop;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblProcesor;
        private System.Windows.Forms.Label lblMemorija;
        private System.Windows.Forms.Label lblProizvodac;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.CheckBox cbEuro;
        private System.Windows.Forms.CheckBox cbKuna;
        private System.Windows.Forms.GroupBox gbPlacanje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbOsobniPodaci;
        private System.Windows.Forms.ListBox lbKartice;
        private System.Windows.Forms.Label lblImePrezime;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MaskedTextBox mtbZiroRacun;
        private System.Windows.Forms.MonthCalendar mKalendar;
    }
}

