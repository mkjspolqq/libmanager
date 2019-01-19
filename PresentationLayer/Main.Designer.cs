namespace PresentationLayer
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btn_kitap = new System.Windows.Forms.Button();
            this.btn_ogrenci = new System.Windows.Forms.Button();
            this.btn_odunc = new System.Windows.Forms.Button();
            this.btn_arama = new System.Windows.Forms.Button();
            this.btn_grafik = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btn_kitap
            // 
            this.btn_kitap.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_kitap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_kitap.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitap.Location = new System.Drawing.Point(659, 165);
            this.btn_kitap.Name = "btn_kitap";
            this.btn_kitap.Size = new System.Drawing.Size(163, 101);
            this.btn_kitap.TabIndex = 0;
            this.btn_kitap.Text = "KİTAP İŞLEMLERİ";
            this.btn_kitap.UseVisualStyleBackColor = false;
            this.btn_kitap.Click += new System.EventHandler(this.btn_kitap_Click);
            this.btn_kitap.MouseHover += new System.EventHandler(this.btn_kitap_MouseHover);
            this.btn_kitap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_kitap_MouseMove);
            // 
            // btn_ogrenci
            // 
            this.btn_ogrenci.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_ogrenci.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ogrenci.Location = new System.Drawing.Point(848, 165);
            this.btn_ogrenci.Name = "btn_ogrenci";
            this.btn_ogrenci.Size = new System.Drawing.Size(161, 101);
            this.btn_ogrenci.TabIndex = 1;
            this.btn_ogrenci.Text = "ÖĞRENCİ İŞLEMLERİ";
            this.btn_ogrenci.UseVisualStyleBackColor = false;
            this.btn_ogrenci.Click += new System.EventHandler(this.btn_ogrenci_Click);
            this.btn_ogrenci.MouseHover += new System.EventHandler(this.btn_ogrenci_MouseHover);
            this.btn_ogrenci.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_ogrenci_MouseMove);
            // 
            // btn_odunc
            // 
            this.btn_odunc.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_odunc.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_odunc.Location = new System.Drawing.Point(659, 284);
            this.btn_odunc.Name = "btn_odunc";
            this.btn_odunc.Size = new System.Drawing.Size(163, 99);
            this.btn_odunc.TabIndex = 2;
            this.btn_odunc.Text = "ÖDÜNÇ İŞLEMLERİ";
            this.btn_odunc.UseVisualStyleBackColor = false;
            this.btn_odunc.Click += new System.EventHandler(this.btn_odunc_Click);
            this.btn_odunc.MouseHover += new System.EventHandler(this.btn_odunc_MouseHover);
            this.btn_odunc.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_odunc_MouseMove);
            this.btn_odunc.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_odunc_MouseUp);
            // 
            // btn_arama
            // 
            this.btn_arama.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_arama.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_arama.Location = new System.Drawing.Point(848, 284);
            this.btn_arama.Name = "btn_arama";
            this.btn_arama.Size = new System.Drawing.Size(161, 99);
            this.btn_arama.TabIndex = 3;
            this.btn_arama.Text = "ARAMA ";
            this.btn_arama.UseVisualStyleBackColor = false;
            this.btn_arama.Click += new System.EventHandler(this.btn_arama_Click);
            this.btn_arama.MouseHover += new System.EventHandler(this.btn_arama_MouseHover);
            this.btn_arama.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_arama_MouseMove);
            // 
            // btn_grafik
            // 
            this.btn_grafik.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_grafik.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_grafik.Location = new System.Drawing.Point(659, 409);
            this.btn_grafik.Name = "btn_grafik";
            this.btn_grafik.Size = new System.Drawing.Size(163, 95);
            this.btn_grafik.TabIndex = 4;
            this.btn_grafik.Text = "GRAFİK";
            this.btn_grafik.UseVisualStyleBackColor = false;
            this.btn_grafik.Click += new System.EventHandler(this.btn_grafik_Click);
            this.btn_grafik.MouseHover += new System.EventHandler(this.btn_grafik_MouseHover);
            this.btn_grafik.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_grafik_MouseMove);
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_cikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cikis.BackgroundImage")));
            this.btn_cikis.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.Location = new System.Drawing.Point(848, 409);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(161, 95);
            this.btn_cikis.TabIndex = 5;
            this.btn_cikis.Text = "ÇIKIŞ";
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            this.btn_cikis.MouseHover += new System.EventHandler(this.btn_cikis_MouseHover);
            this.btn_cikis.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_cikis_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PowderBlue;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(891, 611);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hazırlayanlar";
            this.toolTip1.SetToolTip(this.label1, "Hakan Ergovan \r\nYunus Serter\r\n");
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1073, 644);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_grafik);
            this.Controls.Add(this.btn_arama);
            this.Controls.Add(this.btn_odunc);
            this.Controls.Add(this.btn_ogrenci);
            this.Controls.Add(this.btn_kitap);
            this.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KÜTÜPHANE";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kitap;
        private System.Windows.Forms.Button btn_ogrenci;
        private System.Windows.Forms.Button btn_odunc;
        private System.Windows.Forms.Button btn_arama;
        private System.Windows.Forms.Button btn_grafik;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

