namespace Nekretninte_Class
{
    partial class Form2
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
            this.cbKat = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.tbKvad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbArea = new System.Windows.Forms.TextBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.tbBroj = new System.Windows.Forms.TextBox();
            this.tbGodiste = new System.Windows.Forms.TextBox();
            this.tbBrojLodja = new System.Windows.Forms.TextBox();
            this.tbBrojTerasa = new System.Windows.Forms.TextBox();
            this.tbPrikTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbBrInterfon = new System.Windows.Forms.TextBox();
            this.tbBrLift = new System.Windows.Forms.TextBox();
            this.tbBrKup = new System.Windows.Forms.TextBox();
            this.tbToal = new System.Windows.Forms.TextBox();
            this.tbParking = new System.Windows.Forms.TextBox();
            this.tbGaraza = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tbAutobus = new System.Windows.Forms.TextBox();
            this.tbTramvaj = new System.Windows.Forms.TextBox();
            this.tbTrolejbus = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tbDvoriste = new System.Windows.Forms.TextBox();
            this.rtbOpis = new System.Windows.Forms.RichTextBox();
            this.PhotoSelectDialog = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbKat
            // 
            this.cbKat.FormattingEnabled = true;
            this.cbKat.Items.AddRange(new object[] {
            "Stan",
            "Kuca",
            "Garaza",
            "Plac",
            "Poslovni prostor"});
            this.cbKat.Location = new System.Drawing.Point(12, 12);
            this.cbKat.Name = "cbKat";
            this.cbKat.Size = new System.Drawing.Size(121, 21);
            this.cbKat.TabIndex = 0;
            this.cbKat.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "POTVRDI KATEGORIJU";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Stan",
            "Apartman",
            "Salonac",
            "Penthaus",
            "Dvorisni stan"});
            this.comboBox2.Location = new System.Drawing.Point(12, 49);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(593, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 102);
            this.button2.TabIndex = 3;
            this.button2.Text = "Upisi Informacije";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbCena
            // 
            this.tbCena.Location = new System.Drawing.Point(12, 105);
            this.tbCena.Name = "tbCena";
            this.tbCena.Size = new System.Drawing.Size(100, 20);
            this.tbCena.TabIndex = 4;
            // 
            // tbKvad
            // 
            this.tbKvad.Location = new System.Drawing.Point(118, 105);
            this.tbKvad.Name = "tbKvad";
            this.tbKvad.Size = new System.Drawing.Size(100, 20);
            this.tbKvad.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kvadrati";
            // 
            // tbArea
            // 
            this.tbArea.Location = new System.Drawing.Point(224, 105);
            this.tbArea.Name = "tbArea";
            this.tbArea.Size = new System.Drawing.Size(100, 20);
            this.tbArea.TabIndex = 8;
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(333, 105);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(100, 20);
            this.tbAdresa.TabIndex = 9;
            // 
            // tbBroj
            // 
            this.tbBroj.Location = new System.Drawing.Point(439, 105);
            this.tbBroj.Name = "tbBroj";
            this.tbBroj.Size = new System.Drawing.Size(100, 20);
            this.tbBroj.TabIndex = 10;
            // 
            // tbGodiste
            // 
            this.tbGodiste.Location = new System.Drawing.Point(12, 145);
            this.tbGodiste.Name = "tbGodiste";
            this.tbGodiste.Size = new System.Drawing.Size(100, 20);
            this.tbGodiste.TabIndex = 11;
            // 
            // tbBrojLodja
            // 
            this.tbBrojLodja.Location = new System.Drawing.Point(118, 145);
            this.tbBrojLodja.Name = "tbBrojLodja";
            this.tbBrojLodja.Size = new System.Drawing.Size(100, 20);
            this.tbBrojLodja.TabIndex = 12;
            // 
            // tbBrojTerasa
            // 
            this.tbBrojTerasa.Location = new System.Drawing.Point(224, 145);
            this.tbBrojTerasa.Name = "tbBrojTerasa";
            this.tbBrojTerasa.Size = new System.Drawing.Size(100, 20);
            this.tbBrojTerasa.TabIndex = 13;
            // 
            // tbPrikTel
            // 
            this.tbPrikTel.Location = new System.Drawing.Point(333, 145);
            this.tbPrikTel.Name = "tbPrikTel";
            this.tbPrikTel.Size = new System.Drawing.Size(100, 20);
            this.tbPrikTel.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Deo grada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Adresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(445, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Broj";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Godina izgradnje";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Broj lodja";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(221, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Broj terasa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(327, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "broj prikljucka ze telefon";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(454, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "broj interfona";
            // 
            // tbBrInterfon
            // 
            this.tbBrInterfon.Location = new System.Drawing.Point(439, 145);
            this.tbBrInterfon.Name = "tbBrInterfon";
            this.tbBrInterfon.Size = new System.Drawing.Size(100, 20);
            this.tbBrInterfon.TabIndex = 23;
            // 
            // tbBrLift
            // 
            this.tbBrLift.Location = new System.Drawing.Point(12, 187);
            this.tbBrLift.Name = "tbBrLift";
            this.tbBrLift.Size = new System.Drawing.Size(100, 20);
            this.tbBrLift.TabIndex = 24;
            // 
            // tbBrKup
            // 
            this.tbBrKup.Location = new System.Drawing.Point(118, 187);
            this.tbBrKup.Name = "tbBrKup";
            this.tbBrKup.Size = new System.Drawing.Size(100, 20);
            this.tbBrKup.TabIndex = 25;
            // 
            // tbToal
            // 
            this.tbToal.Location = new System.Drawing.Point(333, 187);
            this.tbToal.Name = "tbToal";
            this.tbToal.Size = new System.Drawing.Size(100, 20);
            this.tbToal.TabIndex = 26;
            // 
            // tbParking
            // 
            this.tbParking.Location = new System.Drawing.Point(224, 187);
            this.tbParking.Name = "tbParking";
            this.tbParking.Size = new System.Drawing.Size(100, 20);
            this.tbParking.TabIndex = 27;
            // 
            // tbGaraza
            // 
            this.tbGaraza.Location = new System.Drawing.Point(439, 187);
            this.tbGaraza.Name = "tbGaraza";
            this.tbGaraza.Size = new System.Drawing.Size(100, 20);
            this.tbGaraza.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "broj liftova";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(136, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "broj kupatila";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(241, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Parking mesta";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(343, 172);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "broj toaleta";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(449, 172);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Garaza";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 215);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Broj autobuskih linija";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(134, 215);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "broj tramvaja";
            // 
            // tbAutobus
            // 
            this.tbAutobus.Location = new System.Drawing.Point(10, 232);
            this.tbAutobus.Name = "tbAutobus";
            this.tbAutobus.Size = new System.Drawing.Size(100, 20);
            this.tbAutobus.TabIndex = 36;
            // 
            // tbTramvaj
            // 
            this.tbTramvaj.Location = new System.Drawing.Point(119, 232);
            this.tbTramvaj.Name = "tbTramvaj";
            this.tbTramvaj.Size = new System.Drawing.Size(100, 20);
            this.tbTramvaj.TabIndex = 37;
            // 
            // tbTrolejbus
            // 
            this.tbTrolejbus.Location = new System.Drawing.Point(225, 232);
            this.tbTrolejbus.Name = "tbTrolejbus";
            this.tbTrolejbus.Size = new System.Drawing.Size(100, 20);
            this.tbTrolejbus.TabIndex = 38;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(241, 215);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 13);
            this.label18.TabIndex = 39;
            this.label18.Text = "broj trolejbusa";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 263);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 13);
            this.label19.TabIndex = 41;
            this.label19.Text = "Dodatni opis";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(341, 217);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 13);
            this.label20.TabIndex = 42;
            this.label20.Text = "Dvoriste";
            // 
            // tbDvoriste
            // 
            this.tbDvoriste.Location = new System.Drawing.Point(333, 233);
            this.tbDvoriste.Name = "tbDvoriste";
            this.tbDvoriste.Size = new System.Drawing.Size(100, 20);
            this.tbDvoriste.TabIndex = 43;
            // 
            // rtbOpis
            // 
            this.rtbOpis.Location = new System.Drawing.Point(12, 279);
            this.rtbOpis.Name = "rtbOpis";
            this.rtbOpis.Size = new System.Drawing.Size(739, 126);
            this.rtbOpis.TabIndex = 44;
            this.rtbOpis.Text = "";
            // 
            // PhotoSelectDialog
            // 
            this.PhotoSelectDialog.FileName = "PhotoSelectDialog";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(593, 233);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 23);
            this.button3.TabIndex = 45;
            this.button3.Text = "Upload photo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 433);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.rtbOpis);
            this.Controls.Add(this.tbDvoriste);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tbTrolejbus);
            this.Controls.Add(this.tbTramvaj);
            this.Controls.Add(this.tbAutobus);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbGaraza);
            this.Controls.Add(this.tbParking);
            this.Controls.Add(this.tbToal);
            this.Controls.Add(this.tbBrKup);
            this.Controls.Add(this.tbBrLift);
            this.Controls.Add(this.tbBrInterfon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPrikTel);
            this.Controls.Add(this.tbBrojTerasa);
            this.Controls.Add(this.tbBrojLodja);
            this.Controls.Add(this.tbGodiste);
            this.Controls.Add(this.tbBroj);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.tbArea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKvad);
            this.Controls.Add(this.tbCena);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbKat);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbCena;
        private System.Windows.Forms.TextBox tbKvad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbArea;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.TextBox tbBroj;
        private System.Windows.Forms.TextBox tbGodiste;
        private System.Windows.Forms.TextBox tbBrojLodja;
        private System.Windows.Forms.TextBox tbBrojTerasa;
        private System.Windows.Forms.TextBox tbPrikTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbBrInterfon;
        private System.Windows.Forms.TextBox tbBrLift;
        private System.Windows.Forms.TextBox tbBrKup;
        private System.Windows.Forms.TextBox tbToal;
        private System.Windows.Forms.TextBox tbParking;
        private System.Windows.Forms.TextBox tbGaraza;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbAutobus;
        private System.Windows.Forms.TextBox tbTramvaj;
        private System.Windows.Forms.TextBox tbTrolejbus;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbDvoriste;
        private System.Windows.Forms.RichTextBox rtbOpis;
        private System.Windows.Forms.OpenFileDialog PhotoSelectDialog;
        private System.Windows.Forms.Button button3;
    }
}