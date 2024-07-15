using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors;
using System;
using System.IO;

namespace RockPaperScissorsTests
{
    [TestClass]
    public class GameTests
    {
        /// <summary>
        /// Teste para verificar se o resultado é um empate quando ambas as escolhas são iguais.
        /// </summary>
        [TestMethod]
        [Description("Verifica se o jogo resulta em um empate quando ambas as escolhas são Rock.")]
        [Owner("SilvaHenrique")]
        [Priority(1)]
        [TestCategory("GameTests")]
        public void DecideWinner_DrawScenario()
        {
            // Arrange
            // Cria uma instância do jogo.
            var game = new Game();

            // Redireciona a saída do console para um StringWriter para capturar a saída.
            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            // Chama o método DecideWinner com ambas as escolhas sendo Rock.
            game.DecideWinner(Choice.Rock, Choice.Rock);

            // Assert
            // Verifica se a saída contém a palavra "Draw".
            Assert.IsTrue(output.ToString().Contains("Draw"));
        }

        /// <summary>
        /// Teste para verificar se o jogador ganha quando escolhe Paper e o oponente escolhe Rock.
        /// </summary>
        [TestMethod]
        [Description("Verifica se o jogador ganha quando escolhe Paper e o oponente escolhe Rock.")]
        [Owner("SilvaHenrique")]
        [Priority(1)]
        [TestCategory("GameTests")]
        public void DecideWinner_PlayerWinsScenario()
        {
            // Arrange
            // Cria uma instância do jogo.
            var game = new Game();

            // Redireciona a saída do console para um StringWriter para capturar a saída.
            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            // Chama o método DecideWinner com a escolha do jogador sendo Paper e a do oponente sendo Rock.
            game.DecideWinner(Choice.Rock, Choice.Paper);

            // Assert
            // Verifica se a saída contém a frase "You win".
            Assert.IsTrue(output.ToString().Contains("You win"));
        }

        /// <summary>
        /// Teste para verificar se o jogador perde quando escolhe Rock e o oponente escolhe Scissors.
        /// </summary>
        [TestMethod]
        [Description("Verifica se o jogador perde quando escolhe Rock e o oponente escolhe Scissors.")]
        [Owner("SilvaHenrique")]
        [Priority(1)]
        [TestCategory("GameTests")]
        public void DecideWinner_PlayerLosesScenario()
        {
            // Arrange
            // Cria uma instância do jogo.
            var game = new Game();

            // Redireciona a saída do console para um StringWriter para capturar a saída.
            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            // Chama o método DecideWinner com a escolha do jogador sendo Rock e a do oponente sendo Scissors.
            game.DecideWinner(Choice.Rock, Choice.Scissors);

            // Assert
            // Verifica se a saída contém a frase "You lose".
            Assert.IsTrue(output.ToString().Contains("You lose"));
        }

        /// <summary>
        /// Teste para verificar se o método AskToPlayAgain retorna true quando a entrada é 1.
        /// </summary>
        [TestMethod]
        [Description("Verifica se o método AskToPlayAgain retorna true quando a entrada é 1.")]
        [Owner("SilvaHenrique")]
        [Priority(2)]
        [TestCategory("GameTests")]
        public void AskToPlayAgain_YesInput_ReturnsTrue()
        {
            // Arrange
            // Cria uma instância do jogo.
            var game = new Game();

            // Redireciona a entrada do console para um StringReader com a entrada "1".
            var input = "1";
            Console.SetIn(new StringReader(input));

            // Act
            // Chama o método AskToPlayAgain.
            var result = game.AskToPlayAgain();

            // Assert
            // Verifica se o resultado é true.
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Teste para verificar se o método AskToPlayAgain retorna false quando a entrada é 2.
        /// </summary>
        [TestMethod]
        [Description("Verifica se o método AskToPlayAgain retorna false quando a entrada é 2.")]
        [Owner("SilvaHenrique")]
        [Priority(2)]
        [TestCategory("GameTests")]
        public void AskToPlayAgain_NoInput_ReturnsFalse()
        {
            // Arrange
            // Cria uma instância do jogo.
            var game = new Game();

            // Redireciona a entrada do console para um StringReader com a entrada "2".
            var input = "2";
            Console.SetIn(new StringReader(input));

            // Act
            // Chama o método AskToPlayAgain.
            var result = game.AskToPlayAgain();

            // Assert
            // Verifica se o resultado é false.
            Assert.IsFalse(result);
        }
    }
}
