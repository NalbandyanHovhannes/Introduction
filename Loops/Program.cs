namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int i = 4, j;
            //Console.WriteLine(j = 2 * i);
            int u;
            int y=11;
            Console.WriteLine(y++);
            Console.WriteLine(++y);
            Console.WriteLine(y+=y++);
            Console.WriteLine("56");
            //var p;
            float f = 10.12f;
            long l = 200l;
            Console.WriteLine(l+f);
            int ii=8;
            for (; ; )
            {
                if (ii < 8)
                {
                    Console.WriteLine(ii);

                }
                else break; ii++;
            }

            int sum = 0;
            for (int i = 0; i < 100; i++)
            {
                sum = sum + i;
                Console.WriteLine(sum);
            }
            Console.WriteLine(sum);

            var v = new { Amount = "108" };
            var v1 = new { Amount = 108, Message = "Hello" };
            var people = new { Name = "Hovo", Surname = "Nalbandyan" };
            var t = v.Amount;
            //int u = int.Parse(v.Amount);

            //dynamic
            dynamic d1 = Convert.ToInt32(Console.ReadLine());
            d1 = "tiv";

            Console.WriteLine(d1);
            //var d2 = "a string";
            //d1 = "";
            //var yt = d1 / d2;

            int j = 0;
            int sum2 = 0;
            while (j < 100)
            {//do
                //sum2 = sum + j;
            }

            int k = 0;
            int sum3 = 0; ;
            do
            {
                //sum2 = sum + j;
            } while (k < 100);
        }

        public static void display(int t = 0)
        { Console.WriteLine(t); }
    }
}