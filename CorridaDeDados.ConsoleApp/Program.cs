namespace CorridaDeDados.ConsoleApp;

using System.Security.Cryptography;
using CorridaDeDados.ConsoleApp.Entidades;


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

                posicaoComputador = Computador.ExecutarRodada(posicaoComputador, bonusAvanco, penalidade, limite);

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