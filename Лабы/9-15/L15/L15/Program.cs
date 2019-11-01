using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L15
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory("C:/temp/K1");
            Directory.CreateDirectory("C:/temp/K2");
            StreamWriter fl1 = new StreamWriter("C:/temp/K1");
            StreamWriter fl2 = new StreamWriter("C:/temp/K2");
            File.Create("C:/temp/K1/t1.txt");
        }
    }
}
