namespace FormSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Win Form App!");
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            btnHello.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data1 = txtNumber1.Text;
            string data2 = txtNumber2.Text;

            int sayi1 = Convert.ToInt32(data1);
            int sayi2 = Convert.ToInt32(data2);

            int sonuc = sayi1 + sayi2;

            MessageBox.Show(sonuc.ToString());
        }
    }
}