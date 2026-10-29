namespace VücutKitleİndeksi
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Kilo veya boy boş bırakılamaz");
                return;
            }

            double kilo, boy, vki;
            kilo = Convert.ToDouble(textBox1.Text);
            boy = Convert.ToDouble(textBox2.Text);

            vki = kilo / (boy * boy);
            if (vki < 18.49)
            {
                label3.Text = "Vücut Kitle İndeksiniz:" + vki + "\nİdeal Kilonun Altı";
            }
            else if (vki < 24.99)
            {
                label3.Text = "Vücut Kitle İndeksiniz:" + vki + "\nİdeal Kilo";
            }
            else if (vki < 29.99)
            {
                label3.Text = "Vücut Kitle İndeksiniz:" + vki + "\nİdeal Kilonun Üstü";
            }
            else if (vki > 30)
            {
                label3.Text = "Vücut Kitle İndeksiniz:" + vki + "\nİdeal Kilonun Çok Üstü";
            }
        }
    }
    
}
