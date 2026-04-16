using System.Security.Cryptography;
namespace CorridaDeDados.ConsoleApp.Entidades;

public class Computador
{
    public static int posicao = 0; // Atributo
    const int bonusAvanco = 3;
    const int penalidade = 2;
    const int limite = 30;

    public static void ExecutarRodada()
    {
        Console.WriteLine("Corrida De Dados");
        Console.WriteLine("----------------------");
        Console.WriteLine("Rodada Do Computador!");
        Console.Write("Pressione Enter Para Rolar o Dado!");
        int dado = RandomNumberGenerator.GetInt32(1, 7);
        Console.ReadLine();

        posicao = posicao + dado;
        Console.WriteLine("----------------------");
        Console.WriteLine($"Maquina rolou {dado}");
        Console.WriteLine("----------------------");
        Console.WriteLine($"Maquina posicao: {posicao}");
        Console.WriteLine("----------------------");

        if (dado == 6)
        {
            Console.WriteLine($"Como a maquina rolou {dado} no dado ganhou uma rodada Extra!");
            dado = RandomNumberGenerator.GetInt32(1, 7);
            posicao = posicao + dado;
            Console.WriteLine("----------------------");
            Console.WriteLine($"Maquina rolou {dado}");
            Console.WriteLine($"Maquina p: {posicao} na rodada extra!");
            Console.WriteLine("----------------------");

        }

        if (posicao == 5 || posicao == 10 || posicao == 15)
        {
            Console.WriteLine($"Maquina Caiu na posicão {posicao} e por isso ganhou mais 3 posicões!");
            posicao = posicao + bonusAvanco;

            Console.WriteLine($"Maquina Posicão {posicao}");
            Console.WriteLine("----------------------");
        }
        else if (posicao == 7 || posicao == 13 || posicao == 20)
        {
            Console.WriteLine($"Maquina Caiu na posicão {posicao} e por isso perdeu 2 posicões!");
            posicao = posicao - penalidade;
            Console.WriteLine($"Maquina Posicão {posicao}");
            Console.WriteLine("----------------------");
        }

        TesteComputador();

    }

    public static bool ComputadorVenceu()
    {
        return posicao >= limite;
    }
    private static void TesteComputador()
    {

        if (posicao >= limite)
        {
            Console.WriteLine($"Computador venceu chegando primeiro na posicão {posicao} o computador é o vencedor!");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.Write("Pressione Enter Para Finalizar o jogo! ");
            Console.ReadLine();

        }
    }
}
