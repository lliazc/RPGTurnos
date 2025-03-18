 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGturnos1
{
    public class itens
    {
      string[,] equipamento = new string[11, 6];

      public void cadastrarItem()
      {
               equipamento[0,0] = "ITEM";
               equipamento[0,1] = "TIPO";
               equipamento[0,2] = "VALOR";
               equipamento[0,3] = "DANO";
               equipamento[0,4] = "DEFESA";
               equipamento[0,5] = "SLOTS";

               equipamento[1,0] = "Adaga";
               equipamento[1,1] = "Arma";
               equipamento[1,2] = "10;";
               equipamento[1,3] = "2";
               equipamento[1,4] = "0";
               equipamento[1,5] = "1";

               listarItens();
       }

       public void listarItens()
       {
          Console.Write(equipamento);
       }
    }
}
