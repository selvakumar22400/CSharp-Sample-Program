using System;
using System.Collections.Generic;
using System.Text;

namespace programs_If_For_While_DoWhile
{
    class If
    {
        public int methodnameif()
        {
            int i;
            Console.Write("enter the number :");
            i = Convert.ToInt32(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("this number is even");
            }
            else
            {
                Console.WriteLine("this number is odd");

            }
            return i;
        }

    }
}


