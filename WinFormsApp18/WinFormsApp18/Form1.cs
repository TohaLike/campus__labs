using System;

namespace WinFormsApp18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<List<int>> listOfArrays = new List<List<int>>();


        private void button1_Click(object sender, EventArgs e)
        {
            double Min = -100;
            double Max = 100;

            double n = double.Parse(textBox2.Text);
            double[] a = new double[(int)n];

            Random randNum = new Random();

            for (int i = 0; i < a.Length; i++)
            {
                double randonDouble = randNum.NextDouble() * (Max - Min) + Min;
                randonDouble = Math.Round(randonDouble, 2);
                a[i] = randonDouble;

                listBox1.Items.Add(a[i]);
            }

            textBox1.Text += mul_elem(a);
        }

        static double mul_elem(double[] a)
        {
            double minElem = a[0];
            double maxElem = a[0];

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < minElem)
                {
                    minElem = a[i];
                }

                if (a[i] > maxElem)
                {
                    maxElem = a[i];
                }
            }

            double result = minElem * maxElem;
            result = Math.Round(result, 4);

            return result;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}