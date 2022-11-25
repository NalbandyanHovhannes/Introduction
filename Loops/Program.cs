using System;
using System.Text;


namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i < 100; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);


            int j = 0;
            int sum2 = 0;
            while (j < 100)
            {//do
                sum2 = sum + j;
            }

            int k = 0;
            int sum3 = 0; ;
            do
            {
                sum2 = sum + j;
            } while (k < 100);
        }
    }
}