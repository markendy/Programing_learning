using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17
{
    delegate void mydel(int f, int t);
    class Program
    {
        static void Main(string[] args)
        {
            SortOp(1, 1, mydel
                );
        }

        static public void SortOp(int mode, int metod, Delegate del_mes)
        {
            EnterArr();
        }

        static public void EnterArr()
        {
            Console.WriteLine("Enter lenght array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter element array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static public void SortFast(double[] arr, long first, long last)
        {
            double p = arr[(last - first) / 2 + first];
            double temp;
            long i = first, j = last;
            while (i <= j)
            {
                while (arr[i] < p && i <= last) ++i;
                while (arr[j] > p && j >= first) --j;
                if (i <= j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    ++i; --j;
                }
            }
            if (j > first) SortFast(arr, first, j);
            if (i < last) SortFast(arr, i, last);
        }

        static public void Viev(int [] arr)
        {
            Console.WriteLine("Sort:\n");
            foreach (var t in arr)
            {
                Console.WriteLine(t);
            }
        }

        static public void SortPuz(ref int[] arr)
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
        }
    }
}
