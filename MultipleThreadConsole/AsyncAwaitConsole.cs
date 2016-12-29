using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultipleThreadConsole
{
    public class AsyncAwaitConsole : MultipleThreaded
    {
        public void ExecuteInMultipleThread()
        {
            GetLengthAsync();
        }

        private async Task<int> GetLengthAsync()
        {
            Console.WriteLine("GetLengthAsync Start");
            string str = await GetStringAsync();
            Console.WriteLine("GetLengthAsync End");
            return str.Length;
        }

        private Task<string> GetStringAsync()
        {
            return Task.Run(() => { Thread.Sleep(2000); return "finished"; });
        }
    }
}
