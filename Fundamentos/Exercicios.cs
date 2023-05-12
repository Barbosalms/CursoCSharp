using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Exercicios
    {
        public static void Executar()
        {
            Console.WriteLine("Informe a primeira nota: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota: ");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a terceira nota: ");
            double n3 = double.Parse(Console.ReadLine());

            double media = (n1 + n2 + n3) / 3;

            Console.WriteLine($"Sua média é {media}");
        }
    }
}
