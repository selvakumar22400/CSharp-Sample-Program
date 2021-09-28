using System;
using System.Collections.Generic;
using System.Text;

namespace programs_If_For_While_DoWhile
{
    class While
    {
        public void methodnameWHILE()
        {
            int num ,rem, reverse=0;//3
            Console.Write("enter the number : ");
            num = int.Parse(Console.ReadLine());
            while (num != 0)//23//2
            {
                rem = num % 10;//23%10=3//0
                reverse = reverse*10 + rem;//0+3=3//
                num = num / 10;//23/10=2
            }
            
            
            Console.WriteLine("reversed number is :" + reverse);
            

        }
    }
}
