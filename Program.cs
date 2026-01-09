using System;

namespace GameProject;

class Program
{
    static void Main(string[] args)
    {
        bool estaRodando = true;

        
        Heroi NovoHeroi = new Heroi();



       System.Console.WriteLine("---------- RPG HEROES ----------");
       System.Console.Write("Olá Jogador, deseja começar sua jornada? (S/N)?:");
       string resposta  = Console.ReadLine()!.ToLower();

       if (resposta  == "n" || resposta == "não" || resposta == "nao" )
       {
            return;
       }

       else if (resposta == "sim" || resposta == "s" )
       {
        System.Console.WriteLine("Carregando....");
        System.Console.WriteLine("Inciando Tela de Criação de Personagem..");

        System.Console.Write("Digite seu Nome:");
        NovoHeroi.Nome = Console.ReadLine()!;
        System.Console.WriteLine("Carregando....");
       }
       

       while (estaRodando)
       {
        Console.Clear(); //** LIMPA A TELA PARA NAO POLUIR O CONSOLE
        System.Console.WriteLine($"Nome:{NovoHeroi.Nome}");
        System.Console.WriteLine("Escolha Sua Classe:");
        System.Console.WriteLine("1 - Guerreiro\n2 - Mago \n3 - Arqueiro\n4 - Sair"); //** FORMA MELHORADA DE ESCREVER NO CONSOLE SEM PRECISAR USAR VARIAS LINHAS

        string opcao = Console.ReadLine()!;
        string classeEscolhida = "";


        switch (opcao) // ** FORMA REDUZIDA E SIMPLIFICADA PARA USAR O SWITCH , deixando o codigo mais compacto.
        {
            case "1": classeEscolhida = "Guerreiro";
            break;
            case "2": classeEscolhida = "Mago";
            break;
            case "3": classeEscolhida = "Arqueiro";
            break;
            case "4": return;
            default: continue;
         }

         Console.Write($"Vocẽ escolheu {classeEscolhida}. Confirmar? (S/N)?:");
         resposta = Console.ReadLine()!.ToLower();
        
        if (resposta == "s" || resposta == "sim" )
        {
            NovoHeroi.Classe = classeEscolhida;
            System.Console.WriteLine($"\nPersonagem {NovoHeroi.Nome} o {NovoHeroi.Classe} criado com sucesso!");

            estaRodando = false; //** sai do loop
        }
  
        }
        
        //*** EXPLORAÇÃO //
        estaRodando = true; // Ativa o LOOP NOVAMNTE 

        
        
        while (estaRodando)
        {
        Console.Clear();
        System.Console.WriteLine($"Sua Jornada {NovoHeroi.Nome}, Começa Agora..");
        System.Console.WriteLine($"-----CABANA FLORESTA ------");
        System.Console.WriteLine("1 - Sair da Cabana\n2 - Vasculhar\n3 -Dormir");
        
        string opcaoCabana = Console.ReadLine()!;
        
            switch (opcaoCabana)
            {
                
                case "1":
                System.Console.WriteLine("Saindo da Cabana.."); 
                estaRodando = false;
                break;
                case "2":
                System.Console.WriteLine("Vasculhando a cabana...."); break;
                case "3":
                System.Console.WriteLine("você está dormindo...zzzzz"); break;

             }   
            
            
        }

       }
        }

    

