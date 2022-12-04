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
            Yerevan,
            Gyumri,
            Vanadzor,
            Ejmiacin,
            Abovyan,
            Dilijan,
            Ijevan,
            Gavar,
            Goris,
            Kapan,
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