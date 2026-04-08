Console.WriteLine("Corrida De Dados");
Console.WriteLine("----------------------");

Random random = new Random();
int pJ = 0;
int pM = 0;
bool jogo = true;

while (jogo)
{

    Console.WriteLine("Pressione Enter para comecar o jogo");
    Console.ReadLine();

    int dado = +random.Next(1, 7);
    //int dado2 = +random.Next(1, 7);

    Console.WriteLine("----------------------");
    Console.WriteLine($"Jogador rolou {dado}");
    Console.WriteLine("----------------------");
    pJ = pJ + dado;
    Console.WriteLine($"Jogador p: {pJ}");

    if (dado == 6)
    {
        Console.WriteLine($"Como o jogador rolou {dado} no dado ganhou uma rodada Extra!");
        dado = +random.Next(1, 7);
        pJ = pJ + dado;
        Console.WriteLine("----------------------");
        Console.WriteLine($"Jogador rolou {dado}");
        Console.WriteLine($"Jogador posicão: {pJ} na rodada extra!");
        Console.WriteLine("----------------------");

    }

    if (pJ == 5 || pJ == 10 || pJ == 15)
    {
        Console.WriteLine("----------------------");
        Console.WriteLine($"Jogador Caiu na posicão {pJ} e por isso ganhou mais 3 posicões!");
        pJ = pJ + 3;
        Console.WriteLine($"Jogador Posicão {pJ}");
        Console.WriteLine("----------------------");
    }
    else if (pJ == 7 || pJ == 13 || pJ == 20)
    {
        Console.WriteLine("----------------------");
        Console.WriteLine($"Jogador Caiu na posicão {pJ} e por isso perdeu 2 posicões!");
        pJ = pJ - 2;
        Console.WriteLine($"Jogador Posicão {pJ}");
        Console.WriteLine("----------------------");
    }

    dado = +random.Next(1, 7);
    pM = pM + dado;
    Console.WriteLine("----------------------");
    Console.WriteLine($"Maquina rolou {dado}");
    Console.WriteLine("----------------------");
    Console.WriteLine($"Maquina p: {pM}");
    Console.WriteLine("----------------------");

    if (dado == 6)
    {
        Console.WriteLine($"Como a maquina rolou {dado} no dado ganhou uma rodada Extra!");
        dado = +random.Next(1, 7);
        pM = pM + dado;
        Console.WriteLine("----------------------");
        Console.WriteLine($"Maquina rolou {dado}");
        Console.WriteLine($"Maquina p: {pM} na rodada extra!");
        Console.WriteLine("----------------------");

    }

    if (pM == 5 || pM == 10 || pM == 15)
    {
        Console.WriteLine("----------------------");
        Console.WriteLine($"Maquina Caiu na posicão {pM} e por isso ganhou mais 3 posicões!");
        pM = pM + 3;
        Console.WriteLine($"Maquina Posicão {pM}");
        Console.WriteLine("----------------------");
    }
    else if (pM == 7 || pM == 13 || pM == 20)
    {
        Console.WriteLine("----------------------");
        Console.WriteLine($"Maquina Caiu na posicão {pM} e por isso perdeu 2 posicões!");
        pM = pM - 2;
        Console.WriteLine($"Maquina Posicão {pM}");
        Console.WriteLine("----------------------");
    }

    if (pJ >= 30)
    {
        Console.WriteLine($"Jogador venceu chegando primeiro na posicão {pJ} o jogador é o vencedor!");
        Console.WriteLine("-------------------------------------------------------------------------");
        Console.WriteLine("Pressione Enter Para Finalizar o jogo!");
        jogo = false;
        Console.ReadLine();
    }
    else if (pM >= 30)
    {
        Console.WriteLine($"Maquina venceu chegando primeiro na posicão {pM} o jogador é o vencedor!");
        Console.WriteLine("-------------------------------------------------------------------------");
        Console.WriteLine("Pressione Enter Para Finalizar o jogo!");
        jogo = false;
        Console.ReadLine();
    }


}