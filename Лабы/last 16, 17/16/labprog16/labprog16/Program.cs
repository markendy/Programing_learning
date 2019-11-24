using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labprog16
{
    interface IRoliki
    {
        bool Tormoz();
        int Speed();
    }
    class MyRolick:IRoliki, IDisposable, IComparable
    {
        string owner;
        bool torm;
        int speed;
        public MyRolick(string own)
        {
            owner = own;
        }
        public bool Tormoz()
        {
            return torm;
        }
        public int Speed()
        {
            return speed;
        }

        public void Dispose()
        {
            Console.WriteLine(">Disposed!");
        }

        public int CompareTo(object obj)
        {
            return speed.CompareTo(obj);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
