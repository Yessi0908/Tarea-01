using System;
using System.Diagnostics.Eventing.Reader;

namespace condiciones
{
    class SentenciasIf
    {
        public static void Main(string[] args)
        {
            int numeroentero = int.Parse(Console.ReadLine());
            if (numeroentero == 7)
            Console.WriteLine("numeroentero es 7. ");

            else if (numeroentero < 0)
                Console.WriteLine("numeroentero es negativo");
            else
                Console.WriteLine("numeroentero no es ninguno de los casos programados");
        }
        }
    }
}
