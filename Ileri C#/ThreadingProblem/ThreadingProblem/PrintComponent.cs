using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadingProblem
{
    public class PrintComponent
    {
        private object customObject = new object();
        public void PrintNumbers()
        {
            Monitor.Enter(this);


            for (int i = 0; i < 10; i++)
            {
                Console.Write(i);

            }
            Console.WriteLine();
            Console.WriteLine("---------------------");

            Monitor.Exit(this);


        }
    }
}
