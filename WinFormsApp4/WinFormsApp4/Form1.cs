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
                case "�": case "�": textBox2.Text = "���� ��������"; break;
                case "�": case "�": textBox2.Text = "����"; break;
                case "�": case "�": textBox2.Text = "ϸ��"; break;
                case "�": case "�": textBox2.Text = "�������"; break;
                case "�": case "�": textBox2.Text = "��������"; break;
                case "�": case "�": textBox2.Text = "�������"; break;
                default: textBox2.Text = "�� �������"; break;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text)) textBox2.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string x = textBox1.Text;

            switch (x)
            {
                case "�": case "�": textBox2.Text = "���� ��������"; break;
                case "�": case "�": textBox2.Text = "����"; break;
                case "�": case "�": textBox2.Text = "ϸ��"; break;
                case "�": case "�": textBox2.Text = "�������"; break;
                case "�": case "�": textBox2.Text = "��������"; break;
                case "�": case "�": textBox2.Text = "�������"; break;
                default: textBox2.Text = "�� �������"; break;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text)) textBox2.Text = "";
        }
    }
}