namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.TextChanged += textBox1_TextChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;

            switch (x)
            {
                case "А": case "а": textBox2.Text = "Анна Давыдова"; break;
                case "И": case "и": textBox2.Text = "Иван"; break;
                case "П": case "п": textBox2.Text = "Пётр"; break;
                case "Н": case "н": textBox2.Text = "Николай"; break;
                case "В": case "в": textBox2.Text = "Владимир"; break;
                case "Г": case "г": textBox2.Text = "Георгий"; break;
                default: textBox2.Text = "Не найдено"; break;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text)) textBox2.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string x = textBox1.Text;

            switch (x)
            {
                case "А": case "а": textBox2.Text = "Анна Давыдова"; break;
                case "И": case "и": textBox2.Text = "Иван"; break;
                case "П": case "п": textBox2.Text = "Пётр"; break;
                case "Н": case "н": textBox2.Text = "Николай"; break;
                case "В": case "в": textBox2.Text = "Владимир"; break;
                case "Г": case "г": textBox2.Text = "Георгий"; break;
                default: textBox2.Text = "Не найдено"; break;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text)) textBox2.Text = "";
        }
    }
}