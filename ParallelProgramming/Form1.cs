using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParallelProgramming
{
    public partial class Form1 : Form
    {
        int[] arr = { 1, 1, 5, 1, 1 };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonTask1_Click(object sender, EventArgs e)
        {
            Task1 taskForm = new Task1();
            taskForm.ShowDialog();



        }

        private void buttonTask2_Click(object sender, EventArgs e)
        {
            Task2Form task2Form = new Task2Form();
            task2Form.ShowDialog();
        }

        private void buttonTask3_Click(object sender, EventArgs e)
        {
            Task3Forms task3Forms = new Task3Forms();
            task3Forms.ShowDialog();
        }
    }
}
