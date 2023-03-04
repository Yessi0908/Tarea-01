using System;

namespace Fundamentos
{
    class Tiposdedatos
    {
        public static void Main(string[] args)
        {
            sbyte byteConSigno = sbyte.MaxValue;
            byte byteSinSingo = byte.MaxValue;
            short shortConSingo = short.MaxValue;
            ushort shortSinSingo = ushort.MaxValue;
            int intConSigno = int.MaxValue;
            uint intSinSigno = uint.MaxValue;
            long longConSigno = long.MaxValue;
            ulong longSinSigno = ulong.MaxValue;
            float floatvalor = float.MaxValue;
            double doublevalor = double.MaxValue;
            decimal decimalvalor = decimal.MaxValue;

            Console.WriteLine("Max[sbyte]: {0} ", byteConSigno);
            Console.WriteLine("Max[sbyte]: {0} ", byteSinSingo);
            Console.WriteLine("Max[short]: {0} ", shortConSingo);
            Console.WriteLine("Max[ushort]: {0} ",shortSinSingo);
            Console.WriteLine("Max[int]: {0} ", intConSigno);
            Console.WriteLine("Max[uint]: {0} ", intSinSigno);
            Console.WriteLine("Max[long]: {0} ", longConSigno);
            Console.WriteLine("Max[ulong]: {0} ", longSinSigno);
            Console.WriteLine("Max[float]: {0} ", floatvalor);
            Console.WriteLine("Max[double]: {0} ", doublevalor);
            Console.WriteLine("Max[decimalvalor]: {0} ", decimalvalor);
        }
    }
}
