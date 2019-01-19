using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
//SUNUM KATMANIMIZDIR.
namespace PresentationLayer
{
    public partial class AramaForm : Form
    {
        public AramaForm()
        {
            InitializeComponent();
        }

        private void AramaForm_Load(object sender, EventArgs e)
        {
            

        }

        private void AramaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main frm = new Main();
            frm.Show();
        }

        private void btn_kitapara_Click(object sender, EventArgs e)
        {   //DATATABLE TURUNDE DT OLUSTURUP TEXTEN ALDIGIMIZ DEĞERİ FACEDE KATMANINA GÖNDERİYORUZ.

            DataTable dt=BLArama.BlKitapArama(txt_kitaparama.Text);
            //DT DEN GELEN DEĞERLERİ GRİDWİEWDE GÖRÜNTÜLEMEMİZİ SAĞLIYOR.
            dGV_arama.DataSource = dt;
          
        }

        private void btn_ogrenciara_Click(object sender, EventArgs e)
        {
            DataTable dt = BLArama.BlUyeArama(txt_ogrenciarama.Text);
            dGV_arama.DataSource = dt;


        }

    }
}
