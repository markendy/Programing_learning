using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kat9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Random r = new Random();
            for(int i = 0; i < n; i++)
            {
                a[i] = r.Next();
            }
            foreach(var t in a)
            {
                Console.WriteLine(t);
            }
        }
    }
}
