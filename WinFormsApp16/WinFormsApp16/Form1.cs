namespace WinFormsApp16
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
            List<int> numberList = new List<int>();

            for (int i = 0; i < a.Length; i++)
            {
                if (int.TryParse(a[i], out int number))
                {
                    numberList.Add(number);
                }
            }

            listOfArrays.Add(numberList);
            textBox1.Text = "";
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < listOfArrays.Count; i++)
            {
                string addArr = string.Join(", ", listOfArrays[i]);
                listBox1.Items.Add(addArr);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            int colums = listOfArrays[0].Count;
            int middleColumn = colums / 2;
            for (int j = 0; j < listOfArrays.Count; j++)
            {
                for (int k = 0; k < middleColumn; k++)
                {
                    int temp = listOfArrays[j][k];
                    listOfArrays[j][k] = listOfArrays[j][colums - 1 - k];
                    listOfArrays[j][colums - 1 - k] = temp;
                }
            }

            listBox2.Items.Clear();

            for (int i = 0; i < listOfArrays.Count;i++)
            {
                string joinSwapNumbers = string.Join(", ", listOfArrays[i]);
                listBox2.Items.Add(joinSwapNumbers);
            }
        }
    }
}