namespace Structs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestStruct testStruct = new TestStruct();
            Console.WriteLine(testStruct.t);          //must be print t default value
            TestStruct testStruct1 = new TestStruct(8);
            testStruct.TestMethod();

        }
    }
}