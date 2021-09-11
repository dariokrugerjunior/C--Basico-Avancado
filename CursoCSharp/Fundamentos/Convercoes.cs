using System;

namespace CursoCSharp.Fundamentos
{
    class Convercoes
    {
        public static void Executar()
        {
            //Conversão basico
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            //Conversão explicita
            double nota = 9.5;
            int notaTruncada = (int)nota;
            Console.WriteLine("Nota truncada", +notaTruncada);

            //Conversão de string para numero 
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida : {0}", idadeString);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado : {0}", idadeString);

            Console.WriteLine("Digite um numero");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1); // ele vai tentar, mas se nao conseguir vai dar 0 
            Console.WriteLine("Resultado: {0}", numero1);

            Console.WriteLine("Digite o segundo numero");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado 2: {0}", numero2);



        }
    }
}
