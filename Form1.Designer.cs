namespace Basit_hesaplama_programı
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sonuc = new System.Windows.Forms.TextBox();
            this.sil = new System.Windows.Forms.Button();
            this.bolu = new System.Windows.Forms.Button();
            this.arti = new System.Windows.Forms.Button();
            this.enter = new System.Windows.Forms.Button();
            this.çarpi = new System.Windows.Forms.Button();
            this.eksi = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.sonuc);
            this.groupBox1.Controls.Add(this.sil);
            this.groupBox1.Controls.Add(this.bolu);
            this.groupBox1.Controls.Add(this.arti);
            this.groupBox1.Controls.Add(this.enter);
            this.groupBox1.Controls.Add(this.çarpi);
            this.groupBox1.Controls.Add(this.eksi);
            this.groupBox1.Controls.Add(this.button0);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(213, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hesap Makinesi";
            // 
            // sonuc
            // 
            this.sonuc.Location = new System.Drawing.Point(30, 40);
            this.sonuc.Name = "sonuc";
            this.sonuc.Size = new System.Drawing.Size(100, 22);
            this.sonuc.TabIndex = 17;
            this.sonuc.TextChanged += new System.EventHandler(this.sonuc_TextChanged);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(222, 65);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(75, 23);
            this.sil.TabIndex = 16;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // bolu
            // 
            this.bolu.Location = new System.Drawing.Point(326, 219);
            this.bolu.Name = "bolu";
            this.bolu.Size = new System.Drawing.Size(75, 46);
            this.bolu.TabIndex = 15;
            this.bolu.Text = "/";
            this.bolu.UseVisualStyleBackColor = true;
            this.bolu.Click += new System.EventHandler(this.IslemButonu_Click);
            // 
            // arti
            // 
            this.arti.Location = new System.Drawing.Point(326, 61);
            this.arti.Name = "arti";
            this.arti.Size = new System.Drawing.Size(75, 46);
            this.arti.TabIndex = 13;
            this.arti.Text = "+";
            this.arti.UseVisualStyleBackColor = true;
            this.arti.Click += new System.EventHandler(this.IslemButonu_Click);
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(124, 225);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(173, 40);
            this.enter.TabIndex = 12;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // çarpi
            // 
            this.çarpi.Location = new System.Drawing.Point(326, 167);
            this.çarpi.Name = "çarpi";
            this.çarpi.Size = new System.Drawing.Size(75, 46);
            this.çarpi.TabIndex = 14;
            this.çarpi.Text = "x";
            this.çarpi.UseVisualStyleBackColor = true;
            this.çarpi.Click += new System.EventHandler(this.IslemButonu_Click);
            // 
            // eksi
            // 
            this.eksi.Location = new System.Drawing.Point(326, 113);
            this.eksi.Name = "eksi";
            this.eksi.Size = new System.Drawing.Size(75, 48);
            this.eksi.TabIndex = 11;
            this.eksi.Text = "-";
            this.eksi.UseVisualStyleBackColor = true;
            this.eksi.Click += new System.EventHandler(this.IslemButonu_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(30, 242);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(75, 23);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.SayiButonu_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(222, 196);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.SayiButonu_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(124, 196);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.SayiButonu_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(30, 196);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.SayiButonu_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(222, 145);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.SayiButonu_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(124, 145);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.SayiButonu_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(30, 145);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.SayiButonu_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(222, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SayiButonu_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SayiButonu_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SayiButonu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Çözüm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "g";
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.IslemButonu_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bolu;
        private System.Windows.Forms.Button çarpi;
        private System.Windows.Forms.Button arti;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button eksi;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.TextBox sonuc;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Label label2;
    }
}

