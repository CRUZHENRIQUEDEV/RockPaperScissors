using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors;
using System;
using System.IO;

namespace RockPaperScissorsTests
{
    /// <summary>
    /// Classe de testes para a classe Player.
    /// </summary>
    [TestClass]
    public class PlayerTests
    {
        /// <summary>
        /// Teste para verificar se o método GetUserChoice retorna a escolha correta quando a entrada é válida.
        /// </summary>
        [TestMethod]
        [Description("Verifica se o método GetUserChoice retorna a escolha correta (Rock) quando a entrada é 1.")]
        [Owner("SilvaHenrique")]
        [Priority(1)]
        [TestCategory("PlayerTests")]
        public void GetUserChoice_ValidInput_ReturnsChoice()
        {
            // Arrange
            var player = new Player();
            var input = "1";
            Console.SetIn(new StringReader(input));

            // Act
            var result = player.GetUserChoice();

            // Assert
            Assert.AreEqual(Choice.Rock, result);
        }

        /// <summary>
        /// Teste para verificar se o método GetUserChoice solicita novamente a entrada quando a entrada é inválida.
        /// </summary>
        [TestMethod]
        [Description("Verifica se o método GetUserChoice solicita novamente a entrada quando a entrada inicial é inválida.")]
        [Owner("SilvaHenrique")]
        [Priority(2)]
        [TestCategory("PlayerTests")]
        public void GetUserChoice_InvalidInput_PromptsAgain()
        {
            // Arrange
            var player = new Player();
            var inputs = "invalid\n1";
            Console.SetIn(new StringReader(inputs));

            // Act
            var result = player.GetUserChoice();

            // Assert
            Assert.AreEqual(Choice.Rock, result);
        }
    }
}
