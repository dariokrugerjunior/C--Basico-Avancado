using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresUnarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            // inverte o sinal.
            Console.WriteLine(-valorNegativo);
            // inverte o booleano
            Console.WriteLine(!booleano);

            // com uma unidade a mais
            numero1++;
            Console.WriteLine(numero1);
            //com uma unidade a menos
            --numero1;
            Console.WriteLine(numero1);

            Console.WriteLine(numero1++ == --numero2);
            Console.WriteLine($"{numero1} {numero2}");
        }
    }
}

