using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestWebJob
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Look we are printing Hello World!!! " + DateTime.UtcNow);
                Thread.Sleep(1000);
            }
        }
    }

}
