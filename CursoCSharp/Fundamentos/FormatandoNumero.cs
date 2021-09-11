using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.154;

            Console.WriteLine(valor.ToString("F1")); // SÓ UM NUMERO DEPOIS DA VIRGULA
            Console.WriteLine(valor.ToString("C")); //BOTA NA COTA DO DINHEIRO
            Console.WriteLine(valor.ToString("P")); // PERCENTUAL
            Console.WriteLine(valor.ToString("#.##")); // DUAS CASAS DECIMAIS

            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C0", cultura)); // CASA DECIMAL, cultura especifca

            int inteiro = 265;
            Console.WriteLine(inteiro.ToString("D10")); // 000000 esquerdo
        }
    }
}
