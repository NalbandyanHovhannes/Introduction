using System.Text;

namespace Methods
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[10];
            int b = arr.Length;
            for (int i = 0; i <= b; i++)
            {
                arr[i] = arr[(i-1) + (i-2)];
            }
            Console.WriteLine(arr);

            //for(int i = 0;i <= 10;i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}



            //string aaa = "aabcaddaa";
            //int sum = 0;
            //for (int i = 0; i < aaa.Length; i++)
            //{
            //    if (aaa[i] == 'a')
            //    {
            //        sum++;
            //    }
            //}




            //Console.WriteLine(sum);

            //StringBuilder sb = new StringBuilder();
            //sb.Append("aaa");

            //StringBuilder sb2 = new StringBuilder();
            //sb2.Append("bbb");


            //TestDouble(45);
            //TestInt(30);
            //MethodInt(13);
            //TestVoid(9);

            //kanch
            //Meth();
            //Meth("tets");
            //Meth(85);
            //Meth(74, 96);
            //Meth(45, "jyfcjy");

        }

        //public static int Meth()
        //{
        //    int t = 848;
        //    int y = 654151;
        //    string h = "asfj,hbsdjkhf";
        //    Console.WriteLine(h);
        //    if (true)
        //    {
        //        return t;
        //    }
        //    else
        //    {


        //    }

        //}
        //public static string Meth(string s)
        //{
        //    return "kjjjhk";
        //}
        //public static int Meth(int t)
        //{
        //    return 1;
        //}
        //public static void Meth(int t, int y)
        //{

        //}
        //public static void Meth(int t, string y)
        //{

        //}

        //public static void TestVoid(int t)
        //{
        //    int calc = 626;
        //    var sum = -648641;
        //    Console.WriteLine(t * calc);

        //}
        //public static int MethodInt(int x)

        //{
        //    int sum = x * 50000;
        //    return sum;
        //}
        //public static double TestDouble(int x)
        //{
        //    var sum = x * x;
        //    return sum;
        //}
        //public static int TestInt(int x)
        //{
        //    var sum = x * x;
        //    return sum;
        //}

        ////Method OverLoading

        ////Method input parameters must be different
        //public void TestOverload(int x)
        //{ }
        //public void TestOverload(int x, int y)
        //{ }
        //public void TestOverload(int x, int y, int z)
        //{ }

    }
}