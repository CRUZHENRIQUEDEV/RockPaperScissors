using System;

namespace RockPaperScissors // Define um namespace para agrupar classes relacionadas ao jogo Rock Paper Scissors.
{
    /// <summary>
    /// A classe Game controla a lógica principal do jogo Rock Paper Scissors.
    /// </summary>
    public class Game
    {
        // Campos privados somente leitura para as instâncias do jogador e do oponente.
        private readonly Player _player;
        private readonly Opponent _opponent;

        /// <summary>
        /// Construtor da classe Game que inicializa os objetos Player e Opponent.
        /// </summary>
        public Game()
        {
            // Inicializa a instância do jogador.
            _player = new Player();
            // Inicializa a instância do oponente.
            _opponent = new Opponent();
        }

        /// <summary>
        /// Método que inicia o jogo e controla o loop principal do jogo.
        /// </summary>
        public void Start()
        {
            Console.WriteLine("Rock Paper Scissors"); // Exibe o título do jogo.

            // Loop principal do jogo que continua até o jogador escolher sair.
            while (true)
            {
                Console.WriteLine("Are you ready?");
                Console.WriteLine("Let's begin!");

                // Obtém a escolha do jogador.
                var yourChoice = _player.GetUserChoice();
                Console.WriteLine($"Your choice is: {yourChoice}");

                // Obtém a escolha do oponente (computador).
                var opponentChoice = _opponent.GetOpponentChoice();
                Console.WriteLine($"The opponent choice is: {opponentChoice}");

                // Decide o vencedor com base nas escolhas.
                DecideWinner(opponentChoice, yourChoice);

                // Pergunta ao jogador se deseja jogar novamente.
                if (!AskToPlayAgain())
                {
                    break; // Sai do loop se a resposta for "não".
                }
            }
        }

        /// <summary>
        /// Método para decidir o vencedor com base nas escolhas do jogador e do oponente.
        /// </summary>
        /// <param name="opponentChoice">A escolha do oponente.</param>
        /// <param name="yourChoice">A escolha do jogador.</param>
        internal void DecideWinner(Choice opponentChoice, Choice yourChoice)
        {
            // Se as escolhas forem iguais, é um empate.
            if (opponentChoice == yourChoice)
            {
                Console.WriteLine("Draw");
            }
            // Verifica as combinações em que o jogador vence.
            else if ((yourChoice == Choice.Rock && opponentChoice == Choice.Scissors) ||
                     (yourChoice == Choice.Paper && opponentChoice == Choice.Rock) ||
                     (yourChoice == Choice.Scissors && opponentChoice == Choice.Paper))
            {
                Console.WriteLine("You win");
            }
            // Se não for empate e o jogador não vencer, o jogador perde.
            else
            {
                Console.WriteLine("You lose");
            }
        }

        /// <summary>
        /// Método para perguntar ao jogador se deseja jogar novamente.
        /// </summary>
        /// <returns>Retorna true se o jogador quiser jogar novamente, caso contrário, retorna false.</returns>
        internal bool AskToPlayAgain()
        {
            // Loop para garantir que o jogador forneça uma resposta válida.
            while (true)
            {
                Console.WriteLine("Do you want to play again? (1 = Yes, 2 = No)");
                var response = Console.ReadLine();

                // Verifica se a resposta é "1" (sim).
                if (response == "1")
                {
                    return true;
                }
                // Verifica se a resposta é "2" (não).
                else if (response == "2")
                {
                    return false;
                }
                // Informa ao jogador que a entrada é inválida.
                else
                {
                    Console.WriteLine("Invalid input. Please enter 1 for Yes or 2 for No.");
                }
            }
        }
    }
}
