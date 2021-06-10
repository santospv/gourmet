using System;
using System.Collections.Generic;

namespace Gourmett
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Prato> ListPratos;
            ListPratos = new List<Prato>();
            Prato pratosMassa = new Prato();
            Prato pratosNaoMassa = new Prato();

            Console.WriteLine("Pense em um prato que vc gosta");
            Console.WriteLine("Pressione enter para proximo");
            Console.ReadKey();

            Console.WriteLine("O prato que vc pensou é massa");
            Console.WriteLine("Digite SIM ou NÃO");

            string pratomassa = Console.ReadLine().ToString();

            if (pratomassa == "Sim")
            {
                Console.WriteLine("O Prato que vc pensou é lasanha?");
                Console.WriteLine("Digite SIM ou NÃO");

                string pratoLasanha = Console.ReadLine().ToString();

                if (pratoLasanha == "Sim")
                {

                    Console.WriteLine("Acertei de novo");
                }
                else
                {
                    Console.WriteLine("Qual prato que vc pensou?");
                    string pratoPensado = Console.ReadLine().ToString();

                    ListPratos.Add(new Prato() { Nome = pratoPensado });

                    Console.WriteLine("Complete a frase");
                    Console.WriteLine(pratoPensado + " é________mas Lasanha não");

                    string descricaoPrato = Console.ReadLine().ToString();

                    ListPratos.Add(new Prato() { Descricao = descricaoPrato });
                }

            }
            else
            {
                if (pratomassa == "Não")
                {
                    Console.WriteLine("O prato que voce pensou é Bolo de chocolate?");
                    Console.WriteLine("Digite SIM ou NÃO");

                    string boloCholocate = Console.ReadLine().ToString();

                    if (boloCholocate == "Sim")
                    {
                        Console.WriteLine("Acertei de novo");

                    }
                    else
                    {
                        Console.WriteLine("Qual prato que vc pensou?");

                        string pratoPensado = Console.ReadLine().ToString();

                        ListPratos.Add(new Prato() { Nome = pratoPensado });

                        Console.WriteLine("Complete a frase");
                        Console.WriteLine(pratoPensado + " é________mas bolo de cholocate não");
                       
                        string descricaoPrato = Console.ReadLine().ToString();

                        ListPratos.Add(new Prato() { Descricao = descricaoPrato });
                    }
                }
            }
            

            //foreach (Prato p in ListPratos)
            //{
            //    Console.WriteLine("O Prato " + p.Nome + " é " +p.Descricao);
            //}


            Console.ReadKey();
   

        }

     }
 }



