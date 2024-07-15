using System; // Importa o namespace System, que contém definições básicas de tipos, como classes e métodos para manipulação de dados, entrada/saída, e outros.

namespace RockPaperScissors // Define um namespace para agrupar classes relacionadas ao jogo Rock Paper Scissors.
{
    /// <summary>
    /// A classe Player representa o jogador humano no jogo.
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Método para obter a escolha do jogador.
        /// </summary>
        /// <returns>Retorna uma escolha do jogador: Rock, Paper ou Scissors.</returns>
        public Choice GetUserChoice()
        {
            // Loop infinito para garantir que o jogador faça uma escolha válida
            while (true)
            {
                // Exibe a mensagem solicitando a escolha do jogador
                Console.WriteLine("Choose 1, 2, or 3: [1] Rock, [2] Paper, or [3] Scissors:");

                // Lê a entrada do jogador
                var selectedChoice = Console.ReadLine();

                // Verifica a entrada do jogador e retorna a escolha correspondente
                switch (selectedChoice)
                {
                    case "1":
                        return Choice.Rock; // Retorna Rock se o jogador escolher 1
                    case "2":
                        return Choice.Paper; // Retorna Paper se o jogador escolher 2
                    case "3":
                        return Choice.Scissors; // Retorna Scissors se o jogador escolher 3
                    default:
                        // Informa ao jogador que a escolha é inválida e solicita novamente
                        Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
                        break;
                }
            }
        }
    }
}
