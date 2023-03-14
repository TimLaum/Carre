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
           Console.WriteLine($"Le carré vaut : {Carre(4)}");
        }
    }
}
