namespace WinFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] b = textBox1.Text.Split(' ').Select(int.Parse).ToArray();
            int[] mergedArr = MergeSortedArrays(b);


            textBox2.Text = string.Join("", mergedArr);
        }



        private int[] MergeSortedArrays(int[] b)
        {
            int result = 0;
            int min = b[0];
            

            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] < min)
                {
                    min = b[i];
                }
               

                result++;
            } 


            return result;
        }
    }
}