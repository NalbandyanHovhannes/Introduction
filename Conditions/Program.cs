namespace Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 8;

            //if else
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

            //switch case
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

                    //Ternor Operator
                    var x1 = 8;
                    var x2 = 9;
                    //if x1 > x2 the value ov x3 must be true
                    var x3 = x1 > x2 ? true : false;
                    //this case like this if else 
                    if (x1>x2)
                    {
                        x3 = true;
                    }
                    else
                    {
                        x3 = false;
                    }

            }
        }
    }
}