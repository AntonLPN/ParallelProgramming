using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Задание №2
//Создайте приложение, которое ищет в некотором массиве:
// Минимум;
// Максимум;
// Среднее;
// Сумму.
//Используйте массив Task для решения поставленной задачи.
namespace ParallelProgramming
{
    public partial class Task2Form : Form
    {
      

        public Task2Form()
        {
            InitializeComponent();
          

        }


        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processStart = new ProcessStartInfo("ConsoleApp2");

            Process process = Process.Start(processStart);

            process.WaitForExit();
        }
    }
}
