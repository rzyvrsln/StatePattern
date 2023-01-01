using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Oyun oyun = new Oyun();

            oyun.yumruyaBas();

            Console.WriteLine();

            oyun.TopItirildi();
            oyun.yumruyaBas();
            

        }
    }
}