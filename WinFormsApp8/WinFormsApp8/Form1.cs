using System;
using System.Windows.Forms;

namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] a = { 4, 5, 6 };
            int[] b = { 1, 2, 3 };

            listBox1.Sorted = true;

            int[] mergedArray = new int[a.Length + b.Length];
            Array.Copy(a, mergedArray, a.Length);
            Array.Copy(b, 0, mergedArray, a.Length, b.Length);

            listBox1.Items.Clear();

            foreach (int item in mergedArray)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}