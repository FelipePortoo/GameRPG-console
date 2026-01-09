using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameProject
{
    public class Personagem
    {
        public string? Raca{get;set;}
        public string? Nome {get;set;}
        
        public int Vida {get;set;}

        public int Dano {get;set;}
        


    public void Atacar(Personagem alvo)
        {
            System.Console.WriteLine($"{this.Nome} atacou {alvo.Nome} causou {this.Dano} de dano!");
            alvo.Vida -= this.Dano;
        }


        public Personagem(string raca, string nome, int vida, int mana)
        {
            Nome = nome;
            Raca = raca;
            Vida = vida;
            
        }

        public Personagem()
        {
            
        }



        

        
    }
 }


  