using System;
using System.Text;


namespace Introduction
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Value Types
            //dataType     dataName      value

            byte byteType = 25;                //-128    127
            Console.WriteLine(byteType);

            sbyte sbyteType = 25;              //0    255
            Console.WriteLine(sbyteType);

            short shortType = 44;//
            Console.WriteLine(shortType);

            ushort ushortType = 44;//
            Console.WriteLine(ushortType);

            int intType = 654164156;
            Console.WriteLine(intType);

            uint uintType = 654164156;
            Console.WriteLine(uintType);

            long longType = -65416516514564156;
            Console.WriteLine(longType);

            ulong ulongType = 65416516514564156;
            Console.WriteLine(ulongType);

            float fl = 999.12395000009f;//check
            Console.WriteLine(fl);
            
            double doub = 999999999.5456488888;            
            Console.WriteLine(doub);

            decimal dec = 999999999.54564888888888m;
            Console.WriteLine(dec);

            char a = 'a';    //97 Char symbol return int type
            Console.Write(a);
            Console.WriteLine(((float)a));
            Console.Write("a-----------");
            Console.WriteLine(a);

            char b = 'b';

            var u = a + b;//Home 

            bool bl=true;
            Console.WriteLine(bl);           

            //Reverence Types

            string s = "test";//string memory alocation 
            s = "zdljihfhlia";//reassignment string  
            s = "564654";
            Console.WriteLine(s);

            StringBuilder sb = new StringBuilder();
            sb.Append("Test");
            sb.Replace("e", "b"); //Tbst
            s.Substring(2);
            //Console.WriteLine(sb);

            Console.ReadKey();
            DateTime dt = new DateTime();


        }
    }
}