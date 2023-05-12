using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class LendoDados {
        public static void Executar() {
            Console.WriteLine("Qual é o seu nome?: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual é a sua idade?: ");
            // fazendo a conversao para um inteiro 
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é a sua altura?: ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Olá meu nome é "+nome+", minha altura é "+altura+" e minha idade é "+idade+".");



                                                                 
        }

    }
}
