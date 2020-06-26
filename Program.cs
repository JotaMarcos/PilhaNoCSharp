using System;
using EstruturaDoPrograma;

namespace EstruturaDoPrograma
{    class Program
    {
        static void Main()
        {
            var salto = new Pilha();

            salto.Empilha(0);
            salto.Empilha(1);
            salto.Empilha(10);
            salto.Empilha(100);
            salto.Empilha(1000);
            salto.Empilha(10000);
            salto.Empilha(100000);
            salto.Empilha(1000000);
            
            Console.WriteLine(salto.Desempilha());
            Console.WriteLine(salto.Desempilha());
            Console.WriteLine(salto.Desempilha());
            Console.WriteLine(salto.Desempilha());
            Console.WriteLine(salto.Desempilha());
            Console.WriteLine(salto.Desempilha());
            Console.WriteLine(salto.Desempilha());
            Console.WriteLine(salto.Desempilha());
            Console.WriteLine("Desempilhamento Realizado com Sucesso!!!");
                
        }
    }
}