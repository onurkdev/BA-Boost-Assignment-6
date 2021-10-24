
namespace BA_Boost_Assignment_6
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
            this.namebox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lastreadbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstreadbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.listAdSoyad = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listSumMiktari = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listFaturaTutari = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(131, 22);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(276, 20);
            this.namebox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı Soyadı:";
            // 
            // lastreadbox
            // 
            this.lastreadbox.Location = new System.Drawing.Point(131, 51);
            this.lastreadbox.Name = "lastreadbox";
            this.lastreadbox.Size = new System.Drawing.Size(276, 20);
            this.lastreadbox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Son index :";
            // 
            // firstreadbox
            // 
            this.firstreadbox.Location = new System.Drawing.Point(131, 81);
            this.firstreadbox.Name = "firstreadbox";
            this.firstreadbox.Size = new System.Drawing.Size(276, 20);
            this.firstreadbox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "İlk index :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(131, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 48);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanım Yeri";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Umumi";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.radioButton1_KeyPress);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(98, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 17);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Mesken";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.radioButton2_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listAdSoyad
            // 
            this.listAdSoyad.FormattingEnabled = true;
            this.listAdSoyad.Location = new System.Drawing.Point(12, 243);
            this.listAdSoyad.Name = "listAdSoyad";
            this.listAdSoyad.Size = new System.Drawing.Size(115, 173);
            this.listAdSoyad.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ad Soyad";
            // 
            // listSumMiktari
            // 
            this.listSumMiktari.FormattingEnabled = true;
            this.listSumMiktari.Location = new System.Drawing.Point(157, 243);
            this.listSumMiktari.Name = "listSumMiktari";
            this.listSumMiktari.Size = new System.Drawing.Size(115, 173);
            this.listSumMiktari.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kul.Su Miktarı";
            // 
            // listFaturaTutari
            // 
            this.listFaturaTutari.FormattingEnabled = true;
            this.listFaturaTutari.Location = new System.Drawing.Point(302, 243);
            this.listFaturaTutari.Name = "listFaturaTutari";
            this.listFaturaTutari.Size = new System.Drawing.Size(115, 173);
            this.listFaturaTutari.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fatura Tutarı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 428);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listFaturaTutari);
            this.Controls.Add(this.listSumMiktari);
            this.Controls.Add(this.listAdSoyad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstreadbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastreadbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.namebox);
            this.Name = "Form1";
            this.Text = "Su Faturası Hesaplayıcı";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastreadbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstreadbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listAdSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listSumMiktari;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listFaturaTutari;
        private System.Windows.Forms.Label label6;
    }
}

