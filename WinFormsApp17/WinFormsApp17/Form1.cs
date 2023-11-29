using System.Drawing.Drawing2D;

namespace WinFormsApp17
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
            string[] a = textBox1.Text.Split(',');
            List<int> numberList = new List<int>(); //динамический список в C#, который предоставляет динамический массив, который может увеличиваться или уменьшаться по мере необходимости. 

            for (int i = 0; i < a.Length; i++)
            {
                if (int.TryParse(a[i], out int number)) //это конструкция в C#, которая пытается преобразовать строку a[i] в целое число (int).
                {
                    numberList.Add(number);
                }
            }

            listOfArrays.Add(numberList);
            UpdateListBox();
            textBox1.Text = "";
        }

        private void UpdateListBox()
        {
            listBox1.Items.Clear();
            foreach (List<int> array in listOfArrays)
            {
                string addArr = string.Join(", ", array);
                listBox1.Items.Add(addArr);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int maxColumnIndex = -1;
            int maxSeriesLength = 0;

            for (int m = 0; m < listOfArrays[0].Count; m++)
            {
                int currentSeriesLength = 1;

                for (int n = 1; n < listOfArrays.Count; n++)
                {
                    if (listOfArrays[n][m] < listOfArrays[n - 1][m])
                    {
                        currentSeriesLength = 1;
                    }
                    else
                    {
                        currentSeriesLength++;
                    }

                    if (currentSeriesLength > maxSeriesLength)
                    {
                        maxSeriesLength = currentSeriesLength;
                        maxColumnIndex = n;
                    }
                }
            }

            listBox2.Items.Clear();
            for (int row = 0; row < listOfArrays.Count; row++)
            {
                listBox2.Items.Add(listOfArrays[row][maxColumnIndex]);
            }
        }
    }
}