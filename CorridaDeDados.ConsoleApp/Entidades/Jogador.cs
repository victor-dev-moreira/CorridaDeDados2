namespace CorridaDeDados.ConsoleApp.Entidades;

using System.Security.Cryptography;


class Jogador
{
    public static int posicao = 0; // Atributo
    const int bonusAvanco = 3;
    const int penalidade = 2;
    const int limite = 30;
    public static void ExecutarRodada()
    {

        Console.WriteLine("Corrida De Dados");
        Console.WriteLine("----------------------");
        Console.WriteLine("Rodada Do Jogador!");
        Console.Write("Pressione Enter para Rolar o dado! ");
        Console.ReadLine();
        int dado = RandomNumberGenerator.GetInt32(1, 7);

        Console.WriteLine("----------------------");
        Console.WriteLine($"Jogador rolou {dado}");
        Console.WriteLine("----------------------");
        posicao = posicao + dado;
        Console.WriteLine($"Jogador posicão: {posicao}");
        Console.WriteLine("----------------------");

        if (dado == 6)
        {
            Console.WriteLine($"Como o jogador rolou {dado} no dado ganhou uma rodada Extra!");
            dado = RandomNumberGenerator.GetInt32(1, 7);
            posicao = posicao + dado;
            Console.WriteLine("----------------------");
            Console.WriteLine($"Jogador rolou {dado}");
            Console.WriteLine($"Jogador posicão: {posicao} na rodada extra!");
            Console.WriteLine("----------------------");

        }

        if (posicao == 5 || posicao == 10 || posicao == 15)
        {
            Console.WriteLine($"Jogador Caiu na posicão {posicao} e por isso ganhou mais 3 posicões!");
            posicao = posicao + bonusAvanco;
            Console.WriteLine($"Jogador Posicão {posicao}");
            Console.WriteLine("----------------------");
        }
        else if (posicao == 7 || posicao == 13 || posicao == 20)
        {
            Console.WriteLine($"Jogador Caiu na posicão {posicao} e por isso perdeu 2 posicões!");
            posicao = posicao - penalidade;
            Console.WriteLine($"Jogador Posicão {posicao}");
            Console.WriteLine("----------------------");
        }

        TesteJogador();

    }

    public static bool JogadorVenceu()
    {
        return posicao >= limite;
    }
    private static void TesteJogador()
    {
        if (posicao >= limite)
        {
            Console.WriteLine($"Jogador venceu chegando primeiro na posicão {posicao} o jogador é o vencedor!");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Pressione Enter Para Finalizar o jogo!");
            Console.ReadLine();
        }
    }
}
