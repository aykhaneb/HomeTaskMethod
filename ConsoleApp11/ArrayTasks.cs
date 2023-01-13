using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    internal class ArrayTasks
    {
        internal int[] EnterArray()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }

            return arr;
        }

        internal int[] GetSqrtElements(int[] arr)
        {
           int CountSqrtElements = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if(Math.Sqrt(arr[i])==(int)Math.Sqrt(arr[i]))
                {
                    CountSqrtElements++;
                }
            }
            int[] SqrtElements = new int[CountSqrtElements];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Sqrt(arr[i]) == (int)Math.Sqrt(arr[i]))
                {
                    SqrtElements[index++] = arr[i];
                }
            }
            return SqrtElements;
        }
        internal void Print(int[] arr)
        {
            foreach(var item in arr)
            {
                Console.WriteLine(arr);
            }
        }
    }
}
