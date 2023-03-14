using System;

namespace Carre
{
    class Program
    {
	static public int Carre(int i){
		i = i*i;
		return i;
	}
        static void Main(string[] args)
        {
           int x = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine($"Le carré vaut : {Carre(x)}");
        }
    }
}
