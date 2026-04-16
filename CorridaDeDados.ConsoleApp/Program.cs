namespace CorridaDeDados.ConsoleApp;

using System.Security.Cryptography;
using CorridaDeDados.ConsoleApp.Entidades;


class Program
{
    static void Main(string[] args)
    {

        while (true)
        {
            Jogador.posicao = 0;
            Computador.posicao = 0;

            while (true)
            {
                // Rodada do Jogador
                Jogador.ExecutarRodada();

                if (Jogador.JogadorVenceu())
                    break;

                // Rodada do Computador
                Computador.ExecutarRodada();

                if (Computador.ComputadorVenceu())
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
                break;
            }
        }
    }
}