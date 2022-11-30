namespace Methods
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            TestDouble(45);
            TestInt(30);
            MethodInt(13);

            TestVoid(9);

        }

        public static void TestVoid(int t)
        {
            int calc = 626;
            var sum= -648641;
            Console.WriteLine(t*calc);
            
        }
        public static int MethodInt(int x)

        {
            int sum = x * 50000;            
            return sum;
        }
        public static double TestDouble(int x)
        {
            var sum = x * x;            
            return sum;
        }
        public static int TestInt(int x)
        {
            var sum = x * x;
            return sum;
        }

    }
}