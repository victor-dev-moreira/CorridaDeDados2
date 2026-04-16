namespace CorridaDeDados.ConsoleApp;

using System.Security.Cryptography;
using CorridaDeDados.ConsoleApp.Entidades;

class Computador
{
    public static int ExecutarRodada(int posicaoComputador, int bonusAvanco, int penalidade)
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

        return posicaoComputador;
    }
    public static void TesteComputador(int posicaoComputador, int limite)
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
class Program
{
    static void Main(string[] args)
    {
        int posicaoJogador = 0;
        int posicaoComputador = 0;
        const int bonusAvanco = 3;
        const int penalidade = 2;
        const int limite = 30;
        bool jogo = true;

        while (jogo)
        {
            Console.WriteLine("Corrida De Dados");
            Console.WriteLine("----------------------");
            while (true)
            {

                posicaoJogador = Jogador.ExecutarRodada(posicaoJogador, bonusAvanco, penalidade, limite);

                if (posicaoJogador >= limite)
                    break;

                posicaoComputador = Computador.ExecutarRodada(posicaoComputador, bonusAvanco, penalidade);

                Computador.TesteComputador(posicaoComputador, limite);
                if (posicaoComputador >= limite)
                    break;

            }
            Console.Write("Deseja Continuar Jogando? (S/N)");
            string continuarJogando = Console.ReadLine().ToUpper();

            if (continuarJogando == "S")
            {
                Console.Write("Você Decidiu Continuar, Pressione enter! ");
                Console.ReadLine();
                Console.Clear();
                continue;

            }
            else
            {
                jogo = false;
            }
        }
    }
}