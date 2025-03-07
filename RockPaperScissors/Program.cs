﻿// Refactor chat https://chatgpt.com/share/e9217fdf-bf6e-438b-a8a5-ac29e25edef3
namespace RockPaperScissors // Define um namespace para agrupar classes relacionadas.
{
    /// <summary>
    /// A classe Program contém o ponto de entrada principal do aplicativo.
    /// </summary>
    class Program
    {
        /// <summary>
        /// O método Main é o ponto de entrada do aplicativo. 
        /// É o método que o runtime do .NET chama para iniciar o programa.
        /// </summary>
        static void Main()
        {
            // Cria uma instância da classe Game.
            // A instância é criada usando o operador new, que aloca memória para o objeto e chama seu construtor.
            var game = new Game();

            // Chama o método Start da instância Game.
            // Este método contém a lógica principal do jogo e inicia o loop do jogo.
            game.Start();
        }
    }
}
