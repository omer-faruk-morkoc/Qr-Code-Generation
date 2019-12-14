using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using MessagingToolkit.QRCode;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using System.Windows.Forms;

namespace projeler
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnkayıt_Click(object sender, EventArgs e)
        {

        }
    
        private Image karekodolustur(string durum,string bad, string bno,string bas, string tarih,string gec,string dokuman, string belges, string sasi, string telno,string giris, int kduzey)
        {

            giris = durum   + "\n\n" + bad + "\n\n" + bno  + "\n\n" + bas  + "\n\n" + tarih + "\n\n" + gec  +  "\n\n" + dokuman  + "\n\n" + belges  + "\n\n" +sasi   + "\n\n" + telno;
      
            var deger = giris;
            MessagingToolkit.QRCode.Codec.QRCodeEncoder qe = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
            qe.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            qe.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L;
            qe.QRCodeVersion = kduzey;
            System.Drawing.Bitmap bm = qe.Encode(deger);
            return bm;
        }

        private void kkolustur_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "JPEG|*.JPG", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                  
                    lblbdurum.Font = new Font(lblbdurum.Font, lblbdurum.Font.Style ^ FontStyle.Italic);
                    Resim.Image = karekodolustur(lblbdurum.Text, lblbad.Text, lblbno.Text, lblbsahip.Text, lblsasi.Text, lbltelno.Text, lblbasvuru.Text, lbltarih.Text, lblgec.Text, lbldokuman.Text, "", 17);
                    karekodolustur(lblbdurum.Text, lblbad.Text, lblbno.Text, lblbsahip.Text, lblsasi.Text, lbltelno.Text, lblbasvuru.Text, lbltarih.Text, lblgec.Text, lbldokuman.Text, "", 17).Save(sfd.FileName, ImageFormat.Jpeg);



                }
            }

        }

        private void lblbdurum_Click(object sender, EventArgs e)
        {

        }

        private void lblbsahip_Click(object sender, EventArgs e)
        {

        }

        private void lblbad_Click(object sender, EventArgs e)
        {

        }
    }
}
