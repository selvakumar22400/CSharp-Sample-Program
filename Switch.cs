using System;
using System.Collections.Generic;
using System.Text;

namespace programs_If_For_While_DoWhile
{
    class Switch
    {
        public int methodnameswitch()
        {
            int Days;
            Console.Write("enter number in 1to7 : ");
            Days = Convert.ToInt32(Console.ReadLine());
            switch (Days)
            {
                case 1:
                    Console.WriteLine("today SUNDAY");
                    break;
                case 2:
                    Console.WriteLine("Today Monday");
                    break;
                case 3:
                    Console.WriteLine("Today Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Today Wenesday");
                    break;
                case 5:
                    Console.WriteLine("Today Thersday");
                    break;
                case 6:
                    Console.WriteLine("Today Friday");
                    break;
                case 7:
                    Console.WriteLine("Today Satarday");
                    break;
                default:
                    Console.WriteLine("entered value is wrong");
                    break;


            }
            return Days;
        }


    }
}
