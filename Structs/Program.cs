namespace Structs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestStruct testStruct = new TestStruct();
            TestStruct testStruct1 = new TestStruct(8);
            testStruct.TestMethod();

        }
    }
}