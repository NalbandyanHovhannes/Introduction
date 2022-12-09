namespace Classes
{
    public  class FirstClass
    {
       public int v;
      public  int a;
        public static void MyMethod(int t)
        {
            Console.WriteLine(t);

        }
        public FirstClass()
        {

        }
        public FirstClass(int u)
        {
            
            v = u; 
            MyMethod(u);
        }
    } 
}
