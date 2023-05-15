using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadoresAritmeticos {
        public static void Executar() {
            /*Console.WriteLine("Informe um número :");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe outro número: ");
            int number2 = int.Parse(Console.ReadLine());

            int result = number1 + number2;

            Console.WriteLine("O resultado da soma de "+number1+" + "+number2+ " é igual a "+result);*/

            Console.WriteLine("Informe a base do seu triângulo: ");
            int Base = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a altura do seu triângulo: ");
            int altura = int.Parse(Console.ReadLine());

            int result = (Base * altura) / 2;

            Console.WriteLine("As dimensões do seu trianngulo são de: " +result);
        }
    }
}
