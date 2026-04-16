namespace CorridaDeDados.ConsoleApp.Entidades;

using System.Security.Cryptography;


class Jogador
{
    public static int ExecutarRodada(int posicaoJogador, int bonusAvanco, int penalidade, int limite)
    {
        Console.WriteLine("Rodada Do Jogador!");
        Console.Write("Pressione Enter para Rolar o dado! ");
        Console.ReadLine();
        int dado = RandomNumberGenerator.GetInt32(1, 7);

        Console.WriteLine("----------------------");
        Console.WriteLine($"Jogador rolou {dado}");
        Console.WriteLine("----------------------");
        posicaoJogador = posicaoJogador + dado;
        Console.WriteLine($"Jogador posicão: {posicaoJogador}");
        Console.WriteLine("----------------------");

        if (dado == 6)
        {
            Console.WriteLine($"Como o jogador rolou {dado} no dado ganhou uma rodada Extra!");
            dado = RandomNumberGenerator.GetInt32(1, 7);
            posicaoJogador = posicaoJogador + dado;
            Console.WriteLine("----------------------");
            Console.WriteLine($"Jogador rolou {dado}");
            Console.WriteLine($"Jogador posicão: {posicaoJogador} na rodada extra!");
            Console.WriteLine("----------------------");

        }

        if (posicaoJogador == 5 || posicaoJogador == 10 || posicaoJogador == 15)
        {
            Console.WriteLine($"Jogador Caiu na posicão {posicaoJogador} e por isso ganhou mais 3 posicões!");
            posicaoJogador = posicaoJogador + bonusAvanco;
            Console.WriteLine($"Jogador Posicão {posicaoJogador}");
            Console.WriteLine("----------------------");
        }
        else if (posicaoJogador == 7 || posicaoJogador == 13 || posicaoJogador == 20)
        {
            Console.WriteLine($"Jogador Caiu na posicão {posicaoJogador} e por isso perdeu 2 posicões!");
            posicaoJogador = posicaoJogador - penalidade;
            Console.WriteLine($"Jogador Posicão {posicaoJogador}");
            Console.WriteLine("----------------------");
        }

        TesteJogador(posicaoJogador, limite);

        return posicaoJogador;
    }

    private static void TesteJogador(int posicaoJogador, int limite)
    {
        if (posicaoJogador >= limite)
        {
            Console.WriteLine($"Jogador venceu chegando primeiro na posicão {posicaoJogador} o jogador é o vencedor!");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Pressione Enter Para Finalizar o jogo!");
            Console.ReadLine();
        }
    }
}
