// See https://aka.ms/new-console-template for more information
using System;

namespace EstruturaDoPrograma
{
    class Program
    {
        static void Main()
        {
            var s = new Pilha();
            s.Empilha(1);
            s.Empilha(10);
            s.Empilha(100);
            System.Console.WriteLine(s.Desempilha());
            System.Console.WriteLine(s.Desempilha());
            System.Console.WriteLine(s.Desempilha());

        }
    }
}
