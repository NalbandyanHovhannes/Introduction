namespace Methods
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            //int sumEd = MethodInt(16);
            //int sumDav = MethodInt(26);
            //Console.WriteLine(sumEd);
            //Console.WriteLine(sumDav);
           
            TestVoid(9);

        }

        static void TestVoid(int t)
        {
            int calc = 626;
            var sum= -648641;
            Console.WriteLine(t*calc);
            
        }



        static int MethodInt(int x)
        //static int MethodInt(16) sumEd

        {
            int sum = x * 50000;            
            return sum;
        }


        public static double TestDouble()
        {
            Console.WriteLine("TestInt");
            return 0;
        }
    }
}