using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            var nome = "Dario";
            // C# identifica automaticamente que tipo ele é
            Console.WriteLine(nome);

            int a;
            //declarando uma variavel
            a = 20;
            //inicilizando 
            int b = 32;
            //declando uma variavel e inicilizando ela 
            int soma = a + b;
            Console.WriteLine("Soma dela" + soma);
        }
    }
}
