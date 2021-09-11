using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaForEach
    {
        public static void Executar() {
            var palavra = "Opa!";


            // cada caractere vai virar uma letra 
            foreach (var letra in palavra) {
                Console.WriteLine(letra);
            }


            var alunos = new string[] { "Ana", "Bia", "Carlos" };

            foreach (string aluno in alunos) {
                Console.WriteLine(aluno);
            }
        }
    }
}
