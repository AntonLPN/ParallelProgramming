using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] anArray = new int[10];

            FillArrayRand(anArray);

            Console.WriteLine("Значения массива");
            foreach (var item in anArray)
            {
                Console.Write(item.ToString() + " |");
            }

            Console.WriteLine();

            Task[] arrTask =
            {
                Task.Run(()=>Console.WriteLine($"Task1 Максималльное значение массива {anArray.Max()}")),
                Task.Run(()=>Console.WriteLine($"Task2 Минимальное значение массива {anArray.Min()}")),
                Task.Run(()=>Console.WriteLine($"Task3 Среднее значение массива {anArray.Average()}")),
                Task.Run(()=>Console.WriteLine($"Task4 Сумма значений массива {anArray.Sum()}")),
            };

            Task.WaitAll(arrTask);
            Console.WriteLine("All execute");
            Console.ReadKey();


        }
        /// <summary>
        /// Метод заполнения массива случайными числами
        /// </summary>
        /// <param name="arr"></param>
       static void FillArrayRand(int[] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 10);
            }
        }

    }
}
