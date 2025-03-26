using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGturnos1
{
    public class personagem
    {
        string nome;
        string classe;
        int pontosdevida;
        int pontosdeenergia;
        int ataque;
        int resistencia;
        int nivel;
        int experiencia;
        int vidapornivel;
        int energiapornivel;
        string batalha;


        public void criarPersonagem()
        {

            Console.WriteLine("Insira o nome do personagem:");
            nome = Console.ReadLine();
            do
            {
                Console.Clear();
                Console.WriteLine("classes disponiveis");
                Console.WriteLine("");
                Console.WriteLine("1- Guerreiro");
                Console.WriteLine("2- Arqueiro");
                Console.WriteLine("3- Mago");
                Console.WriteLine("4- Monge");

                Console.WriteLine("Escreva a classe do seu personagem");
                classe = Console.ReadLine().ToUpper();

            } while (classe != "GUERREIRO" && classe != "ARQUEIRO" && classe != "MAGO" && classe != "MONGE" && classe != "1" && classe != "2"
            && classe != "3" && classe != "4");

            Console.Clear();
            Console.WriteLine("Bem-vindo " + nome + "Você pertence a classe " + classe + " Seus atributos são: ");
            if (classe == "GUERREIRO" || classe == "1")
            {
                construirGuerreiro();
                Console.ReadKey();
            }
            else if (classe == "ARQUEIRO" || classe == "2")
            {
                construirArqueiro();
                Console.ReadKey();
            }
            else if (classe == "MAGO" || classe == "3")
            {
                construirMago();
                Console.ReadKey();
            }
            else if (classe == "MONGE" || classe == "4")
            {
                construirMonge();
                Console.ReadKey();
            }
            Console.Clear();
            mapa Map = new mapa();
            Map.cidadeCentral();

            /*Console.Clear();
            Console.WriteLine("deseja começar uma batalha?");
            Console.WriteLine(" (1) sim (2) não");
            batalha = Console.ReadLine();
            if (batalha == "1")
            {
                monstro Mob = new monstro();
                Mob.criarMonstro();
                //Chamando Monstro (passar para o mapa.)
            }
            else
            {
                Console.WriteLine("burro");
            }*/
        }


        public void construirGuerreiro()
        {
            experiencia = 0;
            nivel = 1;
            pontosdevida = 200;
            pontosdeenergia = 50;
            ataque = 10;
            resistencia = 10;
            vidapornivel = 25;
            energiapornivel = 5;
            Console.WriteLine("Nivel: " + nivel);
            Console.WriteLine("Exp: " + experiencia);
            Console.WriteLine("Pontos de Vida: " + pontosdevida);
            Console.WriteLine("Pontos de Energia: " + pontosdeenergia);
            Console.WriteLine("Ataque: " + ataque);
            Console.WriteLine("Resistência: " + resistencia);
            Console.WriteLine("Vida Recebida Por Nivel: " + vidapornivel);
            Console.WriteLine("Energia Recebida Por Nível: " + energiapornivel);

        }

        public void construirArqueiro()
        {
            experiencia = 0;
            nivel = 1;
            pontosdevida = 125;
            pontosdeenergia = 125;
            ataque = 14;
            resistencia = 6;
            vidapornivel = 15;
            energiapornivel = 15;
            Console.WriteLine("Nivel: " + nivel);
            Console.WriteLine("Exp: " + experiencia);
            Console.WriteLine("Pontos de Vida: " + pontosdevida);
            Console.WriteLine("Pontos de Energia: " + pontosdeenergia);
            Console.WriteLine("Ataque: " + ataque);
            Console.WriteLine("Resistência: " + resistencia);
            Console.WriteLine("Vida Recebida Por Nivel: " + vidapornivel);
            Console.WriteLine("Energia Recebida Por Nível: " + energiapornivel);
        }
        public void construirMago()
        {
            experiencia = 0;
            nivel = 1;
            pontosdevida = 75;
            pontosdeenergia = 175;
            ataque = 16;
            resistencia = 4;
            vidapornivel = 5;
            energiapornivel = 25;
            Console.WriteLine("Nivel: " + nivel);
            Console.WriteLine("Exp: " + experiencia);
            Console.WriteLine("Pontos de Vida: " + pontosdevida);
            Console.WriteLine("Pontos de Energia: " + pontosdeenergia);
            Console.WriteLine("Ataque: " + ataque);
            Console.WriteLine("Resistência: " + resistencia);
            Console.WriteLine("Vida Recebida Por Nivel: " + vidapornivel);
            Console.WriteLine("Energia Recebida Por Nível: " + energiapornivel);
        }

        public void construirMonge()
        {
            experiencia = 0;
            nivel = 150;
            pontosdevida = 150;
            pontosdeenergia = 100;
            ataque = 8;
            resistencia = 12;
            vidapornivel = 20;
            energiapornivel = 10;
            Console.WriteLine("Nivel: " + nivel);
            Console.WriteLine("Exp: " + experiencia);
            Console.WriteLine("Pontos de Vida: " + pontosdevida);
            Console.WriteLine("Pontos de Energia: " + pontosdeenergia);
            Console.WriteLine("Ataque: " + ataque);
            Console.WriteLine("Resistência: " + resistencia);
            Console.WriteLine("Vida Recebida Por Nivel: " + vidapornivel);
            Console.WriteLine("Energia Recebida Por Nível: " + energiapornivel);
        }
    }

}
