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
        int inimigo;
        Random ataque = new Random(); 

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
                Console.ReadKey();
            }


        }

        public void Porto()
        {
            inimigo = ataque.Next(1,3);
       
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
                if (inimigo == 1)
                {
                    Console.WriteLine("tomou enquadro, atividade cria");
                }
                else
                {
                    Console.WriteLine("suave");
                    Console.ReadKey();

                }
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
                inimigo = ataque.Next(1,3);
                if (inimigo == 1)
                {
                    Console.WriteLine("Você foi atacado pelo bixo marinho do tíbia.");
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("ta safe.");
                    Console.ReadKey();

                }
            }
        }
     public void Deserto()
        {
            destino = "";
            Console.Clear();
            Console.WriteLine("você esta no deserto.");
            Console.ReadKey();
            Console.WriteLine("você pode voltar para a cidade central..");
            Console.WriteLine("Desaja voltar? (sim ou não)");
            destino = Console.ReadLine();
            if (destino == "sim")
            {
                cidadeCentral();
            } else
            {
                inimigo = ataque.Next(1,5);
                if (inimigo == 3)
                {
                    Console.WriteLine("tem um escorpião no seu sapato.");
                    Console.ReadKey();

                }
            }
        }
        public void minasEsquecidas()
        {
            destino = "";
            Console.Clear();
            Console.WriteLine("Voce esta nas Minas Esquecidas.");
            Console.WriteLine("Deseja voltar para a cidade central?");
            Console.WriteLine("[1] sim [2] não");
            destino = Console.ReadLine();
            if (destino == "sim" || destino == "1")
            {
                Console.Clear();
                cidadeCentral();
            }
            else
            {
                Console.Clear();
                inimigo = ataque.Next(1, 5);
                if (inimigo == 4)
                {
                    Console.WriteLine("se safou.");
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("uma aranha gigante.");
                    Console.ReadKey();


                }
            }

        }
        public void Floresta()
        {
            destino = "";
            Console.Clear();
                Console.WriteLine("arvores.");
            Console.WriteLine("Voce pode voltar para as Minas ou ir para a Cidade central");
            Console.WriteLine("[1] Minas Esquecidas [2] Cidade Central  [3] ficar aqui");
            destino = Console.ReadLine();
            if (destino == "1")
            {
                minasEsquecidas();
            }
            else if (destino == "2")
            {
                cidadeCentral();
            } else if (destino == "3")
            {
                Console.WriteLine("legal");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("oloco");
                Console.ReadKey();
            }
        }

    }
}
