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
            File.Create("C:/temp/K1/t1.txt");
            StreamWriter fl1 = new StreamWriter("C:/temp/K1/t1.txt");
            StreamWriter fl2 = new StreamWriter("C:/temp/K1/t2.txt");
            fl1.WriteLine("Иванов Иван Иаванович, 1965 г рождения, место жительства г. Саратов");
            fl2.WriteLine("Петров Сергей Федорович 1966 г рождения, место жительства г. Энгельс");
            File.Create("C:/temp/K2/t3.txt");
            StreamWriter fl3 = new StreamWriter("C:/temp/K2/t3.txt");
            StreamReader fl1_r = new StreamReader("C:/temp/K1/t1.txt");
            StreamReader fl2_r = new StreamReader("C:/temp/K1/t2.txt");
            string fl_s1 = fl1_r.ReadLine();
            string fl_s2 = fl2_r.ReadLine();
            fl3.WriteLine(fl_s1);
            fl3.WriteLine(fl_s2);
            FileInfo flInf = new FileInfo("C:/temp/K1/t1.txt");
            flInf = new FileInfo("C:/temp/K1/t2.txt");
            flInf = new FileInfo("C:/temp/K2/t3.txt");
        }
    }
}
