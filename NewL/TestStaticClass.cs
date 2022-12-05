using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewL
{
    public static class TestStaticClass
    {
        public static int x = 1;
        public static double y = 2.5;
        public static string n = "Test";
        private static string n2 = "Hello";


        public static void TestMethod()
        {
            Console.WriteLine(n2);
        }
    }
}
