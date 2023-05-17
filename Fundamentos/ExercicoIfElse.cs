using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class ExercicoIfElse
    {
        public static void Executar()
        {
            /**Console.WriteLine("Em que ano você nasceu? ");
            int ano = int.Parse(Console.ReadLine());
            int idade = 2023 - ano;
            if (idade >= 18 && idade <=70)
            {
                Console.WriteLine("Você é obrigda(o) a votar.");
            }
            else{
                Console.WriteLine("Seu voto é opcional.");
            }
            -----------------------------------------------------------------------
             **/




            /**string passwordValid = "7taz9HvJ";
            Console.WriteLine("Informe uma senha: ");
            string passwordUser = Console.ReadLine();

            if (passwordUser != passwordValid)
            {
                Console.WriteLine("Acesso Negado.");
            }
            else
            {
                Console.WriteLine("Acesso permitido.");
            }
            -----------------------------------------------------------------------
             **/



            /**Console.WriteLine("Informe a primeria nota: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota: ");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a terceira nota: ");
            double n3 = double.Parse(Console.ReadLine());
            double media = (n1 + n2 + n3) / 3;
            Console.WriteLine($"Sua média é {media}");

            if (media >= 7 )
            {
                Console.WriteLine("Aprovado");
            }else if (media >= 5 && media <7)
            {
                Console.WriteLine("Recuperação");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
            --------------------------------------------------------------------------
             **/


            /**Console.WriteLine("Informe seu peso: ");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = (peso / (altura * altura)) * 1000;
            Console.WriteLine(imc);

            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }else if (imc >= 18.5 && imc <= 24.9 )
            {
                Console.WriteLine("Peso normal");
            }else if (imc >= 24.9 && imc <= 29.9)
            {
                Console.WriteLine("Acima do peso");
            }else if (imc >= 29.9 && imc <= 34.9)
            {
                Console.WriteLine("Obesidade Grau |");
            }else if (imc >= 34.9 && imc <= 39.9)
            {
                Console.WriteLine("Obesidade Grau ||");
            }
            else
            {
                Console.WriteLine("Obesidade Grau |||");**/
            }
        }
    }
