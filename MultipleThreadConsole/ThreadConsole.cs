using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultipleThreadConsole
{
    public class ThreadConsole
    {
        public void SyncExecution()
        {
            CostTimeTask();
        }

        public void ExecutionInMultipleThread()
        {
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
