
// 1. Дана матрица A(3,4). Найти наименьший элемент в каждой
// строке матрицы. Вывести исходную матрицу и результаты вычислений.

using System;
using System.Windows.Forms;

namespace WindowsFormsApp20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] min = new int[3];
            dataGridView1.RowCount = 3;
            dataGridView1.ColumnCount = 4; 
            int[,] mas = new int[3, 4]; 
            int i, j;
            Random rand = new Random();

            for (i = 0; i < mas.GetLength(0); i++)
            {
                int m = int.MaxValue;
                for (j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = rand.Next(-50, 50);
                    if (mas[i, j] < m) 
                        m = mas[i, j];
                    dataGridView1.Rows[i].Cells[j].Value = mas[i, j].ToString();
                }
                textBox1.Text += Environment.NewLine;
                min[i] = m;
            }

            textBox1.Text += "Минимальные элементы в" + Environment.NewLine;
            for (i = 0; i < min.Length; i++)
            {
                textBox1.Text += i+1 + " строке: " + min[i] + Environment.NewLine;
            }
        }
    }
}
