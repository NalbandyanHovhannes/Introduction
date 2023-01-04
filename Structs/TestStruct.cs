namespace Structs
{
    public readonly  struct TestStruct
    {
        public static int t;
        public void TestMethod()
        {
            
            Console.WriteLine("TestMethod in Struct");
        }
        public TestStruct(int y)
        {
            t = y;
        }
        //public TestStruct()
        //{

        //}

    }
}
