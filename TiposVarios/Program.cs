﻿using System;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cria variavel tipo int de nome a com valor -10
            int a = -10;
            int b = 54;
            char c = '\u00A9';
            char d = '\u0026';
            double e = 3;
            double f = -7;
            bool g = true;
            bool h = false;


            //Imprime o valor da variavel a
            Console.WriteLine("2 inteiros");
            Console.WriteLine(a);
            Console.WriteLine("");
            Console.WriteLine(b);
            Console.WriteLine("");
            Console.WriteLine("2 carateres");
            Console.WriteLine(c);
            Console.WriteLine("");
            Console.WriteLine(d);
            Console.WriteLine("");
            Console.WriteLine("2 reais");
            Console.WriteLine(e);
            Console.WriteLine("");
            Console.WriteLine(f);
            Console.WriteLine("");
            Console.WriteLine("2 booleanos");
            Console.WriteLine(g);
            Console.WriteLine("");
            Console.WriteLine(h);
            Console.WriteLine("");
            Console.WriteLine();

            Console.WriteLine("Press Enter to close");
            Console.ReadKey();
        }
    }
}
