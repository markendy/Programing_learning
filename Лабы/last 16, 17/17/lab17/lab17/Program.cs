using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17
{
    delegate void mydel(ref int [] a, int f, int t);
    class Program
    {
        static void Main(string[] args)
        {
            mydel del1;
            Console.WriteLine("metod? 1 or 2");//fast - 1 puz - 2
            int temp = Convert.ToInt32(Console.ReadLine());
            del1 = SortFast;
            if (temp == 2)
            {
                del1 = SortPuz;
            }
            Console.WriteLine("mode? 1 or 2");//> - 1 < - 2
            temp = Convert.ToInt32(Console.ReadLine());          
            SortOp(null, temp, del1);
        }

        static public void SortOp(int [] arr, int mode, mydel del_mes)
        {
            string t = "Metod = SortFast";
            arr = EnterArr();
            Viev(arr);
            if (del_mes == SortPuz)
            {
                del_mes = SortPuz;
                t = "Metod = SortPuz";
            }
            del_mes(ref arr, 0, arr.Length - 1);
            if (mode == 2)
            {
                Array.Reverse(arr);
            }
            Console.WriteLine("\nEnd::\n");
            Console.WriteLine(t);
            Viev(arr);
        }

        static public int[] EnterArr()
        {
            Console.WriteLine("Enter lenght array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter element array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }

        static public void SortFast(ref int[] arr, int first, int last)
        {
            int p = arr[(last - first) / 2 + first];
            int temp;
            int i = first, j = last;
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
            if (j > first) SortFast(ref arr, first, j);
            if (i < last) SortFast(ref arr, i, last);
        }

        static public void Viev(int [] arr)
        {
            Console.WriteLine("\nSortOp:\n");
            foreach (var t in arr)
            {
                Console.WriteLine(t);
            }
        }

        static public void SortPuz(ref int[] arr, int first, int last)
        {
            for(int i =0; i < arr.Length - 1; i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
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
