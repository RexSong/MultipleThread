using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleThreadConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadConsole tc = new ThreadConsole();
            tc.ExecuteInMultipleThread();

            DelegateConsole d = new DelegateConsole();
            d.ExecuteInMultipleThread();

            ParallelConsole p = new ParallelConsole();
            p.ExecuteInMultipleThread();

            Console.Read();
        }
    }
}
