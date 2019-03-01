using System;

namespace Argumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 0; n < args.Length; n++)
            {
                Console.WriteLine(args[n]);
            }
            Console.ReadKey();
        }
    }
}
