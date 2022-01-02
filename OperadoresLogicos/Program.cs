using System;

namespace OperadoresLogicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operadores Lógicos AND [&&] e OR [ || ]

            Console.WriteLine(true || false);
            Console.WriteLine(false || true);
            Console.WriteLine(true || true);
            Console.WriteLine(false || false);

           

            Console.WriteLine(true && false);
            Console.WriteLine(false && true);
            Console.WriteLine(true && true);
            Console.WriteLine(false && false);

            Console.ReadLine();

        }
    }
}
