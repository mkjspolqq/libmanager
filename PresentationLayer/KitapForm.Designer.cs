namespace PresentationLayer
{
    partial class KitapForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapForm));
            this.btn_kitapekle = new System.Windows.Forms.Button();
            this.btn_kitapguncelle = new System.Windows.Forms.Button();
            this.btn_kitapsil = new System.Windows.Forms.Button();
            this.txt_kitap_ad = new System.Windows.Forms.TextBox();
            this.txt_kitap_sayfasayisi = new System.Windows.Forms.TextBox();
            this.txt_yazar_ad = new System.Windows.Forms.TextBox();
            this.txt_tur_ad = new System.Windows.Forms.TextBox();
            this.txt_kitap_yayimevi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_kitap_ID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dGV_kitap = new System.Windows.Forms.DataGridView();
            this.txt_silinecek_kitap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_gizli = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_kitap)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_kitapekle
            // 
            this.btn_kitapekle.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitapekle.Location = new System.Drawing.Point(335, 52);
            this.btn_kitapekle.Name = "btn_kitapekle";
            this.btn_kitapekle.Size = new System.Drawing.Size(112, 56);
            this.btn_kitapekle.TabIndex = 5;
            this.btn_kitapekle.Text = "EKLE";
            this.btn_kitapekle.UseVisualStyleBackColor = true;
            this.btn_kitapekle.Click += new System.EventHandler(this.btn_kitapekle_Click);
            // 
            // btn_kitapguncelle
            // 
            this.btn_kitapguncelle.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitapguncelle.Location = new System.Drawing.Point(335, 125);
            this.btn_kitapguncelle.Name = "btn_kitapguncelle";
            this.btn_kitapguncelle.Size = new System.Drawing.Size(112, 59);
            this.btn_kitapguncelle.TabIndex = 6;
            this.btn_kitapguncelle.Text = "GÜNCELLE";
            this.btn_kitapguncelle.UseVisualStyleBackColor = true;
            this.btn_kitapguncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_kitapsil
            // 
            this.btn_kitapsil.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitapsil.Location = new System.Drawing.Point(10, 123);
            this.btn_kitapsil.Name = "btn_kitapsil";
            this.btn_kitapsil.Size = new System.Drawing.Size(245, 59);
            this.btn_kitapsil.TabIndex = 8;
            this.btn_kitapsil.Text = "SİL";
            this.btn_kitapsil.UseVisualStyleBackColor = true;
            this.btn_kitapsil.Click += new System.EventHandler(this.btn_kitapsil_Click);
            // 
            // txt_kitap_ad
            // 
            this.txt_kitap_ad.Location = new System.Drawing.Point(138, 52);
            this.txt_kitap_ad.Name = "txt_kitap_ad";
            this.txt_kitap_ad.Size = new System.Drawing.Size(177, 22);
            this.txt_kitap_ad.TabIndex = 0;
            // 
            // txt_kitap_sayfasayisi
            // 
            this.txt_kitap_sayfasayisi.Location = new System.Drawing.Point(138, 80);
            this.txt_kitap_sayfasayisi.Name = "txt_kitap_sayfasayisi";
            this.txt_kitap_sayfasayisi.Size = new System.Drawing.Size(177, 22);
            this.txt_kitap_sayfasayisi.TabIndex = 1;
            this.txt_kitap_sayfasayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_kitap_sayfasayisi_KeyPress);
            // 
            // txt_yazar_ad
            // 
            this.txt_yazar_ad.Location = new System.Drawing.Point(138, 108);
            this.txt_yazar_ad.Name = "txt_yazar_ad";
            this.txt_yazar_ad.Size = new System.Drawing.Size(177, 22);
            this.txt_yazar_ad.TabIndex = 2;
            // 
            // txt_tur_ad
            // 
            this.txt_tur_ad.Location = new System.Drawing.Point(138, 136);
            this.txt_tur_ad.Name = "txt_tur_ad";
            this.txt_tur_ad.Size = new System.Drawing.Size(177, 22);
            this.txt_tur_ad.TabIndex = 3;
            // 
            // txt_kitap_yayimevi
            // 
            this.txt_kitap_yayimevi.Location = new System.Drawing.Point(138, 162);
            this.txt_kitap_yayimevi.Name = "txt_kitap_yayimevi";
            this.txt_kitap_yayimevi.Size = new System.Drawing.Size(177, 22);
            this.txt_kitap_yayimevi.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_kitap_ID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_kitapekle);
            this.groupBox1.Controls.Add(this.txt_kitap_yayimevi);
            this.groupBox1.Controls.Add(this.btn_kitapguncelle);
            this.groupBox1.Controls.Add(this.txt_tur_ad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_yazar_ad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_kitap_sayfasayisi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_kitap_ad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 194);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbl_kitap_ID
            // 
            this.lbl_kitap_ID.AutoSize = true;
            this.lbl_kitap_ID.Location = new System.Drawing.Point(135, 27);
            this.lbl_kitap_ID.Name = "lbl_kitap_ID";
            this.lbl_kitap_ID.Size = new System.Drawing.Size(21, 17);
            this.lbl_kitap_ID.TabIndex = 5;
            this.lbl_kitap_ID.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Kitap ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yazar Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Yayım Evi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tür Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kitap Sayfa Sayısı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı:";
            // 
            // dGV_kitap
            // 
            this.dGV_kitap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_kitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_kitap.Location = new System.Drawing.Point(12, 239);
            this.dGV_kitap.Name = "dGV_kitap";
            this.dGV_kitap.RowTemplate.Height = 24;
            this.dGV_kitap.Size = new System.Drawing.Size(767, 318);
            this.dGV_kitap.TabIndex = 9;
            this.dGV_kitap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_kitap_CellClick);
            // 
            // txt_silinecek_kitap
            // 
            this.txt_silinecek_kitap.Location = new System.Drawing.Point(135, 63);
            this.txt_silinecek_kitap.Name = "txt_silinecek_kitap";
            this.txt_silinecek_kitap.Size = new System.Drawing.Size(121, 22);
            this.txt_silinecek_kitap.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Silinecek Kitap ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_kitapsil);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_silinecek_kitap);
            this.groupBox2.Location = new System.Drawing.Point(508, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 194);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Silme İşlemi";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lbl_gizli
            // 
            this.lbl_gizli.AutoSize = true;
            this.lbl_gizli.Enabled = false;
            this.lbl_gizli.Location = new System.Drawing.Point(717, 9);
            this.lbl_gizli.Name = "lbl_gizli";
            this.lbl_gizli.Size = new System.Drawing.Size(54, 17);
            this.lbl_gizli.TabIndex = 6;
            this.lbl_gizli.Text = "lbl_gizli";
            this.lbl_gizli.Visible = false;
            // 
            // KitapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(791, 569);
            this.Controls.Add(this.lbl_gizli);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dGV_kitap);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KitapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitapForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KitapForm_FormClosed);
            this.Load += new System.EventHandler(this.KitapForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_kitap)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kitapekle;
        private System.Windows.Forms.Button btn_kitapguncelle;
        private System.Windows.Forms.Button btn_kitapsil;
        private System.Windows.Forms.TextBox txt_kitap_ad;
        private System.Windows.Forms.TextBox txt_kitap_sayfasayisi;
        private System.Windows.Forms.TextBox txt_yazar_ad;
        private System.Windows.Forms.TextBox txt_tur_ad;
        private System.Windows.Forms.TextBox txt_kitap_yayimevi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGV_kitap;
        private System.Windows.Forms.Label lbl_kitap_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_silinecek_kitap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_gizli;
    }
}