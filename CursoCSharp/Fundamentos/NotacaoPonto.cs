using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            // Acesso e facilidades.
            var saudacao = "ola".ToUpper().Insert(3, "Word").Replace("Word", "Mundo!");
            Console.WriteLine(saudacao);

            Console.WriteLine("teste".Length);

            string valorImportante = null;
            // ? mais seguro
            Console.WriteLine(valorImportante?.Length);
        }
    }
}
