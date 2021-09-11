using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            //Area de cincufencia
            double raio = 4.5;
            const double pi = 3.14;


            raio = 5.5;

            double area = pi * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);


            // tipos Internos
            bool estaChovendo = true;
            Console.WriteLine("Esta chovendo " + estaChovendo);

            byte idade = 45;
            //só aceita valor positvos
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            // aceita negativo
            Console.WriteLine("Saldo de gols" + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salario" + salario);

            int menorValorInt = int.MinValue; //Mais usado
            Console.WriteLine("Menor int" + menorValorInt);

            uint populacaoBrasileira = 207_600-00-000;
            Console.WriteLine("População Brasileira" + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor Long" + menorValorLong);

            ulong populacaoMundial = 7_600_600_000;
            //Não pode sinal
            Console.WriteLine("População Mundial " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço do computador" + precoComputador); 

            decimal distanciaDasEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia das estrelas" + distanciaDasEstrelas);

            char letra = 'b';
            // '' para só uma letra
            Console.WriteLine("letra" + letra);

            string texto = "Seja Bem vindo ao Curso";
            Console.WriteLine(texto);

        }
    }
}
