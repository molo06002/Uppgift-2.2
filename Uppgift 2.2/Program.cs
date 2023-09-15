// See https://aka.ms/new-console-template for more information
using System; 
namespace Uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt hoppade Elin?");
            string x = Console.ReadLine();
            int y = Convert.ToInt32(x);
            Console.Clear();
            Console.WriteLine("Hur långt hoppade Alma?");
            string m = Console.ReadLine();
            int b = Convert.ToInt32(m);
            int O = y - b;
            Console.WriteLine(O);
        }
    }
}