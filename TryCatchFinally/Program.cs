namespace TryCatchFinally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadFile(1);
        }

       static void ReadFile(int index)
        {
            // To run this code, substitute a valid path from your local machine
            string path = @"c:\Users\HP\Desktop\SQL-Lesson\Try.txt";
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            char[] buffer = new char[10];

            try
            {
                file.ReadBlock(buffer, index, buffer.Length);
            }

            //if catch block can keep this exception it go there
            catch   (DivideByZeroException e )
            {
                Console.WriteLine("catch exeption" + e.Message);
            }

            //General exception 
            catch (Exception e)
            {
               
                Console.WriteLine("catch exeption" +e.Message);
            }
    
            //Finnaly block almost working
            finally
            {
                if (file != null)
                {
                    file.Close();
                    Console.WriteLine("file.Close();");
                }
                Console.WriteLine("file.Close()22;");

            }
            // Do something with buffer...
        }
    }
}