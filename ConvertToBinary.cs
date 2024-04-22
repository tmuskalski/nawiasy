using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSONS.Ex02
{
    public static class ConvertToBinary
    {
        public static void ShowBinary(int number)
        {
            Console.WriteLine($"Zapis binarny liczby {number} to: {convesion(number)}");
            Console.ReadLine();
        }
        public static string convesion(int number)
        {
            string result=string.Empty;
            while (number>0)
            {
               int rem=number%2;
                if (rem==0) 
                {
                    result=result+"0";
                }
                else
                {
                    result = result + "1"; ;
                }
               number=number/2;
            }
            char[] charArray = result.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
