namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int n = int.Parse(textBox2.Text);
            double z = 0;

            for (int k = 1; k <= n - 1; k++)
            {
                double c = 1;
                for (int i = 1; i <= n - 2; i++)
                {
                    c *= Math.Pow((Math.Pow(x, n) - k), 2);
                }

                z += Math.Pow(k, 5) * c + 2;
            }

            textBox3.Text = z.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}