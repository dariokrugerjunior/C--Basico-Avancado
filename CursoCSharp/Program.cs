using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.Api;
using CursoCSharp.TopicosAvancados;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolacao - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando numero - Fundamentos", FormatandoNumero.Executar},
                {"Converção - Fundamentos", Convercoes.Executar},
                {"Operadores Aritmetcos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unario - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternario - Fundamentos", OperadorTernario.Executar},
                //Estruturas de Controles
                {"Estrutura if - Estrutura de Controle", EstruturaIf.Executar},
                {"Estrutura if/else - Estrutura de Controle", EstruturaIf.Executar},
                {"Estrutura if/else if - Estrutura de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estrutura de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estrutura de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estrutura de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estrutura de Controle", EstruturaFor.Executar},
                {"Estrutura For Each - Estrutura de Controle", EstruturaForEach.Executar},
                {"Usando Break - Estrutura de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estrutura de Controle", UsandoContinue.Executar},
                //Classes Métodos
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Métodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Métodos Estaticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Atributos Estaticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributos - Classes e Métodos", DesafioAtributo.Executar},
                {"Params - Classes e Métodos", Params.Executar},
                {"Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"Get/Set - Classes e Métodos", GetSet.Executar},
                {"Props - Classes e Métodos", Props.Executar},
                {"Readonly - Classes e Métodos", Readonly.Executar},
                {"Enums - Classes e Métodos", ExemploEnum.Executar},
                {"Struct - Classes e Métodos", ExemploStruct.Executar},
                {"Struct x Classe - Classes e Métodos", StructVsClasse.Executar},
                {"Valor x Referencia - Classes e Métodos", ValorVsReferencia.Executar},
                {"Paremetros por referencias - Classes e Métodos", ParametrosPorReferencia.Executar},
                {"Paremetro Padrão- Classes e Métodos", ParametroPadrao.Executar},
                //Colecoes
                {"Array - Colecões", Colecoes.Array.Executar},
                {"List - Colecões", Colecoes.ColecoesList.Executar},
                {"ArrayList - Colecões", Colecoes.ColecoesArrayList.Executar},
                {"Set - Colecões", Colecoes.ColecoesSet.Executar},
                {"Queue - Colecões", Colecoes.ColecoesQueue.Executar},
                {"Igualdade - Colecões", Colecoes.Igualdade.Executar},
                {"Stack - Colecões", Colecoes.ColecoesStack.Executar},
                {"Dictionary - Colecões", Colecoes.ColecoesDictionary.Executar},
                //Orientação a Objeto
                {"Herança - OO", Heranca.Executar},
                {"This - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", OO.Encapsulamento.Executar},
                {"Polimorfismo - OO", Polimorfismo.Executar},
                {"Classe Abstratc - OO", Abstract.Executar},
                {"Interface - OO", Interface.Executar},
                {"Sealed - OO", Sealed.Executar},
                // Método e Funcôes
                {"Lambda - Métodos e Funções", ExemploLambda.Executar},
                {"Lambdas como Delegate - Métodos e Funções", LambdasDelegate.Executar},
                {"Usando Delegate - Métodos e Funções", UsandoDelegates.Executar},
                {"Deleagate funcão anonima - Métodos e Funções", DelegateFunAnonima.Executar},
                {"Deleagate com parametros - Métodos e Funções", DelegatesComoParametros.Executar},
                {"Métodos de Extensão - Métodos e Funções", MetodosDeExtensao.Executar},
                // Exeções
                {"Primeira Exececão - Excecão", PrimeiraExcecao.Executar},
                {"Exececão Personalizadas - Excecão", ExcecoesPersonalizadas.Executar},
                // Api
                {"Primeiro Arquivo - Usando API", PrimeiroArquivo.Executar},
                {"Lendo arquivos - Usando API", LendoArquivos.Executar},
                {"Exemplo file info - Usando API", ExemploFileInfo.Executar},
                {"Diretorios - Usando API", Diretorios.Executar},
                {"Exemplo diretorio - Usando API", ExemploDirectoryInfo.Executar},
                {"Exemplo Patch - Usando API", ExemploPath.Executar},
                {"Exemplo Date Time - Usando API", ExemploDateTime.Executar},
                {"Exemplo Time Span - Usando API", ExemploTimeSpan.Executar},
                //
                {"LINQ1 - Topicos Avançado", LINQ1.Executar},
                {"LINQ2 - Topicos Avançado", LINQ2.Executar},
                {"Nullables - Topicos Avançado", Nullables.Executar},
                {"Dynamics - Topicos Avançado", Dynamics.Executar},
                {"Genericos - Topicos Avançado", Genericos.Executar},


            }); ;

            central.SelecionarEExecutar();
        }
    }
}