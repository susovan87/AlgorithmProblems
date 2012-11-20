using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingleDigitProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            string num;
            do
            {
                Console.Write("Please enter a number:");
                num = Console.ReadLine();
                try
                {
                    int result = GetSingleDigitProduct(Convert.ToInt64(num));
                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }while(num.Length>0);
        }

        static int GetSingleDigitProduct(long n)
        {
            int iteration=0;
            while(n>=10)
            {
                long result = 1;
                iteration++;
                foreach (char c in n.ToString())
                {
                    result *= Convert.ToInt32(c.ToString());
                }
                n = result;
            }
            return iteration;
        }
    }
}
