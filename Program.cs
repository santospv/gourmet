using System;
using System.Collections.Generic;

namespace Gourmett
{
    class Program
    {
        public static List<Prato> ListPratosNaoMassa = new List<Prato>();
        public static List<Prato> ListPratosMassa = new List<Prato>();
        private static bool inicio;
        private static  Prato prato = new Prato();

        static void Main(string[] args)
        {
            inicio = true;
            principal();

            Console.ReadKey();
        }  
             private static void principal()
        {
            Console.WriteLine("Pense em um prato que vc gosta");
            Console.WriteLine("Pressione enter para proximo");
            Console.ReadKey();

            Console.WriteLine("O prato que vc pensou é massa");
            Console.WriteLine("Digite SIM ou NÃO");
            string pratomassa = Console.ReadLine().ToString();

            if (pratomassa == "Sim")
            {
                TipoPrato(true);
            }
            else
            {
                TipoPrato(false);
            }
        }

        private static void TipoPrato(bool tipo)
        {
            Prato prato = new Prato();

            prato = (tipo ? ListPratosMassa.Count != 0 ? ListPratosMassa[0] : null : ListPratosNaoMassa.Count != 0 ? ListPratosNaoMassa[0] : null);

            if (prato != null)
            {                
                Console.WriteLine("O prato que voce pensou é " + prato.Descricao + "?");
                Console.WriteLine("Digite SIM ou NÃO");
                string naoMassa = Console.ReadLine().ToString();
                if (naoMassa == "Sim")
                {
                    Console.WriteLine("O prato que voce pensou é " + prato.Nome + "?");
                    Console.WriteLine("Digite SIM ou NÃO");
                    naoMassa = Console.ReadLine().ToString();
                    if (naoMassa == "Sim")
                    {
                        Console.WriteLine("Acertei de novo");
                        principal();
                    }
                    else
                    {
                        NovoPrato(tipo);
                    }                        
                }
                else
                {
                    NovoPrato(tipo);
                }
            }

            if (tipo)
            {
                Massa();
            }
            else
            {
                Console.WriteLine("O prato que voce pensou é Bolo de chocolate?");
                Console.WriteLine("Digite SIM ou NÃO");
                string boloCholocate = Console.ReadLine().ToString();

                if (boloCholocate == "Sim")
                {
                    prato.Nome = "Bolo de chocolate";
                    prato.tipo = 1;
                    ListPratosNaoMassa.Add(prato);
                    Console.WriteLine("Acertei de novo");
                }
                else
                {
                    NovoPrato(false);
                }
            }
        }

        private static void Massa() {
            Console.WriteLine("O Prato que vc pensou é lasanha?");
            Console.WriteLine("Digite SIM ou NÃO");

            string pratoLasanha = Console.ReadLine().ToString();

            if (pratoLasanha == "Sim")
            {
                prato.Nome = "lasanha";
                prato.tipo = 0;
                ListPratosMassa.Add(prato);
                Console.WriteLine("Acertei de novo");
                principal();
            }
        }

        private static void NovoPrato(bool massa)
        {
            Console.WriteLine("Qual prato que vc pensou?");

            prato.Nome = Console.ReadLine().ToString();
            prato.tipo = 1;
            Console.WriteLine("Complete a frase");
            if (!massa)
            {
                Console.WriteLine(prato.Nome + " é________mas bolo de cholocate não");
                prato.Descricao = Console.ReadLine().ToString();

                ListPratosNaoMassa.Add(prato);
            }
            else
            {
                Console.WriteLine(prato.Nome + " é________mas bolo de lasanha não");
                prato.Descricao = Console.ReadLine().ToString();

                ListPratosMassa.Add(prato);
            }

            inicio = false;
            principal();
        }
     }
 }



