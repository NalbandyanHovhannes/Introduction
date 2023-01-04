
internal class Program
{
    static void Main(string[] args)
    {

        //int array1 [] = new int[];
        int _oneCars2 = new int();
    

        var uu=88;
        Math.Sqrt(8.5);
        string[] cars2 = { "Volvo", "BMW", "Ford", "Mazda" };
        int[] myNum = { 10, 20, 30, 40 };
        cars2[0] = "Opel";

        // Create an array of four elements, and add values later
        string[] _oneCars = new string[4];

        // Create an array of four elements and add values right away 
        string[] _twoCars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

        // Create an array of four elements without specifying the size 
        string[] _threeCars = new  string[] { "Volvo", "BMW", "Ford", "Mazda" };

        // Create an array of four elements, omitting the new keyword, and without specifying the size
        string[] _fourCars = { "Volvo", "BMW", "Ford", "Mazda" };

        int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };


        //Multidimensional Arrays

        int[,] numbers1 = { { 1, 4, 2 }, { 3, 6, 8 } };

        //for (int i = 0; i < numbers1.GetLength(0); i++)
        //{
        //    for (int j = 0; j < numbers1.GetLength(1); j++)
        //    {
        //        Console.WriteLine(numbers1[i, j]);
        //    }
        //}


        // xArray[0]; xArray[1]; xArray[2]; xArray[3];
        int[] xArray = {  1, 4, 2 , 3, 6, 8 } ;

        //        int max = 1;

        int max = xArray[0];

        //for (int i = 1; i < xArray.Length; i++)
        //{
        //    //  1<xArray[1];4 xArray[2];
        //    if (max < xArray[i])
        //    {
        //        max = xArray[i];
        //    }
        //}
        //Console.WriteLine(max);

        int[] xArrayBig = { 1, 4, 2, 8, 6, 3 };
        int getV = 8;
        int[] xArrayBig2 = new int[] { };
        int COUT = 0;


        //for (int i = 1; i < xArrayBig.Length; i=+2)
        //{
        //    xArrayBig2[COUT]=xArrayBig[i];
        //    COUT=COUT+1;
        //}
    }
}