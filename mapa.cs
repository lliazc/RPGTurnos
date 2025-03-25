using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGturnos1
{
    class mapa
    {
        string viagem;
        string destino;

        public void cidadeCentral()
        {
            Console.WriteLine("Você está na cidade central. ");
            Console.WriteLine("Você deseja viajar para algum local?");
            Console.WriteLine(" [1] sim [2] não");
            viagem = Console.ReadLine();

            if (viagem == "1" || viagem == "sim")
            {
                Console.WriteLine("Você pode viajar para:");
                Console.WriteLine("[1] Porto              [2]Cidade na Floresta");
                Console.WriteLine("[3] Deserto Sem Fim    [4] Minas Esquecidas");
                destino = Console.ReadLine();
                if (destino == "1")
                {
                    Porto();
                }
                else if (destino == "3")
                {
                    Deserto();
                }
                else if (destino == "2")
                {
                    Floresta();
                }
                else if (destino == "4")
                {
                    minasEsquecidas();
                }

            }
            else
            {
                Console.Clear();
                // batalha cidade central 
            }
            

        }

        public void Porto()
        {
            Console.Clear();
            destino = "";
            viagem = "";

            Console.WriteLine("Você esta no porto");
            Console.WriteLine("Daqui você pode ir para ");
            Console.WriteLine("Ilha Solitária ou voltar para a idade central");

            Console.WriteLine("Você deseja viajar para algum local?");
            Console.WriteLine(" [1] sim [2] não");
            viagem = Console.ReadLine();
            Console.Clear();

            if (viagem == "1" || viagem == "sim")
               

            {
            Console.WriteLine("[1] Ilha Solitária  [2] Cidade Central ");
                destino = Console.ReadLine();
                if (destino == "2")
                {
                    cidadeCentral();
                }
                else if (destino == "1")
                {
                    ilhaSolitaria();
                }
              
            } else
            {
                Console.Clear(); 
                // iniciar batalha porto
            }



        } 
        public void ilhaSolitaria()
        {
            Console.Clear();
            destino = "";
            Console.WriteLine("Você esta em na Ilha Solitária");
            Console.WriteLine("Deseja voltar para Porto?");
            Console.WriteLine("[1] sim [2] não");
            destino = Console.ReadLine();
            if (destino == "1" || destino == "sim")
            {
                Porto();
            }
            else
            {
                Console.Clear();
                //inicia batalha ilha solitaria
            }
        }
     public void Deserto()
        {
            destino = "";
            Console.Clear();
            Console.WriteLine("você esta no deserto.");
            Console.ReadKey();
            Console.WriteLine("não tem nada aqui.");
            Console.Clear();
            Console.WriteLine("A Cidade Central é a sua única saida.");
            Console.WriteLine("Desaja voltar?");
            destino = Console.ReadLine();
            if (destino == "sim")
            {
                cidadeCentral();
            } else
            {
                Deserto();
            }
        }
        public void minasEsquecidas()
        {
            Console.Clear();
            Console.WriteLine("Voce esta nas Minas Esquecidas.");
        }
        public void Floresta()
        {
            Console.Clear()
                Console.WriteLine("arvores.");
        }

    }
}
