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
            Directory.Delete("C:/temp/",true); 
            Directory.CreateDirectory("C:/temp/K1");
            Directory.CreateDirectory("C:/temp/K2");

            StreamWriter fl1 = new StreamWriter("C:/temp/K1/t1.txt");
            StreamWriter fl2 = new StreamWriter("C:/temp/K1/t2.txt");
            fl1.WriteLine("Иванов Иван Иаванович, 1965 г рождения, место жительства г. Саратов");
            fl2.WriteLine("Петров Сергей Федорович 1966 г рождения, место жительства г. Энгельс");
            fl1.Close();
            fl2.Close();

            StreamWriter fl3 = new StreamWriter("C:/temp/K2/t3.txt");
            StreamReader fl1_r = new StreamReader("C:/temp/K1/t1.txt");
            StreamReader fl2_r = new StreamReader("C:/temp/K1/t2.txt");
            string fl_s1 = fl1_r.ReadLine();
            string fl_s2 = fl2_r.ReadLine();
            fl3.WriteLine(fl_s1);
            fl3.WriteLine(fl_s2);
            fl3.Close();

            FileInfo flInf = new FileInfo("C:/temp/K1/t1.txt");
            Console.WriteLine("Name 1: "+flInf.FullName);
            Console.WriteLine("Path 1: "+flInf.DirectoryName);
            Console.WriteLine("Length 1: "+flInf.Length);
            flInf = new FileInfo("C:/temp/K1/t2.txt");
            Console.WriteLine("Name 2: " + flInf.FullName);
            Console.WriteLine("Path 2: " + flInf.DirectoryName);
            Console.WriteLine("Length 2: " + flInf.Length);
            flInf = new FileInfo("C:/temp/K2/t3.txt");
            Console.WriteLine("Name 3: " + flInf.FullName);
            Console.WriteLine("Path 3: " + flInf.DirectoryName);
            Console.WriteLine("Length 3: " + flInf.Length);
            fl1_r.Close();
            fl2_r.Close();

            flInf = new FileInfo("C:/temp/K1/t2.txt");
            flInf.MoveTo("C:/temp/K2/t2.txt");
            flInf = new FileInfo("C:/temp/K1/t1.txt");
            flInf.MoveTo("C:/temp/K2/t1.txt");

            Directory.Move("C:/temp/K2", "C:/temp/All");

            Directory.Delete("C:/temp/K1");

            Console.WriteLine("\nlast:\n");
            DirectoryInfo di = new DirectoryInfo("C:/temp/All");
            foreach (var item in di.GetFiles())
            {
                flInf = item;
                Console.WriteLine("Name: " + flInf.FullName);
                Console.WriteLine("Path: " + flInf.DirectoryName);
                Console.WriteLine("Length: " + flInf.Length);
            }

            Console.ReadLine();
        }
    }
}
