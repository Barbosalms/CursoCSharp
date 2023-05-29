using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class ExGetESet3
    {
        public class Animal
        {
            int nome;
            int tipo;

            public string Nome { get; set; }
            public string Tipo { get; set; }
        
        }




        public static void Executar()
        {
            var animal = new Animal();


            Console.WriteLine("Informe o nome de uma animal de estimação: ");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe o tipo de uma animal de estimação: ");
            var tipo = Console.ReadLine();
            if (tipo == "Cachorro" && tipo == "Gato" && tipo == "Ave")
            {
                Console.WriteLine($"O nome do animal é {nome} e o tipo dele é {tipo}");
            }
            else
            {
                tipo = "Ave";
                Console.WriteLine($"O nome do animal é {nome} e o tipo dele é {tipo}");
            }


           

        }
    }
}
