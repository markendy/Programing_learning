.using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17
{
    delegate void mydel(ref int[] arr);
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1,6,9,4,6,8,2};
            mydel del1 = Sort;
            del1.
        }

        static public void Sort(ref int[] arr)
        {
            for(int i =0; i < arr.Length - 1; i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine(del);
        }
    }
}
