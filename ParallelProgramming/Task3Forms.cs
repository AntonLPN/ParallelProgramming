using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Задание №3
//Создайте оконное приложение, использующее механизм задач (класс Task).
//Пользователь вводит в текстовое поле некоторый текст. По нажатию на кнопку
//приложение должно проанализировать текст и вывести отчет. Отчёт содержит
//информацию о:
// количестве предложений;
// количестве символов;
// количестве слов;
// количестве вопросительных предложений;
// количестве восклицательных предложений.
//Отчёт в зависимости от выбора пользователя отображается на экране или
//сохраняется в файл.
namespace ParallelProgramming
{
    public partial class Task3Forms : Form
    {
        public Task3Forms()
        {
            InitializeComponent();
        }

       async private void button1_Click(object sender, EventArgs e)
        {

         
           
          textBoxCountOffers.Text = await Task.Run(() => CountOffers(this.textBox1.Text).ToString());
            textBoxCountSymbol.Text = await Task.Run(() => CountLength(this.textBox1.Text).ToString());
            textBoxCountWords.Text = await Task.Run(() => CountWords(this.textBox1.Text).ToString());
            textBoxCountQuestion.Text = await Task.Run(() => CountQuestion(this.textBox1.Text).ToString());
            textBoxSeentenceCount.Text = await Task.Run(() => CountSentense(this.textBox1.Text).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string textForFile = string.Empty;
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";


            // сохраняем текст в файл
            if (textBox1.Text != "" && textBoxCountOffers.Text != "" && textBoxCountQuestion.Text != "" &&
                textBoxCountSymbol.Text != "" && textBoxCountWords.Text != "" && textBoxSeentenceCount.Text != "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                // получаем выбранный файл
                string filename = saveFileDialog1.FileName;
                textForFile = "Количесвто предложений " + textBoxCountOffers.Text + "\n" + "Кличесвто символов " + textBoxCountSymbol.Text + "\n" +
                    "Количесвто слов " + textBoxCountWords.Text + "\n" + "Количесвто вопросительных знаков " + textBoxCountQuestion.Text + "\n" +
                    "Количесвто восклицательных знаков " + textBoxSeentenceCount.Text;

                System.IO.File.WriteAllText(filename, textForFile);

                MessageBox.Show("File saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Empty text box info ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }


        /// <summary>
        /// метод определения количества предложений
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static int CountOffers(string text)
        {
           int count = text.Count(c => c == '.' || c=='?' || c=='!');
            return count;

        }

        /// <summary>
        /// метод определения количества символов
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static int CountLength(string text)
        {
            return text.Length;
        }

        /// <summary>
        /// Метод подсчета количесвта слов
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static int CountWords(string text)
        {
           
            
            return text.Count(c => c == ' ' || c == '\r' || c == '.' || c == '!' || c == '?');

        }
        /// <summary>
        /// Метод считает количество вопросительных знаков
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static int CountQuestion(string text)
        {
            return text.Count(c => c == '?');
        }
        /// <summary>
        /// Метод определяет количесвто восклицательных знаков
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static int CountSentense(string text)
        {
           return text.Count(c => c == '!');
        }



      

    }
}
