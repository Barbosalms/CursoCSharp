using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumeros {
        public static void Executar() {

            double valor = 15.3298;
            //arredondodar o número
            Console.WriteLine(valor.ToString("F1"));
            //transformar em moeda
            Console.WriteLine(valor.ToString("C"));
            //formatando do seu jeito
            Console.WriteLine(valor.ToString("#"));
            

        }
    }
}
