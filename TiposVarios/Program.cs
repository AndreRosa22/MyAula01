using System;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cria variavel tipo int de nome a com valor -10
            int a = -10;
            float b = 54.0f;
            uint c = 2U;
            long d = 89L;
            ulong e = 22UL;
            decimal f = 21m;
            double g = 41;

            //Imprime o valor da variavel a
            Console.WriteLine(a);
            Console.WriteLine("");
            Console.WriteLine(b);
            Console.WriteLine("");
            Console.WriteLine(c);
            Console.WriteLine("");
            Console.WriteLine(d);
            Console.WriteLine("");
            Console.WriteLine(e);
            Console.WriteLine("");
            Console.WriteLine(f);
            Console.WriteLine("");
            Console.WriteLine(g);
            Console.WriteLine("");
            Console.WriteLine("Press Enter to close");
            Console.ReadKey();
        }
    }
}
