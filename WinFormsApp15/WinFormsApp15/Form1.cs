namespace WinFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] numberStrings = textBox1.Text.Split(',');
            int[] numbers = new int[numberStrings.Length];

            for (int i = 0; i < numberStrings.Length; i++)
            {
                if (int.TryParse(numberStrings[i], out int result))
                {
                    numbers[i] = result;
                }
            }

            int[] b = numbers.Select(c => int.Parse(c.ToString())).ToArray();
            int min = b[0];
            int max = b[b.Length - 1];
            int x = 0;

            if (min < max)
            {
                x = b[0];
                b[0] = b[b.Length - 1];
                b[b.Length - 1] = x;

            }


            textBox2.Text = string.Join(",", b);
        }
    }
}