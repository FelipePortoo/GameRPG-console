using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameProject
{
    public class Personagem
    {
        public string? Raca{get;set;}
        public string? Nome{get;set;}
        public int Vida {get;set;}
        public int Mana {get;set;}



        public Personagem(string raca, string nome, int vida, int mana)
        {
            Raca = raca;
            Nome = nome;
            Vida = vida;
            Mana = mana;
        }

        public Personagem()
        {
            
        }



        

        
    }
 }


  