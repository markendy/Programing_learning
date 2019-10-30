using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Q1();
            Q2();
        }

        static void Q1()
        {
            Console.WriteLine("Последовательность цифр:");
            string [] posl = Console.ReadLine().Split();
            StreamWriter str = new StreamWriter("txt1.txt");
            Console.WriteLine("От и до?:");
            int na4 = Convert.ToInt32(Console.ReadLine());
            int kon = Convert.ToInt32(Console.ReadLine());
            for(int i = na4; i <= kon; i++)
            {
                str.Write(posl[i]);
            }
            str.Close();
        }
        static void Q2()
        {
            Console.WriteLine("Буква начала строки?:");
            StreamReader str = new StreamReader("txt2.txt");
            string[] textMass = str.ReadToEnd().Split('\r','\n');
            char findCh = Convert.ToChar(Console.ReadLine());
            for (int i = 0; i < textMass.Length;i++)
            {
                if (textMass[i]!="" && textMass[i][0] == findCh)
                {
                    Console.WriteLine(textMass[i]);
                    break;
                }
            }       
            str.Close();
        }
    }
}
