using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        { 
            q1();
            q2();
            q3();
            q4();
            q5();
            Console.WriteLine("Press exit");
            Console.ReadLine();
        }

        static void q1()
        {
            Console.WriteLine("Q1 \nПусть символ # определен в текстовом редакторе как стирающий символ Backspace, т.е. строка abc#d##c в действительности является строкой ac. Дан текст, в котором встречается символ #. Преобразовать его с учетом действия этого символа.");
            Console.WriteLine("Строка?:");
            int del_c = 0;
            string t = Console.ReadLine();
            Stack<char> s = new Stack<char>();
            for (int i = 0; i < t.Length; i++)
            {
                s.Push(t[i]);
            }
            Stack<char> s1 = new Stack<char>();
            for (int i = 0; i < s.Count;)
            {
                if (s.Peek() != '#')
                {
                    if (del_c != 0)
                    {
                        s.Pop();
                        del_c--;
                    }
                    else
                    {
                        s1.Push(s.Pop());
                    }
                }
                else
                {
                    del_c++;
                    s.Pop();
                }
            }
            int t1L = s1.Count;
            for (int i = 0; i < t1L; i++)
            {
                Console.Write(s1.Pop());
            }
            Console.WriteLine();
        }
        static void q2()
        {
            Console.WriteLine("Q2 \nДан файл, содержащий информацию о студентах: фамилия, имя, отчество, номер группы, оценки по трем предметам текущей сессии. За один просмотр файла напечатать элементы файла в следующем порядке: сначала все данные о студентах, успешно обучающихся на 4 и 5, потом данные об остальных студентах, сохраняя исходный порядок в каждой группе сотрудников.");
            StreamReader fl = new StreamReader("test.txt");
            Queue<string[]> mylistIn = new Queue<string[]>();
            Queue<string[]> mylistOut5 = new Queue<string[]>();
            Queue<string[]> mylistOutOst = new Queue<string[]>();
            string[] s = fl.ReadToEnd().Split('\n','\r');
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != "")
                {
                    mylistIn.Enqueue(new string[s[i].Split().Length]);
                    for (int j = 0; j < s[i].Split().Length; j++)
                    {
                        mylistIn.Peek()[j]=(s[i].Split()[j]);
                    }
                    if (Convert.ToInt32(mylistIn.Peek()[4]) < 4 || Convert.ToInt32(mylistIn.Peek()[5]) < 4 || Convert.ToInt32(mylistIn.Peek()[6]) < 4)
                        mylistOutOst.Enqueue(mylistIn.Dequeue());
                    else
                        mylistOut5.Enqueue(mylistIn.Dequeue());
                }              
            }
            int tL1 = mylistOut5.Count;
            int tL2 = mylistOutOst.Count;
            for (int t = 0; t < tL1; t++)
            {
                for (int i = 0; i < mylistOut5.Peek().Length; i++)
                    Console.Write(mylistOut5.Peek()[i]+ " ");
                Console.WriteLine();
                mylistOut5.Dequeue();
            }
            for (int t = 0; t < tL2; t++)
            {
                for (int i = 0; i < mylistOutOst.Peek().Length; i++)
                    Console.Write(mylistOutOst.Peek()[i]+ " ");
                Console.WriteLine();
                mylistOutOst.Dequeue();
            }
        }
        static void q3()
        {
            Console.WriteLine("Q3 \n Тоже что и Q1 с использованием ArrayList");
            int del_c = 0;
            string t = Console.ReadLine();
            Stack<char> s = new Stack<char>();
            for (int i = 0; i < t.Length; i++)
            {
                s.Push(t[i]);
            }
            ArrayList s1 = new ArrayList();
            for (int i = 0; i < s.Count;)
            {
                if (s.Peek() != '#')
                {
                    if (del_c != 0)
                    {
                        s.Pop();
                        del_c--;
                    }
                    else
                    {
                        s1.Add(s.Pop());
                    }
                }
                else
                {
                    del_c++;
                    s.Pop();
                }
            }
            for (int i = 0; i < s1.Count; i++)
            {
                Console.Write(s1[s1.Count-i-1]);
            }
            Console.WriteLine();
        }
        static void q4()
        {
            Console.WriteLine("Q4 \n Тоже что и Q2 с использованием ArrayList");
            StreamReader fl = new StreamReader("test.txt");
            Queue<ArrayList> mylistIn = new Queue<ArrayList>();
            Queue<ArrayList> mylistOut5 = new Queue<ArrayList>();
            Queue<ArrayList> mylistOutOst = new Queue<ArrayList>();
            string[] s = fl.ReadToEnd().Split('\n', '\r');
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != "")
                {
                    mylistIn.Enqueue(new ArrayList());
                    for (int j = 0; j < s[i].Split().Length; j++)
                    {
                        mylistIn.Peek().Add((s[i].Split()[j]));
                    }
                    if (Convert.ToInt32(mylistIn.Peek()[4]) < 4 || Convert.ToInt32(mylistIn.Peek()[5]) < 4 || Convert.ToInt32(mylistIn.Peek()[6]) < 4)
                        mylistOutOst.Enqueue(mylistIn.Dequeue());
                    else
                        mylistOut5.Enqueue(mylistIn.Dequeue());
                }
            }
            int tL1 = mylistOut5.Count;
            int tL2 = mylistOutOst.Count;
            for (int t = 0; t < tL1; t++)
            {
                for (int i = 0; i < mylistOut5.Peek().Count; i++)
                    Console.Write(mylistOut5.Peek()[i] + " ");
                Console.WriteLine();
                mylistOut5.Dequeue();
            }
            for (int t = 0; t < tL2; t++)
            {
                for (int i = 0; i < mylistOutOst.Peek().Count; i++)
                    Console.Write(mylistOutOst.Peek()[i] + " ");
                Console.WriteLine();
                mylistOutOst.Dequeue();
            }
        }
        static void q5()
        {
            Console.WriteLine("Q5\n 5.	Решить задачу, используя класс HashTable: \nреализовать простейший каталог музыкальных компакт - дисков, который позволяет:\nДобавлять и удалять диски.\nДобавлять и удалять песни.\nПросматривать содержимое целого каталога и каждого диска в отдельности.\nОсуществлять поиск всех записей заданного исполнителя по всему каталогу.\n");
            Catalog MyCatalog = new Catalog("MyCatalog");
            MyCatalog.AddDisk(1, "Dick1");
            MyCatalog.AddDisk(2, "Dick2");           
            MyCatalog.DiskOp(1).AddTrack(1, "Noize", "tr1", 3);
            MyCatalog.DiskOp(1).AddTrack(2, "Noize", "tr2", 3);
            MyCatalog.DiskOp(2).AddTrack(3, "NNoize", "tr3", 3);

            Console.WriteLine("Тесты методов Catalog");
            Console.WriteLine("Тест метода SearchAllTreckAutor(\"Noize\")");
            MyCatalog.SearchAllTreckAutor("Noize");
            Console.WriteLine("Тест поля CountDisk = " + MyCatalog.CountDisk);
            Console.WriteLine("Тест метода DelDisk(2) = ");
            MyCatalog.DelDisk(2);
            Console.WriteLine("Тест поля NameCatalog = " + MyCatalog.NameCatalog);
            Console.WriteLine("Тест метода ToString = " + MyCatalog.ToString());
            Console.WriteLine("Тест метода ViewAllTrackList");
            MyCatalog.ViewAllTrackList();
            Console.WriteLine("Тест метода ViewDiskList");
            MyCatalog.ViewDiskList();

            Console.WriteLine("Тесты методов Disk");
            Console.WriteLine("Тест поля CountTrack = " + MyCatalog.DiskOp(1).CountTrack);
            Console.WriteLine("Тесты метода DelTrack(2)");
            MyCatalog.DiskOp(1).DelTrack(2);
            Console.WriteLine("Тесты метода FindTrackAutor(Noize)");
            Disk res = MyCatalog.DiskOp(1).FindTrackAutor("Noize");
            res.ViewTrackOnDisk();
            Console.WriteLine("Тесты метода NameDisk\n" + MyCatalog.DiskOp(1).NameDisk);
            Console.WriteLine("Тесты метода ToString()"+ MyCatalog.DiskOp(1).ToString());          
            Console.WriteLine("Тесты метода ViewTrackOnDisk()");
            MyCatalog.DiskOp(1).ViewTrackOnDisk();

            Console.WriteLine("Тесты методов Track");
            Console.WriteLine("Тесты поля Autor" + MyCatalog.DiskOp(1).TrackOp(1).Autor);
            Console.WriteLine("Тесты поля Long" + MyCatalog.DiskOp(1).TrackOp(1).Long);
            Console.WriteLine("Тесты поля Name" + MyCatalog.DiskOp(1).TrackOp(1).Name);
            Console.WriteLine("Тесты метода ToString() = "+MyCatalog.DiskOp(1).TrackOp(1).ToString());
        }
    }
    public class Catalog
    {
        public string NameCatalog = "First Catalog";
        public Hashtable DiskTable = new Hashtable();
        public int CountDisk = 0;
        public Disk DiskOp(int i)
        {
            Disk DiskOpObj = (Disk)DiskTable[i];
            return DiskOpObj;
        }

        public Catalog(string name)
        {
            NameCatalog = name;
        }

        public void AddDisk(int hash, string NameD)
        {
            DiskTable.Add(hash, new Disk(NameD));
            CountDisk++;
        }
        public void DelDisk(int hash)
        {
            DiskTable.Remove(hash);
            CountDisk--;
        }
        public void ViewDiskList()
        {
            foreach (object ob in DiskTable.Values)
            {
                Console.WriteLine(ob.ToString());
            }
            Console.WriteLine();
        }
        public void ViewAllTrackList()
        {
            foreach (object ob1 in DiskTable.Values)
            {
                Disk ob = (Disk)ob1;
                ob.ViewTrackOnDisk();
            }
            Console.WriteLine();
        }
        public void SearchAllTreckAutor(string autor)
        {
            Disk result = new Disk(autor);
            int h = 0;
            foreach (object ob in DiskTable.Values)
            {
                Disk ob1 = (Disk)ob;
                result = ob1.FindTrackAutor(autor);
                h++;
            }
            result.ViewTrackOnDisk();
        }
        public override string ToString()
        {
            return NameCatalog;
        }
    }
    public class Disk
    {
        public string NameDisk = "First Album";
        public int CountTrack = 0;
        public Hashtable TrackTable = new Hashtable();
        public Track TrackOp(int i)
        {
            Track TrackOpObj = (Track)TrackTable[i];
            return TrackOpObj;
        }


        public Disk(string NameD)
        {
            NameDisk = NameD;
        }

        public void AddTrack(int hash, string auror, string name, int L)
        {
            TrackTable.Add(hash, new Track(auror, name, L));
            CountTrack++;
        }
        private void AddTrackT(int hash, Track tr)
        {
            TrackTable.Add(hash, tr);
            CountTrack++;
        }
        public void DelTrack(int hash)
        {
            TrackTable.Remove(hash);
            CountTrack--;
        }
        public void ViewTrackOnDisk()
        {
            foreach (object ob1 in TrackTable.Values)
            {
                Track ob = (Track)ob1;
                Console.WriteLine(ob.ToString());
            }
            Console.WriteLine();
        }
        public Disk FindTrackAutor(string FAutor)
        {
            Disk result = new Disk(FAutor + " Tracks");
            int hash = 0;
            foreach (object ob1 in TrackTable.Values)
            {
                Track ob = (Track)ob1;
                if (ob.Autor == FAutor)
                {
                    result.AddTrackT(hash, ob);
                }
                hash++;
            }
            return result;
        }
        public override string ToString()
        {
            return NameDisk;
        }
    }
    public class Track
    {
        public string Autor = "Noize MC";
        public string Name = "Vse Kak Y Ludei";
        public int Long = 4;

        public Track(string auror, string name, int L)
        {
            Autor = auror;
            Name = name;
            Long = L;
        }

        public void Start() { }
        public void Stop() { }
        public override string ToString()
        {
            return Autor + ' ' + Name;
        }
    }
}