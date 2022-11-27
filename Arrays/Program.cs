
internal class Program
{
    static void Main(string[] args)
    {
        string[] cars1;
        string[] cars2 = { "Volvo", "BMW", "Ford", "Mazda" };
        int[] myNum = { 10, 20, 30, 40 };
        cars2[0] = "Opel";



        // Create an array of four elements, and add values later
        string[] _oneCars = new string[4];

        // Create an array of four elements and add values right away 
        string[] _twoCars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

        // Create an array of four elements without specifying the size 
        string[] _threeCars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

        // Create an array of four elements, omitting the new keyword, and without specifying the size
        string[] _fourCars = { "Volvo", "BMW", "Ford", "Mazda" };

        int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };



        //Multidimensional Arrays

        //int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

        //for (int i = 0; i < numbers.GetLength(0); i++)
        //{
        //    for (int j = 0; j < numbers.GetLength(1); j++)
        //    {
        //        Console.WriteLine(numbers[i, j]);
        //    }
        //}


    }
}