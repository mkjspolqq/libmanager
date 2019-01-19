namespace PresentationLayer
{
    partial class OduncForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OduncForm));
            this.gb_odunckitapver = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gb_odunckitapal = new System.Windows.Forms.GroupBox();
            this.btn_oduncal = new System.Windows.Forms.Button();
            this.txt_odunc_gerial_kitapadi = new System.Windows.Forms.TextBox();
            this.txt_odunc_gerial_ogr_id = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtp_oduncal_alistarihi = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gb_oduncuzat = new System.Windows.Forms.GroupBox();
            this.btn_oduncuzat = new System.Windows.Forms.Button();
            this.txt_oduncuzat_kitapadi = new System.Windows.Forms.TextBox();
            this.txt_oduncuzat_ogr_id = new System.Windows.Forms.TextBox();
            this.txt_oduncuzat_tarih = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxKitaplar = new System.Windows.Forms.ComboBox();
            this.btn_oduncver = new System.Windows.Forms.Button();
            this.txt_oduncver_ogr_id = new System.Windows.Forms.TextBox();
            this.dtp_oduncver_veristarih = new System.Windows.Forms.DateTimePicker();
            this.dtp_oduncver_alistarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgw_odunc = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.gb_odunckitapver.SuspendLayout();
            this.gb_odunckitapal.SuspendLayout();
            this.gb_oduncuzat.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_odunc)).BeginInit();
            this.SuspendLayout();
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
            this.gb_odunckitapver.Location = new System.Drawing.Point(22, 25);
            this.gb_odunckitapver.Name = "gb_odunckitapver";
            this.gb_odunckitapver.Size = new System.Drawing.Size(335, 228);
            this.gb_odunckitapver.TabIndex = 0;
            this.gb_odunckitapver.TabStop = false;
            this.gb_odunckitapver.Text = "Ödünç Kitap Ver";
            this.gb_odunckitapver.Enter += new System.EventHandler(this.gb_odunckitapver_Enter);
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
            // gb_odunckitapal
            // 
            this.gb_odunckitapal.Controls.Add(this.btn_oduncal);
            this.gb_odunckitapal.Controls.Add(this.txt_odunc_gerial_kitapadi);
            this.gb_odunckitapal.Controls.Add(this.txt_odunc_gerial_ogr_id);
            this.gb_odunckitapal.Controls.Add(this.label11);
            this.gb_odunckitapal.Controls.Add(this.dtp_oduncal_alistarihi);
            this.gb_odunckitapal.Controls.Add(this.label12);
            this.gb_odunckitapal.Controls.Add(this.label10);
            this.gb_odunckitapal.Location = new System.Drawing.Point(363, 25);
            this.gb_odunckitapal.Name = "gb_odunckitapal";
            this.gb_odunckitapal.Size = new System.Drawing.Size(335, 228);
            this.gb_odunckitapal.TabIndex = 0;
            this.gb_odunckitapal.TabStop = false;
            this.gb_odunckitapal.Text = "Ödünç Kitap Geri Al";
            // 
            // btn_oduncal
            // 
            this.btn_oduncal.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_oduncal.Location = new System.Drawing.Point(184, 185);
            this.btn_oduncal.Name = "btn_oduncal";
            this.btn_oduncal.Size = new System.Drawing.Size(126, 37);
            this.btn_oduncal.TabIndex = 8;
            this.btn_oduncal.Text = "ONAYLA";
            this.btn_oduncal.UseVisualStyleBackColor = true;
            this.btn_oduncal.Visible = false;
            this.btn_oduncal.Click += new System.EventHandler(this.btn_oduncal_Click);
            // 
            // txt_odunc_gerial_kitapadi
            // 
            this.txt_odunc_gerial_kitapadi.Location = new System.Drawing.Point(99, 57);
            this.txt_odunc_gerial_kitapadi.Name = "txt_odunc_gerial_kitapadi";
            this.txt_odunc_gerial_kitapadi.Size = new System.Drawing.Size(211, 22);
            this.txt_odunc_gerial_kitapadi.TabIndex = 6;
            // 
            // txt_odunc_gerial_ogr_id
            // 
            this.txt_odunc_gerial_ogr_id.Location = new System.Drawing.Point(99, 27);
            this.txt_odunc_gerial_ogr_id.Name = "txt_odunc_gerial_ogr_id";
            this.txt_odunc_gerial_ogr_id.Size = new System.Drawing.Size(211, 22);
            this.txt_odunc_gerial_ogr_id.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Kitap ID:";
            // 
            // dtp_oduncal_alistarihi
            // 
            this.dtp_oduncal_alistarihi.Location = new System.Drawing.Point(99, 88);
            this.dtp_oduncal_alistarihi.Name = "dtp_oduncal_alistarihi";
            this.dtp_oduncal_alistarihi.Size = new System.Drawing.Size(211, 22);
            this.dtp_oduncal_alistarihi.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "Öğrenci ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Alındığı Tarih:";
            // 
            // gb_oduncuzat
            // 
            this.gb_oduncuzat.Controls.Add(this.btn_oduncuzat);
            this.gb_oduncuzat.Controls.Add(this.txt_oduncuzat_kitapadi);
            this.gb_oduncuzat.Controls.Add(this.txt_oduncuzat_ogr_id);
            this.gb_oduncuzat.Controls.Add(this.txt_oduncuzat_tarih);
            this.gb_oduncuzat.Controls.Add(this.label9);
            this.gb_oduncuzat.Controls.Add(this.label13);
            this.gb_oduncuzat.Controls.Add(this.label14);
            this.gb_oduncuzat.Location = new System.Drawing.Point(704, 25);
            this.gb_oduncuzat.Name = "gb_oduncuzat";
            this.gb_oduncuzat.Size = new System.Drawing.Size(353, 228);
            this.gb_oduncuzat.TabIndex = 0;
            this.gb_oduncuzat.TabStop = false;
            this.gb_oduncuzat.Text = "Kitap Süresi Uzat";
            // 
            // btn_oduncuzat
            // 
            this.btn_oduncuzat.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_oduncuzat.Location = new System.Drawing.Point(196, 185);
            this.btn_oduncuzat.Name = "btn_oduncuzat";
            this.btn_oduncuzat.Size = new System.Drawing.Size(126, 37);
            this.btn_oduncuzat.TabIndex = 12;
            this.btn_oduncuzat.Text = "ONAYLA";
            this.btn_oduncuzat.UseVisualStyleBackColor = true;
            this.btn_oduncuzat.Visible = false;
            this.btn_oduncuzat.Click += new System.EventHandler(this.btn_oduncuzat_Click);
            // 
            // txt_oduncuzat_kitapadi
            // 
            this.txt_oduncuzat_kitapadi.Location = new System.Drawing.Point(118, 58);
            this.txt_oduncuzat_kitapadi.Name = "txt_oduncuzat_kitapadi";
            this.txt_oduncuzat_kitapadi.Size = new System.Drawing.Size(204, 22);
            this.txt_oduncuzat_kitapadi.TabIndex = 10;
            // 
            // txt_oduncuzat_ogr_id
            // 
            this.txt_oduncuzat_ogr_id.Location = new System.Drawing.Point(118, 27);
            this.txt_oduncuzat_ogr_id.Name = "txt_oduncuzat_ogr_id";
            this.txt_oduncuzat_ogr_id.Size = new System.Drawing.Size(204, 22);
            this.txt_oduncuzat_ogr_id.TabIndex = 9;
            // 
            // txt_oduncuzat_tarih
            // 
            this.txt_oduncuzat_tarih.Location = new System.Drawing.Point(118, 88);
            this.txt_oduncuzat_tarih.Name = "txt_oduncuzat_tarih";
            this.txt_oduncuzat_tarih.Size = new System.Drawing.Size(204, 22);
            this.txt_oduncuzat_tarih.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Uzatılacak Tarih:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(59, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 17);
            this.label13.TabIndex = 16;
            this.label13.Text = "Kitap ID:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(41, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 17);
            this.label14.TabIndex = 17;
            this.label14.Text = "Öğrenci ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxKitaplar);
            this.groupBox1.Controls.Add(this.btn_oduncver);
            this.groupBox1.Controls.Add(this.txt_oduncver_ogr_id);
            this.groupBox1.Controls.Add(this.dtp_oduncver_veristarih);
            this.groupBox1.Controls.Add(this.dtp_oduncver_alistarihi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(22, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödünç Kitap Ver";
            this.groupBox1.Enter += new System.EventHandler(this.gb_odunckitapver_Enter);
            // 
            // cbxKitaplar
            // 
            this.cbxKitaplar.FormattingEnabled = true;
            this.cbxKitaplar.Location = new System.Drawing.Point(112, 56);
            this.cbxKitaplar.Name = "cbxKitaplar";
            this.cbxKitaplar.Size = new System.Drawing.Size(196, 24);
            this.cbxKitaplar.TabIndex = 1;
            // 
            // btn_oduncver
            // 
            this.btn_oduncver.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_oduncver.Location = new System.Drawing.Point(182, 185);
            this.btn_oduncver.Name = "btn_oduncver";
            this.btn_oduncver.Size = new System.Drawing.Size(126, 37);
            this.btn_oduncver.TabIndex = 4;
            this.btn_oduncver.Text = "ONAYLA";
            this.btn_oduncver.UseVisualStyleBackColor = true;
            this.btn_oduncver.Click += new System.EventHandler(this.btn_oduncver_Click);
            // 
            // txt_oduncver_ogr_id
            // 
            this.txt_oduncver_ogr_id.Location = new System.Drawing.Point(112, 26);
            this.txt_oduncver_ogr_id.Name = "txt_oduncver_ogr_id";
            this.txt_oduncver_ogr_id.Size = new System.Drawing.Size(196, 22);
            this.txt_oduncver_ogr_id.TabIndex = 1;
            // 
            // dtp_oduncver_veristarih
            // 
            this.dtp_oduncver_veristarih.Location = new System.Drawing.Point(112, 93);
            this.dtp_oduncver_veristarih.Name = "dtp_oduncver_veristarih";
            this.dtp_oduncver_veristarih.Size = new System.Drawing.Size(196, 22);
            this.dtp_oduncver_veristarih.TabIndex = 2;
            // 
            // dtp_oduncver_alistarihi
            // 
            this.dtp_oduncver_alistarihi.Location = new System.Drawing.Point(112, 121);
            this.dtp_oduncver_alistarihi.Name = "dtp_oduncver_alistarihi";
            this.dtp_oduncver_alistarihi.Size = new System.Drawing.Size(196, 22);
            this.dtp_oduncver_alistarihi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verildiği Tarih:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Alınacağı Tarih:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kitap Adı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Öğrenci ID:";
            // 
            // dgw_odunc
            // 
            this.dgw_odunc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_odunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_odunc.Location = new System.Drawing.Point(22, 293);
            this.dgw_odunc.Name = "dgw_odunc";
            this.dgw_odunc.RowTemplate.Height = 24;
            this.dgw_odunc.Size = new System.Drawing.Size(1035, 401);
            this.dgw_odunc.TabIndex = 13;
            this.dgw_odunc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_odunc_CellClick);
            this.dgw_odunc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_odunc_CellContentClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(80, 273);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 17);
            this.label15.TabIndex = 2;
            this.label15.Text = "İşlem ID";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(242, 273);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 17);
            this.label16.TabIndex = 2;
            this.label16.Text = "Öğrenci ID";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(403, 273);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 17);
            this.label17.TabIndex = 2;
            this.label17.Text = "Kitap ID";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(546, 273);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(156, 17);
            this.label18.TabIndex = 2;
            this.label18.Text = "Alınması Gereken Tarih";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(719, 273);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 17);
            this.label19.TabIndex = 2;
            this.label19.Text = "Verildiği Tarih ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(879, 273);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(127, 17);
            this.label20.TabIndex = 2;
            this.label20.Text = "Teslim Durumu 0/1";
            // 
            // OduncForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1069, 716);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dgw_odunc);
            this.Controls.Add(this.gb_oduncuzat);
            this.Controls.Add(this.gb_odunckitapal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_odunckitapver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OduncForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OduncForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OduncForm_FormClosing);
            this.Load += new System.EventHandler(this.OduncForm_Load);
            this.gb_odunckitapver.ResumeLayout(false);
            this.gb_odunckitapver.PerformLayout();
            this.gb_odunckitapal.ResumeLayout(false);
            this.gb_odunckitapal.PerformLayout();
            this.gb_oduncuzat.ResumeLayout(false);
            this.gb_oduncuzat.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_odunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_odunckitapver;
        private System.Windows.Forms.GroupBox gb_odunckitapal;
        private System.Windows.Forms.GroupBox gb_oduncuzat;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_oduncver_ogr_id;
        private System.Windows.Forms.DateTimePicker dtp_oduncver_veristarih;
        private System.Windows.Forms.DateTimePicker dtp_oduncver_alistarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_oduncal;
        private System.Windows.Forms.TextBox txt_odunc_gerial_ogr_id;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_oduncuzat;
        private System.Windows.Forms.TextBox txt_oduncuzat_kitapadi;
        private System.Windows.Forms.TextBox txt_oduncuzat_ogr_id;
        private System.Windows.Forms.DateTimePicker txt_oduncuzat_tarih;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_oduncver;
        private System.Windows.Forms.ComboBox cbxKitaplar;
        private System.Windows.Forms.DataGridView dgw_odunc;
        private System.Windows.Forms.TextBox txt_odunc_gerial_kitapadi;
        private System.Windows.Forms.DateTimePicker dtp_oduncal_alistarihi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}