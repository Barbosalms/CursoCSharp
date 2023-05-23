using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaForeach
    {
        public static void Executar()
        {
            /**var palavra = "Banana";
            foreach(var letra in palavra)
            {
                Console.WriteLine(letra);
            }**/

            // percorrendo um array

            var alunos = new string[] { "José", "Cleiton", "Maria" };
            foreach(var indice in alunos)
            {
                Console.WriteLine(indice);
            }
        }
    }
}
