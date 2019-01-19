namespace PresentationLayer
{
    partial class OgrenciForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_ogrenci_borc = new System.Windows.Forms.Label();
            this.txt_ogrenci_dogumt = new System.Windows.Forms.DateTimePicker();
            this.lbl_ogrenci_ID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ogrenciekle = new System.Windows.Forms.Button();
            this.btn_ogrenciguncelle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ogrenci_mail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ogrenci_soyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ogrenci_ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ogrencisil = new System.Windows.Forms.Button();
            this.dGV_ogrenci = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_gizli = new System.Windows.Forms.Label();
            this.txt_silinecek_ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_borc_ode = new System.Windows.Forms.Button();
            this.lbl_borc = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbl_ogrenci_borc_id = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ogrenci)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_ogrenci_borc);
            this.groupBox1.Controls.Add(this.txt_ogrenci_dogumt);
            this.groupBox1.Controls.Add(this.lbl_ogrenci_ID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_ogrenciekle);
            this.groupBox1.Controls.Add(this.btn_ogrenciguncelle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_ogrenci_mail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_ogrenci_soyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_ogrenci_ad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 200);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // lbl_ogrenci_borc
            // 
            this.lbl_ogrenci_borc.AutoSize = true;
            this.lbl_ogrenci_borc.Location = new System.Drawing.Point(115, 161);
            this.lbl_ogrenci_borc.Name = "lbl_ogrenci_borc";
            this.lbl_ogrenci_borc.Size = new System.Drawing.Size(20, 17);
            this.lbl_ogrenci_borc.TabIndex = 11;
            this.lbl_ogrenci_borc.Text = "0 ";
            this.lbl_ogrenci_borc.Visible = false;
            // 
            // txt_ogrenci_dogumt
            // 
            this.txt_ogrenci_dogumt.Location = new System.Drawing.Point(118, 132);
            this.txt_ogrenci_dogumt.Name = "txt_ogrenci_dogumt";
            this.txt_ogrenci_dogumt.Size = new System.Drawing.Size(200, 22);
            this.txt_ogrenci_dogumt.TabIndex = 10;
            // 
            // lbl_ogrenci_ID
            // 
            this.lbl_ogrenci_ID.AutoSize = true;
            this.lbl_ogrenci_ID.Location = new System.Drawing.Point(119, 22);
            this.lbl_ogrenci_ID.Name = "lbl_ogrenci_ID";
            this.lbl_ogrenci_ID.Size = new System.Drawing.Size(21, 17);
            this.lbl_ogrenci_ID.TabIndex = 9;
            this.lbl_ogrenci_ID.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Öğrenci ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mail Adresi:";
            // 
            // btn_ogrenciekle
            // 
            this.btn_ogrenciekle.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ogrenciekle.Location = new System.Drawing.Point(324, 49);
            this.btn_ogrenciekle.Name = "btn_ogrenciekle";
            this.btn_ogrenciekle.Size = new System.Drawing.Size(103, 49);
            this.btn_ogrenciekle.TabIndex = 6;
            this.btn_ogrenciekle.Text = "EKLE";
            this.btn_ogrenciekle.UseVisualStyleBackColor = true;
            this.btn_ogrenciekle.Click += new System.EventHandler(this.btn_ogrenciekle_Click);
            // 
            // btn_ogrenciguncelle
            // 
            this.btn_ogrenciguncelle.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ogrenciguncelle.Location = new System.Drawing.Point(324, 114);
            this.btn_ogrenciguncelle.Name = "btn_ogrenciguncelle";
            this.btn_ogrenciguncelle.Size = new System.Drawing.Size(103, 48);
            this.btn_ogrenciguncelle.TabIndex = 7;
            this.btn_ogrenciguncelle.Text = "GÜNCELLE";
            this.btn_ogrenciguncelle.UseVisualStyleBackColor = true;
            this.btn_ogrenciguncelle.Click += new System.EventHandler(this.btn_ogrenciguncelle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Borç:";
            this.label5.Visible = false;
            // 
            // txt_ogrenci_mail
            // 
            this.txt_ogrenci_mail.Location = new System.Drawing.Point(118, 104);
            this.txt_ogrenci_mail.Name = "txt_ogrenci_mail";
            this.txt_ogrenci_mail.Size = new System.Drawing.Size(200, 22);
            this.txt_ogrenci_mail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Doğum Tarihi:";
            // 
            // txt_ogrenci_soyad
            // 
            this.txt_ogrenci_soyad.Location = new System.Drawing.Point(118, 76);
            this.txt_ogrenci_soyad.Name = "txt_ogrenci_soyad";
            this.txt_ogrenci_soyad.Size = new System.Drawing.Size(200, 22);
            this.txt_ogrenci_soyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Öğrenci Soyadı:";
            // 
            // txt_ogrenci_ad
            // 
            this.txt_ogrenci_ad.Location = new System.Drawing.Point(118, 48);
            this.txt_ogrenci_ad.Name = "txt_ogrenci_ad";
            this.txt_ogrenci_ad.Size = new System.Drawing.Size(200, 22);
            this.txt_ogrenci_ad.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Adı:";
            // 
            // btn_ogrencisil
            // 
            this.btn_ogrencisil.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ogrencisil.Location = new System.Drawing.Point(6, 52);
            this.btn_ogrencisil.Name = "btn_ogrencisil";
            this.btn_ogrencisil.Size = new System.Drawing.Size(276, 48);
            this.btn_ogrencisil.TabIndex = 8;
            this.btn_ogrencisil.Text = "SİL";
            this.btn_ogrencisil.UseVisualStyleBackColor = true;
            this.btn_ogrencisil.Click += new System.EventHandler(this.btn_ogrencisil_Click);
            // 
            // dGV_ogrenci
            // 
            this.dGV_ogrenci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_ogrenci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_ogrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_ogrenci.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_ogrenci.Location = new System.Drawing.Point(12, 233);
            this.dGV_ogrenci.Name = "dGV_ogrenci";
            this.dGV_ogrenci.RowTemplate.Height = 24;
            this.dGV_ogrenci.Size = new System.Drawing.Size(758, 318);
            this.dGV_ogrenci.TabIndex = 9;
            this.dGV_ogrenci.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_ogrenci_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_gizli);
            this.groupBox2.Controls.Add(this.txt_silinecek_ID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btn_ogrencisil);
            this.groupBox2.Location = new System.Drawing.Point(459, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 116);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci Silme İşlemi";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lbl_gizli
            // 
            this.lbl_gizli.AutoSize = true;
            this.lbl_gizli.Location = new System.Drawing.Point(239, 180);
            this.lbl_gizli.Name = "lbl_gizli";
            this.lbl_gizli.Size = new System.Drawing.Size(50, 17);
            this.lbl_gizli.TabIndex = 11;
            this.lbl_gizli.Text = "lbl gizli";
            this.lbl_gizli.Visible = false;
            // 
            // txt_silinecek_ID
            // 
            this.txt_silinecek_ID.Location = new System.Drawing.Point(149, 22);
            this.txt_silinecek_ID.Name = "txt_silinecek_ID";
            this.txt_silinecek_ID.Size = new System.Drawing.Size(133, 22);
            this.txt_silinecek_ID.TabIndex = 10;
            this.txt_silinecek_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_silinecek_ID_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Silinecek Öğrenci ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_borc_ode);
            this.groupBox3.Controls.Add(this.lbl_borc);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.lbl_ogrenci_borc_id);
            this.groupBox3.Location = new System.Drawing.Point(459, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 81);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Borç Öde";
            // 
            // btn_borc_ode
            // 
            this.btn_borc_ode.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_borc_ode.Location = new System.Drawing.Point(132, 27);
            this.btn_borc_ode.Name = "btn_borc_ode";
            this.btn_borc_ode.Size = new System.Drawing.Size(150, 48);
            this.btn_borc_ode.TabIndex = 4;
            this.btn_borc_ode.Text = "BORC ÖDE";
            this.btn_borc_ode.UseVisualStyleBackColor = true;
            this.btn_borc_ode.Click += new System.EventHandler(this.btn_borc_ode_Click);
            // 
            // lbl_borc
            // 
            this.lbl_borc.AutoSize = true;
            this.lbl_borc.Location = new System.Drawing.Point(89, 54);
            this.lbl_borc.Name = "lbl_borc";
            this.lbl_borc.Size = new System.Drawing.Size(37, 17);
            this.lbl_borc.TabIndex = 3;
            this.lbl_borc.Text = "Borç";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(44, 54);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 17);
            this.label22.TabIndex = 2;
            this.label22.Text = "Borç:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 26);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(79, 17);
            this.label21.TabIndex = 1;
            this.label21.Text = "Ogrenci ID:";
            // 
            // lbl_ogrenci_borc_id
            // 
            this.lbl_ogrenci_borc_id.AutoSize = true;
            this.lbl_ogrenci_borc_id.Location = new System.Drawing.Point(89, 26);
            this.lbl_ogrenci_borc_id.Name = "lbl_ogrenci_borc_id";
            this.lbl_ogrenci_borc_id.Size = new System.Drawing.Size(21, 17);
            this.lbl_ogrenci_borc_id.TabIndex = 0;
            this.lbl_ogrenci_borc_id.Text = "ID";
            // 
            // OgrenciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(783, 566);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dGV_ogrenci);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OgrenciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OgrenciForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OgrenciForm_FormClosing);
            this.Load += new System.EventHandler(this.OgrenciForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ogrenci)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ogrenci_mail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ogrenci_soyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ogrenci_ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ogrencisil;
        private System.Windows.Forms.Button btn_ogrenciekle;
        private System.Windows.Forms.Button btn_ogrenciguncelle;
        private System.Windows.Forms.DataGridView dGV_ogrenci;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_silinecek_ID;
        private System.Windows.Forms.Label lbl_ogrenci_ID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txt_ogrenci_dogumt;
        private System.Windows.Forms.Label lbl_ogrenci_borc;
        private System.Windows.Forms.Label lbl_gizli;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_borc_ode;
        private System.Windows.Forms.Label lbl_borc;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lbl_ogrenci_borc_id;
    }
}