namespace Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 8;
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }

            var t = a > b ? a : b;
            Console.WriteLine(t);

            switch (a)
            {
                case 2:
                    {
                        Console.WriteLine(a);
                        break;
                    };
                case 3:
                    {
                        Console.WriteLine(a);
                        break;
                    };

                case 4:
                    {
                        Console.WriteLine(a);
                        break;
                    };

                case 5:
                    {
                        Console.WriteLine(a);
                        break;
                    };



            }
        }
    }
}