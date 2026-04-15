using System.Security.Cryptography;
class Program
{
    static int RodadaDoJogador(int posicaoJogador)
    {
        Console.WriteLine("Rodada Do Jogador!");
        Console.Write("Pressione Enter para Rolar o dado");
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
            Console.WriteLine("----------------------");
            Console.WriteLine($"Jogador Caiu na posicão {posicaoJogador} e por isso ganhou mais 3 posicões!");
            posicaoJogador = posicaoJogador + 3;
            Console.WriteLine($"Jogador Posicão {posicaoJogador}");
            Console.WriteLine("----------------------");
        }
        else if (posicaoJogador == 7 || posicaoJogador == 13 || posicaoJogador == 20)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine($"Jogador Caiu na posicão {posicaoJogador} e por isso perdeu 2 posicões!");
            posicaoJogador = posicaoJogador - 2;
            Console.WriteLine($"Jogador Posicão {posicaoJogador}");
            Console.WriteLine("----------------------");
        }

        return posicaoJogador;
    }

    static int RodadaDoComputador(int posicaoComputador)
    {
        Console.WriteLine("Rodada Do Computador!");
        Console.WriteLine("Pressione Enter Para Rolar o Dado!");
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
            Console.WriteLine("----------------------");
            Console.WriteLine($"Maquina Caiu na posicão {posicaoComputador} e por isso ganhou mais 3 posicões!");
            posicaoComputador = posicaoComputador + 3;
            Console.WriteLine($"Maquina Posicão {posicaoComputador}");
            Console.WriteLine("----------------------");
        }
        else if (posicaoComputador == 7 || posicaoComputador == 13 || posicaoComputador == 20)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine($"Maquina Caiu na posicão {posicaoComputador} e por isso perdeu 2 posicões!");
            posicaoComputador = posicaoComputador - 2;
            Console.WriteLine($"Maquina Posicão {posicaoComputador}");
            Console.WriteLine("----------------------");
        }

        return posicaoComputador;
    }
    static void Main(string[] args)
    {

        Console.WriteLine("Corrida De Dados");
        Console.WriteLine("----------------------");
        int posicaoJogador = 0;
        int posicaoComputador = 0;
        bool jogo = true;

        while (jogo)
        {

            posicaoJogador = RodadaDoJogador(posicaoJogador);

            if (posicaoJogador >= 30)
            {
                Console.WriteLine($"Jogador venceu chegando primeiro na posicão {posicaoJogador} o jogador é o vencedor!");
                Console.WriteLine("-------------------------------------------------------------------------");
                Console.WriteLine("Pressione Enter Para Finalizar o jogo!");
                jogo = false;
                Console.ReadLine();
                break;
            }

            posicaoComputador = RodadaDoComputador(posicaoComputador);


            if (posicaoComputador >= 30)
            {
                Console.WriteLine($"Computador venceu chegando primeiro na posicão {posicaoComputador} o computador é o vencedor!");
                Console.WriteLine("-------------------------------------------------------------------------");
                Console.WriteLine("Pressione Enter Para Finalizar o jogo!");
                jogo = false;
                Console.ReadLine();
                break;
            }
        }
    }
}



