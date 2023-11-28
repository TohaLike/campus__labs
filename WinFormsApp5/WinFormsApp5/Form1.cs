namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;

            if (x.Length == 2 && char.IsDigit(x[0]) && char.IsDigit(x[1]))
            {
                int y = int.Parse(x[0].ToString(), System.Globalization.NumberStyles.HexNumber);
                int z = int.Parse(x[1].ToString(), System.Globalization.NumberStyles.HexNumber);

                string result;

                if (y > 3 * z)
                {
                    result = "Старшая степень больше младшей";
                    textBox2.Text = result;
                    english_words(y, z);
                }

                if (y < 3 * z)
                {
                    result = "Старшая степень меньше младшей";
                    textBox2.Text = result;
                    russian_words(y, z);
                }

            } 
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "Ошибка";
                textBox3.Text = "Ошибка";
            }
        }

        private void english_words(int x, int y)
        {
            string[] english_word = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            textBox3.Text = english_word[x];
        }

        private void russian_words(int x, int y)
        {
            string[] russian_word = { "ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
            textBox3.Text = russian_word[y];
        }
    }
}