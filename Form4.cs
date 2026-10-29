using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VücutKitleİndeksi
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double taneFiyat, adet, toplamFiyat, indirimliFiyat, vipindirim;
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Fiyat yada Adet Giriniz!");
                return;
            }
            taneFiyat = Convert.ToDouble(textBox1.Text);
            adet = Convert.ToDouble(textBox2.Text);
            if (adet == 1)
            {
                if (radioButton1.Checked == true)
                {
                    toplamFiyat = taneFiyat * adet;
                    label3.Text = "Toplam Tutar:" + toplamFiyat + "\nİndiriminiz Yok" + "\nÖdenecek Tutar:" + toplamFiyat;
                }
                if (radioButton2.Checked == true)
                {
                    toplamFiyat = taneFiyat * adet;
                    vipindirim = toplamFiyat - (toplamFiyat * 0.05);
                    label3.Text = "Toplam Tutar:" + toplamFiyat + "\nVIP İndirimi: %5" + "\nÖdenecek Tutar:" + vipindirim;
                }
            }
            else if (adet == 2 || adet == 3)
            {
                if (radioButton1.Checked == true)
                {
                    toplamFiyat = taneFiyat * adet;
                    indirimliFiyat = toplamFiyat - (toplamFiyat * 0.10);
                    label3.Text = "Toplam Tutar:" + toplamFiyat + "\nİndirim: %10" + "\nÖdenecek Tutar:" + indirimliFiyat;
                }
                if (radioButton2.Checked == true)
                {
                    toplamFiyat = taneFiyat * adet;
                    indirimliFiyat = toplamFiyat - (toplamFiyat * 0.10);
                    vipindirim = indirimliFiyat - (indirimliFiyat * 0.05);
                    label3.Text = "Toplam Tutar:" + toplamFiyat + "\nMiktar İndirimi: %10" + "\nVIP İndirimi: %5" + "\nÖdenecek Tutar:" + vipindirim;
                }
            }
            else if (adet == 4 || adet == 5)
            {
                if (radioButton1.Checked == true)
                {
                    toplamFiyat = taneFiyat * adet;
                    indirimliFiyat = toplamFiyat - (toplamFiyat * 0.20);
                    label3.Text = "Toplam Tutar:" + toplamFiyat + "\nİndirim: %20" + "\nÖdenecek Tutar:" + indirimliFiyat;
                }
                if (radioButton2.Checked == true)
                {
                    toplamFiyat = taneFiyat * adet;
                    indirimliFiyat = toplamFiyat - (toplamFiyat * 0.20);
                    vipindirim = indirimliFiyat - (indirimliFiyat * 0.05);
                    label3.Text = "Toplam Tutar:" + toplamFiyat + "\nMiktar İndirimi: %20" + "\nVIP İndirimi: %5" + "\nÖdenecek Tutar:" + vipindirim;
                }
            }
            else if (adet >= 6)
            {
                if (radioButton1.Checked == true)
                {
                    toplamFiyat = taneFiyat * adet;
                    indirimliFiyat = toplamFiyat - (toplamFiyat * 0.30);
                    label3.Text = "Toplam Tutar:" + toplamFiyat + "\nİndirim: %30" + "\nÖdenecek Tutar:" + indirimliFiyat;
                }
                if (radioButton2.Checked == true)
                {
                    toplamFiyat = taneFiyat * adet;
                    indirimliFiyat = toplamFiyat - (toplamFiyat * 0.30);
                    vipindirim = indirimliFiyat - (indirimliFiyat * 0.05);
                    label3.Text = "Toplam Tutar:" + toplamFiyat + "\nMiktar İndirimi: %30" + "\nVIP İndirimi: %5" + "\nÖdenecek Tutar:" + vipindirim;
                }
            }

        }
    }
    
}