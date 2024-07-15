using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors;

namespace RockPaperScissorsTests
{
    /// <summary>
    /// Classe de testes para a classe Opponent.
    /// </summary>
    [TestClass]
    public class OpponentTests
    {
        /// <summary>
        /// Teste para verificar se o método GetOpponentChoice retorna um valor válido.
        /// </summary>
        [TestMethod]
        [Description("Verifica se o método GetOpponentChoice retorna um valor válido (Rock, Paper ou Scissors).")]
        [Owner("SilvaHenrique")]
        [Priority(1)]
        [TestCategory("OpponentTests")]
        public void GetOpponentChoice_ReturnsValidChoice()
        {
            // Arrange
            // Cria uma instância da classe Opponent.
            var opponent = new Opponent();

            // Act
            // Chama o método GetOpponentChoice para obter a escolha do oponente.
            var result = opponent.GetOpponentChoice();

            // Assert
            // Verifica se o resultado é uma das escolhas válidas (Rock, Paper ou Scissors).
            Assert.IsTrue(result == Choice.Rock || result == Choice.Paper || result == Choice.Scissors, "A escolha do oponente deve ser Rock, Paper ou Scissors.");
        }
    }
}
