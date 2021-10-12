using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreProblems
{
    class EvenOdd
    {
        public void evenOdd()
        {
            int i;
            Console.Write("Enter a Number : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number");
                Console.Read();
            }
            else
            {
                Console.Write("Entered Number is an Odd Number");
                Console.Read();
            }
        }
    }
}
