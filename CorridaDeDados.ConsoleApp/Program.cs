using System.Security.Cryptography;
class Program
{
    static int RodadaDoJogador(int posicaoJogador, int bonusAvanco, int penalidade)
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

        return posicaoJogador;
    }

    static int RodadaDoComputador(int posicaoComputador, int bonusAvanco, int penalidade)
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

    static void TesteJogador(int posicaoJogador, int limite)
    {
        if (posicaoJogador >= limite)
        {
            Console.WriteLine($"Jogador venceu chegando primeiro na posicão {posicaoJogador} o jogador é o vencedor!");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Pressione Enter Para Finalizar o jogo!");
            Console.ReadLine();
        }
    }

    static void TesteComputador(int posicaoComputador, int limite)
    {

        if (posicaoComputador >= limite)
        {
            Console.WriteLine($"Computador venceu chegando primeiro na posicão {posicaoComputador} o computador é o vencedor!");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.Write("Pressione Enter Para Finalizar o jogo! ");
            Console.ReadLine();

        }
    }

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

                posicaoJogador = RodadaDoJogador(posicaoJogador, bonusAvanco, penalidade);

                TesteJogador(posicaoJogador, limite);

                if (posicaoJogador >= limite)
                    break;

                posicaoComputador = RodadaDoComputador(posicaoComputador, bonusAvanco, penalidade);

                TesteComputador(posicaoComputador, limite);
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