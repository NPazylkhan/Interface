using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface ISeries
    {
        int GetNext();
        void Reset();
        void SetStart(int x);
    }
    class Sam :  ISeries
    {
        int start, val;
        public Sam()
        {
            start = val = 0;
        }
        public int GetNext()
        {
            val += 2;
            return val;
        }
        public void Reset()
        {
            val = start;
        }
        public void SetStart(int x)
        {
            start = x;
            val = start;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sam ob = new Sam();

            for (int i = 0; i < 5; i++)
                Console.WriteLine("Get next value:->" + ob.GetNext());
            Console.WriteLine("Reset.");
            ob.Reset();
            for (int i = 0; i < 5; i++)
                Console.WriteLine("Get next value:->" + ob.GetNext());
            Console.WriteLine("Start with 100;");
            ob.SetStart(100);
            for (int i = 0; i < 5; i++)
                Console.WriteLine("Get next value:->" + ob.GetNext());
            Console.ReadKey();
        }
    }
}
