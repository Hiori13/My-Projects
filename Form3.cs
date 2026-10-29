using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VücutKitleİndeksi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double süre, fiyat, indirim;

            if (textBox1.Text == "")
            {
                MessageBox.Show("Park süresini giriniz!");
                return;
            }

            süre = Convert.ToDouble(textBox1.Text);
            if (radioButton1.Checked == true && süre > 5)
            {
                fiyat = 50 + (30 * (süre - 1));
                indirim = fiyat - (fiyat * 0.15);
                label2.Text = "Ödenecek Tutar:" + fiyat + "\nİndirimli Fiyatınız:" + indirim;
            }
            else if (radioButton1.Checked == true && süre <= 5)
            {
                fiyat = 50 + (30 * (süre - 1));
                label2.Text = "Ödenecek Tutar:" + fiyat + "\nİndiriminiz Yok :(";
            }
            else if (radioButton2.Checked == true && süre > 5)
            {
                fiyat = 30 + (15 * (süre - 1));
                indirim = fiyat - (fiyat * 0.15);
                label2.Text = "Ödenecek Tutar:" + fiyat + "\nİndirimli Fiyatınız:" + indirim;
            }
            else if (radioButton2.Checked == true && süre <= 5)
            {
                fiyat = 30 + (15 * (süre - 1));
                label2.Text = "Ödenecek Tutar:" + fiyat + "\nİndiriminiz Yok :(";
            }
            else if (radioButton3.Checked == true && süre > 5)
            {
                fiyat = 80 + (50 * (süre - 1));
                indirim = fiyat - (fiyat * 0.15);
                label2.Text = "Ödenecek Tutar:" + fiyat + "\nİndirimli Fiyatınız:" + indirim;
            }
            else if (radioButton3.Checked == true && süre <= 5)
            {
                fiyat = 80 + (50 * (süre - 1));
                label2.Text = "Ödenecek Tutar:" + fiyat + "\nİndiriminiz Yok :(";
            }


        }
    }
}
