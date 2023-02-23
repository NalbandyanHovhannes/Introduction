using System.Security.Cryptography.X509Certificates;

namespace Lesspon4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calc(5);
        }

        static void Calc(int a)
        {
            int sum = 0;
            int sum1 = 0;
            for(int i = 1; i <= a; i++) {
                sum += i;
                sum1 = sum / a;
            }
            Console.WriteLine(sum1);

        }

    }
}