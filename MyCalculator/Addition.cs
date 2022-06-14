using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    public class Addition
    {
        private static int Adding(int x, int y) 
        {
            return x + y;
            //int answer = x + y;
            //Console.WriteLine(Adding(x,y));
        }

        public static void DisplayOutput(int x, int y)
        {
            Console.WriteLine(Adding(x,y));
        }
    }
}
