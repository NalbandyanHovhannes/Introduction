using System;

namespace NewL
{
    public class Program
    {
        static void Main(string[] args)
        {
            TestClass testClassObj = new TestClass();
            testClassObj.n = "New N";
            testClassObj.x = 10;
            testClassObj.y = 8.4;

            TestClass testClassObj2 = new TestClass();
            testClassObj2.n = "New N2";
            testClassObj2.x = 100;
            testClassObj2.y = 7.4;

            int t = 8;
            t = 9;
            t = 10;

            TestStaticClass.n = "New n string";
            TestStaticClass.n = "New n string second time";


           int first= (int)EnumClass.Monday;
            Console.WriteLine(first);
           string second= EnumClass.Monday.ToString();
            Console.WriteLine(second);


        }
    }
}
