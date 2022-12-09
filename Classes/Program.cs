namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FirstClass firstClass0;
            FirstClass firstClass = new FirstClass();
            FirstClass firstClass1 = new FirstClass(8);
            FirstClass.MyMethod(9);
            FirstClass firstClass11 = new FirstClass(8);
            firstClass.a = 1;

        }
    }
}