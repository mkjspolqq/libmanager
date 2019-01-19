namespace PresentationLayer
{
    partial class AramaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AramaForm));
            this.gb_odunckitapal = new System.Windows.Forms.GroupBox();
            this.btn_ogrenciara = new System.Windows.Forms.Button();
            this.txt_ogrenciarama = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_kitapara = new System.Windows.Forms.Button();
            this.txt_kitaparama = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gb_odunckitapver = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dGV_arama = new System.Windows.Forms.DataGridView();
            this.gb_odunckitapal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb_odunckitapver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_arama)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_odunckitapal
            // 
            this.gb_odunckitapal.Controls.Add(this.btn_ogrenciara);
            this.gb_odunckitapal.Controls.Add(this.txt_ogrenciarama);
            this.gb_odunckitapal.Controls.Add(this.label12);
            this.gb_odunckitapal.Location = new System.Drawing.Point(386, 29);
            this.gb_odunckitapal.Name = "gb_odunckitapal";
            this.gb_odunckitapal.Size = new System.Drawing.Size(335, 153);
            this.gb_odunckitapal.TabIndex = 2;
            this.gb_odunckitapal.TabStop = false;
            this.gb_odunckitapal.Text = "ÖĞRENCİ ARAMA";
            // 
            // btn_ogrenciara
            // 
            this.btn_ogrenciara.Location = new System.Drawing.Point(91, 77);
            this.btn_ogrenciara.Name = "btn_ogrenciara";
            this.btn_ogrenciara.Size = new System.Drawing.Size(126, 37);
            this.btn_ogrenciara.TabIndex = 1;
            this.btn_ogrenciara.Text = "ARA";
            this.btn_ogrenciara.UseVisualStyleBackColor = true;
            this.btn_ogrenciara.Click += new System.EventHandler(this.btn_ogrenciara_Click);
            // 
            // txt_ogrenciarama
            // 
            this.txt_ogrenciarama.Location = new System.Drawing.Point(60, 49);
            this.txt_ogrenciarama.Name = "txt_ogrenciarama";
            this.txt_ogrenciarama.Size = new System.Drawing.Size(196, 22);
            this.txt_ogrenciarama.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(57, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "Öğrenci ID Giriniz";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_kitapara);
            this.groupBox1.Controls.Add(this.txt_kitaparama);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(45, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 153);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KİTAP ARAMA ";
            // 
            // btn_kitapara
            // 
            this.btn_kitapara.Location = new System.Drawing.Point(103, 71);
            this.btn_kitapara.Name = "btn_kitapara";
            this.btn_kitapara.Size = new System.Drawing.Size(126, 37);
            this.btn_kitapara.TabIndex = 3;
            this.btn_kitapara.Text = "ARA";
            this.btn_kitapara.UseVisualStyleBackColor = true;
            this.btn_kitapara.Click += new System.EventHandler(this.btn_kitapara_Click);
            // 
            // txt_kitaparama
            // 
            this.txt_kitaparama.Location = new System.Drawing.Point(75, 43);
            this.txt_kitaparama.Name = "txt_kitaparama";
            this.txt_kitaparama.Size = new System.Drawing.Size(196, 22);
            this.txt_kitaparama.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Kitap ID Giriniz";
            // 
            // gb_odunckitapver
            // 
            this.gb_odunckitapver.Controls.Add(this.textBox1);
            this.gb_odunckitapver.Controls.Add(this.dateTimePicker2);
            this.gb_odunckitapver.Controls.Add(this.dateTimePicker1);
            this.gb_odunckitapver.Controls.Add(this.label4);
            this.gb_odunckitapver.Controls.Add(this.label3);
            this.gb_odunckitapver.Controls.Add(this.label2);
            this.gb_odunckitapver.Controls.Add(this.label6);
            this.gb_odunckitapver.Location = new System.Drawing.Point(45, 29);
            this.gb_odunckitapver.Name = "gb_odunckitapver";
            this.gb_odunckitapver.Size = new System.Drawing.Size(335, 153);
            this.gb_odunckitapver.TabIndex = 4;
            this.gb_odunckitapver.TabStop = false;
            this.gb_odunckitapver.Text = "Ödünç Kitap Ver";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 22);
            this.textBox1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(112, 110);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(112, 82);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Veriş Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Alış Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kitap Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Öğrenci ID:";
            // 
            // dGV_arama
            // 
            this.dGV_arama.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_arama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_arama.Location = new System.Drawing.Point(45, 215);
            this.dGV_arama.Name = "dGV_arama";
            this.dGV_arama.RowTemplate.Height = 24;
            this.dGV_arama.Size = new System.Drawing.Size(676, 332);
            this.dGV_arama.TabIndex = 5;
            // 
            // AramaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(776, 559);
            this.Controls.Add(this.dGV_arama);
            this.Controls.Add(this.gb_odunckitapal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_odunckitapver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AramaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AramaForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AramaForm_FormClosing);
            this.Load += new System.EventHandler(this.AramaForm_Load);
            this.gb_odunckitapal.ResumeLayout(false);
            this.gb_odunckitapal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_odunckitapver.ResumeLayout(false);
            this.gb_odunckitapver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_arama)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_odunckitapal;
        private System.Windows.Forms.Button btn_ogrenciara;
        private System.Windows.Forms.TextBox txt_ogrenciarama;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_kitapara;
        private System.Windows.Forms.TextBox txt_kitaparama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gb_odunckitapver;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dGV_arama;
    }
}