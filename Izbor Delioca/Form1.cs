namespace Izbor_Delioca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                textBox1.Text += i + ", ";
            }
            textBox1.Text += "20";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int d = 1;
            if (chbDeljiviSaDva.Checked) d *= 2;
            if (chbDeljiviSaTri.Checked) d *= 3;
            if (chbDeljiviSaPet.Checked) d *= 5;
            if (chbDeljiviSaSedam.Checked) d *= 7;

            textBox1.Text = "";
            for (int i = 1; i <= 20; i++)
            {
                if (i % d == 0)
                    textBox1.Text += i + ", ";
            }
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 2);
        }
    }
}