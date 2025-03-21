 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGturnos1
{
    public class itens
    {
        string[,] equipamento = new string[21, 6];  

        public void cadastrarItem()
        {
            equipamento[0, 0] = "ITEM";
            equipamento[0, 1] = "TIPO";
            equipamento[0, 2] = "VALOR";
            equipamento[0, 3] = "DANO";
            equipamento[0, 4] = "DEFESA";
            equipamento[0, 5] = "SLOTS";

            
            equipamento[1, 0] = "Adaga";
            equipamento[1, 1] = "Arma";
            equipamento[1, 2] = "10";
            equipamento[1, 3] = "2";
            equipamento[1, 4] = "0";
            equipamento[1, 5] = "1";

            equipamento[2, 0] = "Espada Curta";
            equipamento[2, 1] = "Arma";
            equipamento[2, 2] = "20";
            equipamento[2, 3] = "5";
            equipamento[2, 4] = "0";
            equipamento[2, 5] = "2";

            equipamento[3, 0] = "Espada Longa";
            equipamento[3, 1] = "Arma";
            equipamento[3, 2] = "50";
            equipamento[3, 3] = "10";
            equipamento[3, 4] = "0";
            equipamento[3, 5] = "3";

            equipamento[4, 0] = "Martelo";
            equipamento[4, 1] = "Arma";
            equipamento[4, 2] = "80";
            equipamento[4, 3] = "15";
            equipamento[4, 4] = "0";
            equipamento[4, 5] = "4";

            equipamento[5, 0] = "Arco";
            equipamento[5, 1] = "Arma";
            equipamento[5, 2] = "60";
            equipamento[5, 3] = "8";
            equipamento[5, 4] = "0";
            equipamento[5, 5] = "2";

            equipamento[6, 0] = "Lança";
            equipamento[6, 1] = "Arma";
            equipamento[6, 2] = "70";
            equipamento[6, 3] = "12";
            equipamento[6, 4] = "0";
            equipamento[6, 5] = "3";

            equipamento[7, 0] = "Escudo de Ferro";
            equipamento[7, 1] = "Defesa";
            equipamento[7, 2] = "40";
            equipamento[7, 3] = "0";
            equipamento[7, 4] = "20";
            equipamento[7, 5] = "1";

            equipamento[8, 0] = "Escudo de Bronze";
            equipamento[8, 1] = "Defesa";
            equipamento[8, 2] = "30";
            equipamento[8, 3] = "0";
            equipamento[8, 4] = "15";
            equipamento[8, 5] = "1";

            equipamento[9, 0] = "Capacete de Ferro";
            equipamento[9, 1] = "Defesa";
            equipamento[9, 2] = "25";
            equipamento[9, 3] = "0";
            equipamento[9, 4] = "10";
            equipamento[9, 5] = "1";

            equipamento[10, 0] = "Armadura de Couro";
            equipamento[10, 1] = "Defesa";
            equipamento[10, 2] = "50";
            equipamento[10, 3] = "0";
            equipamento[10, 4] = "25";
            equipamento[10, 5] = "2";

            equipamento[11, 0] = "Armadura de Ferro";
            equipamento[11, 1] = "Defesa";
            equipamento[11, 2] = "100";
            equipamento[11, 3] = "0";
            equipamento[11, 4] = "50";
            equipamento[11, 5] = "3";

            equipamento[12, 0] = "Botas Rápidas";
            equipamento[12, 1] = "Acessório";
            equipamento[12, 2] = "15";
            equipamento[12, 3] = "0";
            equipamento[12, 4] = "5";
            equipamento[12, 5] = "1";

            equipamento[13, 0] = "Anel Mágico";
            equipamento[13, 1] = "Acessório";
            equipamento[13, 2] = "20";
            equipamento[13, 3] = "0";
            equipamento[13, 4] = "3";
            equipamento[13, 5] = "1";

            equipamento[14, 0] = "Capa de Invisibilidade";
            equipamento[14, 1] = "Acessório";
            equipamento[14, 2] = "50";
            equipamento[14, 3] = "0";
            equipamento[14, 4] = "10";
            equipamento[14, 5] = "2";

            equipamento[15, 0] = "Cinto de Força";
            equipamento[15, 1] = "Acessório";
            equipamento[15, 2] = "35";
            equipamento[15, 3] = "0";
            equipamento[15, 4] = "7";
            equipamento[15, 5] = "1";

            equipamento[16, 0] = "Poção de Vida";
            equipamento[16, 1] = "Item";
            equipamento[16, 2] = "10";
            equipamento[16, 3] = "0";
            equipamento[16, 4] = "0";
            equipamento[16, 5] = "1";

            equipamento[17, 0] = "Poção de Mana";
            equipamento[17, 1] = "Item";
            equipamento[17, 2] = "15";
            equipamento[17, 3] = "0";
            equipamento[17, 4] = "0";
            equipamento[17, 5] = "1";

            equipamento[18, 0] = "Poção de Regeneração";
            equipamento[18, 1] = "Item";
            equipamento[18, 2] = "20";
            equipamento[18, 3] = "0";
            equipamento[18, 4] = "0";
            equipamento[18, 5] = "1";

            equipamento[19, 0] = "Poeira Mágica";
            equipamento[19, 1] = "Item";
            equipamento[19, 2] = "30";
            equipamento[19, 3] = "0";
            equipamento[19, 4] = "0";
            equipamento[19, 5] = "1";

            equipamento[20, 0] = "Bola de Fogo";
            equipamento[20, 1] = "Item";
            equipamento[20, 2] = "50";
            equipamento[20, 3] = "20";
            equipamento[20, 4] = "0";
            equipamento[20, 5] = "1";

            listarItens();
        }


        public void listarItens()
       {
          Console.Write(equipamento);
       }
    }
}
