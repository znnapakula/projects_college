namespace Przychodnia
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
            this.czynnosc = new System.Windows.Forms.Button();
            this.pracownicy = new System.Windows.Forms.Button();
            this.gabinety = new System.Windows.Forms.Button();
            this.pacjenci = new System.Windows.Forms.Button();
            this.datyIGodzinyPracy = new System.Windows.Forms.Button();
            this.zaplanowane = new System.Windows.Forms.Button();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.buttonWczytaj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // czynnosc
            // 
            this.czynnosc.Location = new System.Drawing.Point(37, 36);
            this.czynnosc.Name = "czynnosc";
            this.czynnosc.Size = new System.Drawing.Size(128, 63);
            this.czynnosc.TabIndex = 1;
            this.czynnosc.Text = "Czynności medyczne";
            this.czynnosc.UseVisualStyleBackColor = true;
            this.czynnosc.Click += new System.EventHandler(this.czynnosc_Click);
            // 
            // pracownicy
            // 
            this.pracownicy.Location = new System.Drawing.Point(37, 129);
            this.pracownicy.Name = "pracownicy";
            this.pracownicy.Size = new System.Drawing.Size(128, 62);
            this.pracownicy.TabIndex = 2;
            this.pracownicy.Text = "Pracownicy";
            this.pracownicy.UseVisualStyleBackColor = true;
            this.pracownicy.Click += new System.EventHandler(this.pracownicy_Click);
            // 
            // gabinety
            // 
            this.gabinety.Location = new System.Drawing.Point(37, 219);
            this.gabinety.Name = "gabinety";
            this.gabinety.Size = new System.Drawing.Size(128, 59);
            this.gabinety.TabIndex = 3;
            this.gabinety.Text = "Gabinety";
            this.gabinety.UseVisualStyleBackColor = true;
            this.gabinety.Click += new System.EventHandler(this.gabinety_Click);
            // 
            // pacjenci
            // 
            this.pacjenci.Location = new System.Drawing.Point(224, 36);
            this.pacjenci.Name = "pacjenci";
            this.pacjenci.Size = new System.Drawing.Size(131, 63);
            this.pacjenci.TabIndex = 4;
            this.pacjenci.Text = "Pacjenci";
            this.pacjenci.UseVisualStyleBackColor = true;
            this.pacjenci.Click += new System.EventHandler(this.pacjenci_Click);
            // 
            // datyIGodzinyPracy
            // 
            this.datyIGodzinyPracy.Location = new System.Drawing.Point(224, 129);
            this.datyIGodzinyPracy.Name = "datyIGodzinyPracy";
            this.datyIGodzinyPracy.Size = new System.Drawing.Size(131, 62);
            this.datyIGodzinyPracy.TabIndex = 5;
            this.datyIGodzinyPracy.Text = "Daty i godziny pracy";
            this.datyIGodzinyPracy.UseVisualStyleBackColor = true;
            this.datyIGodzinyPracy.Click += new System.EventHandler(this.datyIGodzinyPracy_Click);
            // 
            // zaplanowane
            // 
            this.zaplanowane.Location = new System.Drawing.Point(224, 219);
            this.zaplanowane.Name = "zaplanowane";
            this.zaplanowane.Size = new System.Drawing.Size(131, 59);
            this.zaplanowane.TabIndex = 6;
            this.zaplanowane.Text = "Zaplanowane czynności";
            this.zaplanowane.UseVisualStyleBackColor = true;
            this.zaplanowane.Click += new System.EventHandler(this.zaplanowane_Click);
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Location = new System.Drawing.Point(17, 48);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(176, 23);
            this.buttonZapisz.TabIndex = 7;
            this.buttonZapisz.Text = "Zapisz";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);
            // 
            // buttonWczytaj
            // 
            this.buttonWczytaj.Location = new System.Drawing.Point(224, 48);
            this.buttonWczytaj.Name = "buttonWczytaj";
            this.buttonWczytaj.Size = new System.Drawing.Size(169, 23);
            this.buttonWczytaj.TabIndex = 8;
            this.buttonWczytaj.Text = "Wczytaj";
            this.buttonWczytaj.UseVisualStyleBackColor = true;
            this.buttonWczytaj.Click += new System.EventHandler(this.buttonWczytaj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.buttonWczytaj);
            this.groupBox1.Controls.Add(this.buttonZapisz);
            this.groupBox1.Location = new System.Drawing.Point(-5, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 411);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.zaplanowane);
            this.Controls.Add(this.datyIGodzinyPracy);
            this.Controls.Add(this.pacjenci);
            this.Controls.Add(this.gabinety);
            this.Controls.Add(this.pracownicy);
            this.Controls.Add(this.czynnosc);
            this.Name = "Form1";
            this.Text = "Okno edycji";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button czynnosc;
        private System.Windows.Forms.Button pracownicy;
        private System.Windows.Forms.Button gabinety;
        private System.Windows.Forms.Button pacjenci;
        private System.Windows.Forms.Button datyIGodzinyPracy;
        private System.Windows.Forms.Button zaplanowane;
        private System.Windows.Forms.Button buttonZapisz;
        private System.Windows.Forms.Button buttonWczytaj;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

