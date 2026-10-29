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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Fiyat veya Adet Boş Girilemez!!!");
                return;
            }
            double fiyat, toplam, indirim;
            int adet = Convert.ToInt32(textBox2.Text);
            fiyat = Convert.ToDouble(textBox1.Text);
            toplam = fiyat * adet;
            if (adet < 3 && adet > 1)
            {
                indirim = toplam - (toplam * 0.05);
                label3.Text = "Toplam Fiyat:" + toplam + "\nİndirim: %5" + "\nİndirimli Fiyat:" + indirim;
            }
            else if (adet < 5)
            {
                indirim = toplam - (toplam * 0.10);
                label3.Text = "Toplam Fiyat:" + toplam + "\nİndirim: %10" + "\nİndirimli Fiyat:" + indirim;
            }
            else if (adet < 8)
            {
                indirim = toplam - (toplam * 0.20);
                label3.Text = "Toplam Fiyat:" + toplam + "\nİndirim: %20" + "\nİndirimli Fiyat:" + indirim;
            }
            else if (adet < 11)
            {
                indirim = toplam - (toplam * 0.30);
                label3.Text = "Toplam Fiyat:" + toplam + "\nİndirim: %30" + "\nİndirimli Fiyat:" + indirim;
            }
            else if (adet > 10)
            {
                indirim = toplam - (toplam * 0.40);
                label3.Text = "Toplam Fiyat:" + toplam + "\nİndirim: %40" + "\nİndirimli Fiyat:" + indirim;
            }
        }
    }
}
