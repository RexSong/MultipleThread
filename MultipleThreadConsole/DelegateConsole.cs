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
            IAsyncResult result = t.BeginInvoke("a", null, null);

            var a = t.EndInvoke(result);
            Console.WriteLine(a);
        }


        private string ReturnValueTask(string input)
        {
            return "Return value is " + input;
        }

    }
}
