using System.Diagnostics.Contracts;

namespace GameProject;

class Program
{
    static void Main(string[] args)
    {
        bool estaRodando = true;

        Personagem NovoPersonagem = new Personagem();



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
        NovoPersonagem.Nome = Console.ReadLine();
        System.Console.WriteLine("Carregando....");
       }
       

       while (estaRodando)
       {
        Console.Clear(); //** LIMPA A TELA PARA NAO POLUIR O CONSOLE
        System.Console.WriteLine($"Nome:{NovoPersonagem.Nome}");
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
            case "4":
            return;
            default: continue;
            
                
         }

         System.Console.WriteLine($"Vocẽ escolheu {classeEscolhida}. Confirmar? (S/N)?:");
         resposta = Console.ReadLine()!.ToLower();
        
        if (resposta == "s" || resposta == "sim" )
        {
            NovoPersonagem.Raca = classeEscolhida;
            System.Console.WriteLine($"\nPersonagem {NovoPersonagem.Nome} o {NovoPersonagem.Raca} criado com sucesso!");

            estaRodando = false; //** sai do loop
        }

           

        }



       }
       
        
       
    }

