using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Exercicios
{
    class Ex1
    {
        public static bool PodeAtaqueRapido(bool estadoCavaleiro)
        {
            if (estadoCavaleiro == true)
            {
                Console.WriteLine("Annalyn deu um ataque rapido no cavaleiro");
                return true;
            }
            else
            {
                Console.WriteLine("Não pode realizar o ataque rapido");
                return false;
            }
        }

        public static bool PodeSerEspionado(bool estadoCavaleiro, bool estadoArqueiro)
        {
            if (estadoCavaleiro == true || estadoArqueiro == true)
            {
                Console.WriteLine("Você esta sendo espionado, alguem esta acordado");
                return true;
            }
            else
            {
                Console.WriteLine("Esta livre todos estão dormindo");
                return false;
            }
        }

        public static void SinanlizarPrisioneiro(bool estadoArqueiro, bool estadoPrisioneiro)
        {

            if (estadoArqueiro == true && estadoPrisioneiro == false)
            {
                Console.WriteLine("Prisioneiro esta sinalizado, só cuidado, arqueiro esta acordado.");
            }
            else
            {
                Console.WriteLine("Prisioneiro está dormindo, não da de sinalizalo");
            }
        }

        public static bool PrisioneiroLivre(bool estadoArqueiro, bool estadoPrisioneiro, bool estadoCachorro)
        {
            if (estadoPrisioneiro == false && estadoArqueiro == true)
            {
                Console.WriteLine("Uma entrada com calma sera feita pelo campo, e o prisioneiro esta livre");
                return true;
            }
            else if (estadoPrisioneiro == true)
            {
                Console.WriteLine("Você assustou o prisioneiro, e os outros foram alertados.");
                return false;
            }
            else if (estadoArqueiro == true && estadoCachorro == true)
            {
                Console.WriteLine("Você assutou o cavaleiro com o cachorro, e com isso foram rapido o bastante para salvar o prisioneiro.");
                return true;
            }
            else
            {
                Console.WriteLine("Você não conseguiu salva-lo");
                return false;
            }
        }


        public static bool InicializaOpcao(string opcao)
        {

            if (opcao == "S")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static void Executar()
        {
            string opcao = "";
            bool verificador = false;

            do
            {
                Console.WriteLine("Informe se o Cachorro esta com Annalyn [S/N]");
                opcao = Console.ReadLine();

                if (opcao == "S" || opcao == "N")
                {
                    verificador = true;
                }
                else
                {
                    verificador = false;
                    Console.WriteLine("Informe o caractere corretamente");
                }


            } while (verificador == false); ;

            bool estadoCachorro = InicializaOpcao(opcao);

            do
            {
                Console.WriteLine("Você esta observando eles, informe quem esta acordado");
                Console.WriteLine("O cavaleiro esta dormindo ? [S/N] ");
                opcao = Console.ReadLine();

                if (opcao == "S" || opcao == "N")
                {
                    verificador = true;
                }
                else
                {
                    verificador = false;
                    Console.WriteLine("Informe o caractere corretamente");
                }


            } while (verificador == false); ;

            bool estadoCavaleiro = InicializaOpcao(opcao);

            do
            {
                Console.WriteLine("Você esta observando eles, informe quem esta acordado");
                Console.WriteLine("O arqueiro esta dormindo ? [S/N]");
                opcao = Console.ReadLine();

                if (opcao == "S" || opcao == "N")
                {
                    verificador = true;
                }
                else
                {
                    verificador = false;
                    Console.WriteLine("Informe o caractere corretamente");
                }


            } while (verificador == false); ;

            bool estadoArqueiro = InicializaOpcao(opcao);
            SinanlizarPrisioneiro(estadoArqueiro, estadoCavaleiro);



            do
            {
                Console.WriteLine("Você esta observando eles, informe quem esta acordado");
                Console.WriteLine("O prisioneiro esta dormindo ?");
                opcao = Console.ReadLine();

                if (opcao == "S" || opcao == "N")
                {
                    verificador = true;
                }
                else
                {
                    verificador = false;
                    Console.WriteLine("Informe o caractere corretamente");
                }


            } while (verificador == false); ;


            bool estadoPrisioneiro = InicializaOpcao(opcao);

            PodeSerEspionado(estadoCavaleiro, estadoArqueiro);

            bool sucesso = PrisioneiroLivre(estadoArqueiro, estadoPrisioneiro, estadoCachorro);

            if (sucesso == true)
            {
                Console.WriteLine("Parabéns");
            }
            else
            {
                Console.WriteLine("Tente novamente");
            }

        }

    }
}
