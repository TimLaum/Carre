using System;

namespace Carre
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0;
            Console.WriteLine("Donnez un nombre :");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Le carré vaut : {i*i}");
        }
    }
}
