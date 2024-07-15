using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Rock Paper Scissors");

        // Loop principal do jogo
        while (true)
        {
            Console.WriteLine("Are you ready?");
            Console.WriteLine("Let's begin!");

            // Obtém a escolha do usuário
            var yourChoice = GetUserChoice();
            Console.WriteLine($"Your choice is: {yourChoice}");

            // Obtém a escolha do oponente (computador)
            var opponentChoice = GetOpponentChoice();
            Console.WriteLine($"The opponent choice is: {opponentChoice}");

            // Decide o vencedor com base nas escolhas
            DecideWinner(opponentChoice, yourChoice);

            // Pergunta ao usuário se deseja jogar novamente
            Console.WriteLine("Do you want to play again? (y/n)");
            if (Console.ReadLine()?.ToLower() != "y")
            {
                break; // Sai do loop se a resposta for diferente de "y"
            }
        }
    }

    // Função para obter a escolha do usuário
    static char GetUserChoice()
    {
        while (true)
        {
            Console.WriteLine("Choose R, P or S: [R]ock, [P]aper, or [S]cissors:");
            var selectedChoice = Console.ReadLine();

            // Verifica se a escolha é válida
            if (selectedChoice?.ToLower() == "r" || selectedChoice?.ToLower() == "p" || selectedChoice?.ToLower() == "s")
            {
                return char.ToUpper(selectedChoice[0]); // Retorna a escolha como caractere maiúsculo
            }
            Console.WriteLine("Invalid choice. Please select only one letter: R, P or S.");
        }
    }

    // Função para obter a escolha do oponente (computador)
    static char GetOpponentChoice()
    {
        char[] options = new char[] { 'R', 'P', 'S' };
        Random random = new Random();
        int randomIndex = random.Next(options.Length);
        return options[randomIndex];
    }

    // Função para decidir o vencedor com base nas escolhas
    static void DecideWinner(char opponentChoice, char yourChoice)
    {
        if (opponentChoice == yourChoice)
        {
            Console.WriteLine("Draw");
        }
        else if ((yourChoice == 'R' && opponentChoice == 'S') ||
                 (yourChoice == 'P' && opponentChoice == 'R') ||
                 (yourChoice == 'S' && opponentChoice == 'P'))
        {
            Console.WriteLine("You win");
        }
        else
        {
            Console.WriteLine("You lose");
        }
    }
}
