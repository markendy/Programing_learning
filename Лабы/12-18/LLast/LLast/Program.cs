using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLast
{
    class Program
    {
        static string inString;
        static Regex reg;
        static MatchCollection mat;
        static void Main(string[] args)
        {
            inString = Console.ReadLine();
            reg = new Regex(@"[а-я|А-Я]");
            mat = reg.Matches(inString);
            q1();
        }

        static bool Find(char ch)
        {
            foreach (Match m in mat)
            {
                if(ch.ToString() == m.Value)
                {
                    return true;
                }
            }
            return false;
        }

        static void q1()
        {       
            Stack<char> s = new Stack<char>();
            for (int i = 0; i < inString.Length; i++)
            {
                s.Push(inString[i]);
            }
            Stack<char> s1 = new Stack<char>();
            for (int i = 0; i < s.Count;)
            {
                if (Find(s.Peek()))
                {                   
                    s.Pop();          
                }
                else
                {
                    s1.Push(s.Pop());
                }
            }
            int t1L = s1.Count;
            for (int i = 0; i < t1L; i++)
            {
                Console.Write(s1.Pop());
            }
            Console.WriteLine();
        }
    }
}
