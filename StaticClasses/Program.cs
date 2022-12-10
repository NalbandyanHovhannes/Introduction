namespace StaticClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Static class cant create a object
            StaticTestClass.TestMethod(9);
            StaticTestClass.x = 8;
        }
    }
}