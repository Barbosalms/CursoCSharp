using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos                                                             
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variaveis e Constantes - Fundamentos",VariaveisEConstantes.Executar },
                {"Notação Ponto - Fundamentos ",NotacaoPonto.Executar },
                {"Lendo Dados  - Fundamentos", LendoDados.Executar },
                {"Formatando Numeros  - Fundamentos", FormatandoNumeros.Executar },
                {"Operadores Aritmetricos  - Fundamentos", OperadoresAritmeticos.Executar },
                {"Exercício 1 - Fundamentos", Exercicios.Executar },
                {"Exercício IF e ELSE - Fundamentos", ExercicoIfElse.Executar },
                // Estruturas de Controle
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Exercicio Switch - Estruturas de Controle", ExercicioSwitch.Executar},
                {"Estrutura While e For - Estruturas de Controle", EstruturaWhileEFor.Executar},
                {"Exercicio While e For - Estruturas de Controle", ExercicioRepeticao.Executar},
                {"Estrutura Foreach - Estruturas de Controle", EstruturaForeach.Executar},
                //Classes e Metodos
                {"Classes e Metodos - Classes e Metodos", Membros.Executar},
                {"Metodos com retorono - Classes e Metodos", MetodosComRetorno.Executar},
                {"Exercicio Metodos e Classes - Classes e Metodos", ExerciciosMetodosComRetorno.Executar},
                {"Metodos Estáticos - Classes e Metodos", MetodosEstaticos.Executar},
                {"Parametros - Classes e Metodos", Params.Executar},
                {"GET e SET - Classes e Metodos", GetSet.Executar},
                {"GET e SET 2 - Classes e Metodos", GetESetSegundoExemplo.Executar},
                {"Exercicio 1 GET e SET  - Classes e Metodos", ExGetESet1.Executar},
                {"Exercicio 2 GET e SET  - Classes e Metodos", ExGetESet2.Executar},
                {"Exercicio 3 GET e SET  - Classes e Metodos", ExGetESet3.Executar},
                //Colecoes
                {"Arrays - Colecoes", Arrays.Executar},
                {"Queue - Colecoes", ColecoesQueue.Executar},
                


            }); ;

            central.SelecionarEExecutar();
        }
    }
}