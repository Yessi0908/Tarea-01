using System;
using System.ComponentModel;

namespace Leer_teclado
{

    /// <summary>
    /// leer datos desde teclado
    /// </summary>
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("suma de 2 numeros");
            Console.Write("ingresa numero 1:");

            string dato= Console.ReadLine();
            int n1=int.Parse(dato);
            Console.WriteLine("Ingresa NO.2: ");
            dato = Console.ReadLine();
            int n2=int.Parse(dato);
            int suma = n1 + n2;
            Console.WriteLine("el resultado es {0}", suma);
        }
    }
}
