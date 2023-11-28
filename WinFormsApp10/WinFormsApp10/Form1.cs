namespace WinFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] a = textBox1.Text.Split(',');
            string[] b = textBox2.Text.Split(',');

            int[] numberStringOne = new int[a.Length];
            int[] numberStringTwo = new int[b.Length];

            for (int i = 0; i < a.Length; i++)
            {
                if (int.TryParse(a[i], out int resultOne))
                {
                    numberStringOne[i] = resultOne;
                }
            }

            for (int j = 0; j < b.Length; j++)
            {
                if (int.TryParse(b[j], out int resultTwo))
                {
                    numberStringTwo[j] = resultTwo;
                }
            }

            int c;
            int[] mergedArr = numberStringOne.Concat(numberStringTwo).ToArray();

            for (int k = 0; k < mergedArr.Length; k++) 
            {
                for (int l = k + 1; l < mergedArr.Length; l++) 
                {
                    if (mergedArr[k] > mergedArr[l])
                    {                    
                        c = mergedArr[k];
                        mergedArr[k] = mergedArr[l];
                        mergedArr[l] = c;
                        textBox3.Text = string.Join(", ", mergedArr);
                    }
                }
            }
        }
    }
}