﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.POO
{
    class Abstract
    {
        //abstract não permite fazer instancias referentes a uma classe, apenas por polimorfismo
        public abstract class Celular
        {
            public abstract string Assistente();
            public string Tocar()
            {
                return "Trim, Trim, Trim";
            }

            public class Samsung: Celular
            {
                /*override serve para sobrescrever um método*/
                public override string Assistente()
                {
                    return "Olá meu nome é Bixby";  
                }
            }

            public class Iphone: Celular
            {
                public override string Assistente()
                {
                    return "Olá meu nome é Siri";
                }
            }

        }

        public static void Executar() {

            /*Celular c = new Celular();*/
            var celulares = new List<Celular>
            {
                new Samsung(),
                new Iphone()
            };
        }
    }
}
