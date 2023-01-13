using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            //var ArrayTask = new ArrayTasks();

            //int[] arr = ArrayTask.EnterArray();

            //ArrayTask.Print(arr);

            //int[] SqrtArr = ArrayTask.GetSqrtElements(arr);

            //ArrayTask.Print(SqrtArr);

            var NumberTask = new NumberTasks();

            int number = NumberTask.EnterNumber();

            int reverseNumber = NumberTask.GetReverseNumber(number);

            Console.WriteLine($"{number}==>{reverseNumber}");
        }
    }
}
