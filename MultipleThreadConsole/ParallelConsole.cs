using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultipleThreadConsole
{
    public class ParallelConsole : MultipleThreaded
    {
        public void ExecuteInMultipleThread()
        {
            ThreadWithParallel();
        }

        private void ThreadWithParallel()
        {
            int[] nums = Enumerable.Range(0, 1000000).ToArray();
            long total = 0;

            Parallel.ForEach(nums, (m) => { Console.WriteLine(m);});

            //// Use type parameter to make subtotal a long, not an int
            //Parallel.For<long>(0, nums.Length, () => 0, (j, loop, subtotal) =>
            //{
            //    subtotal += nums[j];
            //    return subtotal;
            //},
            //    (x) => Interlocked.Add(ref total, x)
            //);

            //Parallel.ForEach<int, long>(nums, () => 0, (j, loop, subtotal) =>
            //    {
            //        subtotal += j;
            //        return subtotal;
            //    },
            //    (x) => { Interlocked.Add(ref total, x); }
            //);

            //Console.WriteLine("The total is {0:N0}", total);
            //Console.WriteLine("Press any key to exit");

            
            Console.ReadKey();
        }

        private void SingleThreadTask()
        {
            int[] nums = Enumerable.Range(0, 1000000).ToArray();
            long total = 0;
            foreach (var i in nums)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
