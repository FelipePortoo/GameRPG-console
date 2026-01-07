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
       string resposta  = Console.ReadLine()!;

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
        Console.Clear();
        System.Console.WriteLine("Escolha Sua Raça:");
        System.Console.WriteLine("1- Guerreiro");
        System.Console.WriteLine("2- Mago");
        System.Console.WriteLine("3 - Arqueiro");
        System.Console.WriteLine("4- Salvar");


        string opcao = Console.ReadLine()!;


        switch (opcao)
        {
            case "1":
            System.Console.Write("deseja continuar? não será possivel alterar após a confirmação:(S/N)?");
            resposta = Console.ReadLine()!;
            if (resposta == "S" || resposta == "sim")
            {
                System.Console.WriteLine("Personagem Criado!!");
            }

            else if (resposta == "nao" || resposta == "n")
            {
                return;
            }

            break;

            case "2":
            System.Console.Write("deseja continuar? não será possivel alterar após a confirmação:(S/N)?");
            resposta = Console.ReadLine()!;
            if (resposta == "S" || resposta == "sim")
            {
                System.Console.WriteLine("Personagem Criado!!");
            }

            else if (resposta == "nao" || resposta == "n")
            {
                return;
            }
            break;

             case "3":
            System.Console.Write("deseja continuar? não será possivel alterar após a confirmação:(S/N)?");
            resposta = Console.ReadLine()!;
            if (resposta == "S" || resposta == "sim")
            {
                System.Console.WriteLine("Personagem Criado!!");
            }

            else if (resposta == "nao" || resposta == "n")
            {
                return;
            }

            break;

            case "4":


        }



       }
       
        
       
    }
}
