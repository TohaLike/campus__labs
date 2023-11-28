namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            double x = 0;


            while (n > 1)
            {
                n /= 2;

                if (n % 2 == 0)
                {
                    x += 1;
                } 
            }
            textBox2.Text = x.ToString();
        }
    }
}