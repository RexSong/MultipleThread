using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;

namespace MultipleThreadConsole
{
    delegate string ReturnTask(string x);
    public class DelegateConsole:MultipleThreaded
    {
        public void ExecuteInMultipleThread()
        {
            ReturnTask t = ReturnValueTask;
            t.BeginInvoke("a", ExecutionComplete, t);

            //IAsyncResult ar = t.BeginInvoke("a", null, null);
            //var result = t.EndInvoke(ar);
            //Console.WriteLine(result);

            //TO DO other things in main thread
        }


        private string ReturnValueTask(string input)
        {
            return "Return value is " + input;
        }

        private void ExecutionComplete(IAsyncResult ar)
        {
            if(ar == null) return;
            var returnTask = ar.AsyncState as ReturnTask;
            if (returnTask != null)
            {
                var result = returnTask.EndInvoke(ar);
                Console.WriteLine(result);
            }
        }

    }
}
