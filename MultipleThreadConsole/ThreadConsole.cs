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
        private object lockObj = new Object();

        public void SyncExecution()
        {
            CostTimeTask();
        }

        public void ExecuteInMultipleThread()
        {
            //ThreadStart is a delegate with no parameter and void return value
            Thread t = new Thread(CostTimeTask);
            Thread t2 = new Thread(CostTimeTaskWithParameter);
            t.Start();
            t2.Start(20);
        }

        private void CostTimeTask()
        {
            //lock (lockObj)
            //{
            //    //do the work sync
            //}
            for (int a = 0; a < 10; a ++)
            {
                Console.WriteLine("Task is execute {0} percent", (a * 10));
                Thread.Sleep(5 * 1000);
            }
        }

        private void CostTimeTaskWithParameter(object parameter)
        {
            var x = (int) parameter;
            for (int a = 0; a < x; a++)
            {
                Console.WriteLine("Task is execute {0} percent", (a * 10));
                Thread.Sleep(5 * 1000);
            }
        }


    }
}
