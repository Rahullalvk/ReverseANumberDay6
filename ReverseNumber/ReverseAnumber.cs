using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    internal class ReverseAnumber
    {
        public static void DisplayReverseOfaNumber() 
        {
            int reverse =0, rem=0;
            Console.WriteLine("Enter the number :");
            int n =Convert.ToInt32(Console.ReadLine());
            while (n !=0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n=n / 10;
            }
            Console.WriteLine(reverse);
        }
    }
}
