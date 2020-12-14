using System;

namespace POO_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( Conversor.dolarParaReais(10) );

            Console.WriteLine( Conversor.realParaDolar(100) );

            Console.WriteLine( Conversor.realParaEuro(100) );

            Console.WriteLine( Conversor.euroParaReais(10) );
        }
    }
}
