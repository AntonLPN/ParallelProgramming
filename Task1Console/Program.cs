using System;
using System.Threading;
using System.Threading.Tasks;
namespace Task1Console
{
    class Program
    {
        static void Main(string[] args)
        {

            DoWork();
            Console.ReadLine();
        }

        static void DoWork()
        {
            Task task = new Task(() => Console.WriteLine("TaskStart 1 " + DateTime.Now.ToString()));
            task.Start();
            Task task2 = Task.Factory.StartNew(() => Console.WriteLine("TaskFactory 2 " + DateTime.Now.ToString()));
            Task.Run(() => Console.WriteLine("TaskRun 3 " + DateTime.Now.ToString()));
        }


    }
}
