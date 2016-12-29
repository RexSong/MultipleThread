using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultipleThreadConsole
{
    
    public class ThreadConsole: MultipleThreaded
    {
        public void SyncExecution()
        {
            CostTimeTask();
        }

        public void ExecuteInMultipleThread()
        {
            //ThreadStart is a delegate with no parameter and void return value
            Thread t = new Thread(CostTimeTask);
            t.Start();
        }

        private void CostTimeTask()
        {
            for (int a = 0; a < 10; a ++)
            {
                Console.WriteLine("Task is execute {0} percent", (a * 10));
                Thread.Sleep(5 * 1000);
            }
        }

      
    }
}
