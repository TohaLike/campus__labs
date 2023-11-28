namespace WinFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] b = textBox1.Text.Split(' ').Select(int.Parse).ToArray();
            int min = b[0];

            int[] result = new int[b.Length];

            for (int i = 1; i < b.Length; i++)
            {
                if (b[i] < min)
                {
                    min = b[i];
                }
            }
            
            textBox2.Text = result.ToString();

        }
    }
}