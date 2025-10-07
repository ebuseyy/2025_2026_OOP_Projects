namespace Hesap_Mak
{
    public partial class Form1 : Form
    {
        int secim = 1;
        string op = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (secim == 1)
                textBox1.Text = textBox1.Text + "1";
            else
                textBox2.Text = textBox2.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (secim == 1)
                textBox1.Text = textBox1.Text + "2";
            else
                textBox2.Text = textBox2.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (secim == 1)
                textBox1.Text = textBox1.Text + "3";
            else
                textBox2.Text = textBox2.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            op = "+";
            if (secim == 1) secim = 2;
            else secim = 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);

            if (op == "+")
                label4.Text = (a+b).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            op = "-";
            if (secim == 1) secim = 2;
            else secim = 1;
        }
    }
}
