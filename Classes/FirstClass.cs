namespace Classes
{
    public class FirstClass
    {
        public int v;
        public int a;
        public static void MyMethod(int t)
        {
            Console.WriteLine(t);

        }

        //Default Constructor
        public FirstClass()
        {

        }
        //Constructor with parameter // its like method overloading 
        public FirstClass(int u)
        {
            v = u;
            MyMethod(u);
        }
    }
}
