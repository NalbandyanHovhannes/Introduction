namespace Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(TestEnum.Abovyan);
            
            Console.WriteLine(TestEnum.Abovyan.ToString());
            Console.WriteLine((int)TestEnum.Abovyan);

        }
        public enum TestEnum
        {
            Yerevan,//Start with 0 element
            Gyumri,
            Vanadzor,
            Ejmiacin,
            Abovyan,
            Dilijan,
            Ijevan,
            Gavar,
            Goris,//if we set this  Goris=11 after it setted  12/13
            Kapan,//=12
            Sisian,
            Hrazdan,
            Artashat,
            Armavir,
            Sevan,
            Charencavan,
            Masis,
            Ararat,
            Ashtarak,
            Artik,
            Tsaxkadzor
        }
    }
}