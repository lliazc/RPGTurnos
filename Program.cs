using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGturnos1
{
    class Program
    {
        static void Main(string[] args)
        {
            string escolha;
            Console.WriteLine("BEM VINDO!");
            Console.WriteLine("");
            Console.WriteLine("(1) Novo jogo");
            Console.WriteLine("(2) Sair");
            escolha = Console.ReadLine();

            if (escolha != "2")
            {
                personagem Char = new personagem();
                Char.criarPersonagem();

                itens  Equipes = new itens();
                Equipes.cadastrarItem();

                

            }

            else {

                Console.WriteLine(" Aperte qualquer tecla para continuar.");
                Console.ReadKey();
                Environment.Exit(0);

            }
     

        }
    }
}
