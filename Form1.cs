using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minmax
{
    public partial class Form1 : Form
    {
        //zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz
        Random rnd = new Random();
        int N;
        int Rmin;
        int Rmax;
        int[] Numbers;
        int H;
        int min;
        int max;
        bool log;
        int sum, raz;

        //
        //zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz
        //

        public Form1()
        {
            InitializeComponent();
        }

        //
        //zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz
        //

        private void button5_Click(object sender, EventArgs e)//определение числа
        {
            button3.Text = "Минимум";
            button4.Text = "Максимум";
            button6.Text = "Сумма min и max";
            button7.Text = "Разность min и max";
            button8.Text = "Cреднее всех чисел";
            N = int.Parse(textBox1.Text);
            Rmin = int.Parse(textBox2.Text);
            Rmax = int.Parse(textBox3.Text);
            Numbers = new int[N];//нумерация с 0 до N-1
            dataGridView1.RowCount = N;//кол-во строк(заглавная не в счет)
            int Count = 0;//чтобы числа не повторялись
            while (Count < N)//чтобы числа не повторялись
            { //чтобы числа не повторялись
                H = (int)Math.Round((Rmax - Rmin) * rnd.NextDouble() + Rmin);//чтобы числа не повторялись
                for (int i = 0; i < Count; i++)//чтобы числа не повторялись
                {//чтобы числа не повторялись
                    if (Numbers[i] == H)//чтобы числа не повторялись
                    {//чтобы числа не повторялись
                        goto L1;//чтобы числа не повторялись
                    }//чтобы числа не повторялись
                    dataGridView1[0, i].Value = Numbers[i];//присваеваем i-той строчке значение Nubmers[i]
                }
                    Numbers[Count] = H;//чтобы числа не повторялись
                    Count++;//чтобы числа не повторялись
                L1:;//чтобы числа не повторялись
                //чтобы числа не повторялись
            }//чтобы числа не повторялись
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
        }

        //
        //zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz
        //

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;//отключаем встроенную сортировку в dataGrid
        }

        //
        //zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz
        //

        private void button1_Click(object sender, EventArgs e)//по возростанию
        {
            log = true;
            while (log)//цикл
            {
                log = false;
                for(int i = 0; i < N - 2; i++)//цикл
                {
                    if (Numbers[i] > Numbers[i + 1])//если...
                    {
                        H = Numbers[i];
                        Numbers[i] = Numbers[i + 1];
                        Numbers[i + 1] = H;
                        log = true;
                    }
                }
            }
            for (int i = 0; i < N; i++)//цикл
            {
                dataGridView1[0, i].Value = Numbers[i];
            }
        }

        //
        //zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz
        //

        private void button2_Click(object sender, EventArgs e)
        {
            log = true;
            while (log)//цикл
            {
                log = false;
                for (int i = 0; i < N - 2; i++)//цикл
                {
                    if (Numbers[i] < Numbers[i + 1])//если...
                    {
                        H = Numbers[i];
                        Numbers[i] = Numbers[i + 1];
                        Numbers[i + 1] = H;
                        log = true;
                    }
                }
            }
            for (int i = 0; i < N; i++)//цикл
            {
                dataGridView1[0, i].Value = Numbers[i];
            }

        }

        //
        //zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz
        //

        public void button3_Click(object sender, EventArgs e)
        {
            min = Numbers[0];
            for (int i = 1; i < N; i++)
            {
                if (Numbers[i] < min)
                {
                    min = Numbers[i];
                }
            }
            button3.Text = "min = " + min.ToString();
        }

        //
        //zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz
        //

        public void button4_Click(object sender, EventArgs e)
        {
            max = Numbers[0];
            for (int i = 1; i < N; i++)
            {
                if (Numbers[i] > max)
                {
                    max = Numbers[i];
                }
            }
            button4.Text = "max = " + max.ToString();

        }

        //
        //zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz
        //

        private void button6_Click(object sender, EventArgs e)
        {
            sum = Math.Abs(max) + Math.Abs(min);
            button6.Text = "sum = " + sum.ToString();
        }

        //
        //zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz
        //

        private void button7_Click(object sender, EventArgs e)
        {
            raz = Math.Abs(max) - Math.Abs(min);
            button7.Text = "dif = " + raz.ToString();
        }
        
        //
        //zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz
        //

        private void button8_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                foreach (int value in Numbers)
                {
                    sum += value;
                    button8.Text = "Сумма всех чисел = " + sum.ToString();
                }
            }
            if (radioButton2.Checked)
            {
                foreach (int value in Numbers)
                {
                    sum += value;
                    raz = sum / N;
                    button8.Text = "Среднее арифметическое = " + raz.ToString();
                }
            }
        }
    }
}
