using System.Security.Cryptography;
namespace CorridaDeDados.ConsoleApp.Entidades;

public class Computador
{
    public static int ExecutarRodada(int posicaoComputador, int bonusAvanco, int penalidade, int limite)
    {
        Console.WriteLine("Rodada Do Computador!");
        Console.Write("Pressione Enter Para Rolar o Dado!");
        int dado = RandomNumberGenerator.GetInt32(1, 7);
        Console.ReadLine();

        posicaoComputador = posicaoComputador + dado;
        Console.WriteLine("----------------------");
        Console.WriteLine($"Maquina rolou {dado}");
        Console.WriteLine("----------------------");
        Console.WriteLine($"Maquina posicao: {posicaoComputador}");
        Console.WriteLine("----------------------");

        if (dado == 6)
        {
            Console.WriteLine($"Como a maquina rolou {dado} no dado ganhou uma rodada Extra!");
            dado = RandomNumberGenerator.GetInt32(1, 7);
            posicaoComputador = posicaoComputador + dado;
            Console.WriteLine("----------------------");
            Console.WriteLine($"Maquina rolou {dado}");
            Console.WriteLine($"Maquina p: {posicaoComputador} na rodada extra!");
            Console.WriteLine("----------------------");

        }

        if (posicaoComputador == 5 || posicaoComputador == 10 || posicaoComputador == 15)
        {
            Console.WriteLine($"Maquina Caiu na posicão {posicaoComputador} e por isso ganhou mais 3 posicões!");
            posicaoComputador = posicaoComputador + bonusAvanco;

            Console.WriteLine($"Maquina Posicão {posicaoComputador}");
            Console.WriteLine("----------------------");
        }
        else if (posicaoComputador == 7 || posicaoComputador == 13 || posicaoComputador == 20)
        {
            Console.WriteLine($"Maquina Caiu na posicão {posicaoComputador} e por isso perdeu 2 posicões!");
            posicaoComputador = posicaoComputador - penalidade;
            Console.WriteLine($"Maquina Posicão {posicaoComputador}");
            Console.WriteLine("----------------------");
        }

        TesteComputador(posicaoComputador, limite);
        return posicaoComputador;
    }
    private static void TesteComputador(int posicaoComputador, int limite)
    {

        if (posicaoComputador >= limite)
        {
            Console.WriteLine($"Computador venceu chegando primeiro na posicão {posicaoComputador} o computador é o vencedor!");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.Write("Pressione Enter Para Finalizar o jogo! ");
            Console.ReadLine();

        }
    }
}
