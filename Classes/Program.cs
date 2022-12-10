namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FirstClass firstClass0;//
            FirstClass firstClass = new FirstClass();          // object with default constructor
            FirstClass firstClass1 = new FirstClass(8);       // object with parametr constructor 
            FirstClass.MyMethod(9);                          // Static method called in class
            FirstClass firstClass11 = new FirstClass(8);    // object with parametr constructor 
            firstClass.a = 1;                              // set field value on class
        }
    }
}