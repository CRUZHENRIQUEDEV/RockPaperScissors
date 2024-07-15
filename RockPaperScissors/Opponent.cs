using System; // Importa o namespace System, que contém definições básicas de tipos, como classes e métodos para manipulação de dados, entrada/saída, e outros.

namespace RockPaperScissors // Define um namespace para agrupar classes relacionadas ao jogo Rock Paper Scissors.
{
    /// <summary>
    /// A classe Opponent representa o oponente (computador) no jogo.
    /// </summary>
    public class Opponent
    {
        /// <summary>
        /// Método para obter a escolha do oponente.
        /// </summary>
        /// <returns>Retorna uma escolha aleatória de Rock, Paper ou Scissors.</returns>
        public Choice GetOpponentChoice()
        {
            // Obtém todas as possíveis escolhas do enum Choice.
            // Enum.GetValues retorna uma matriz de todos os valores do enum especificado.
            var options = Enum.GetValues(typeof(Choice));

            // Cria uma nova instância da classe Random.
            // A classe Random é usada para gerar números pseudo-aleatórios.
            Random random = new Random();

            // Gera um índice aleatório baseado no número de opções disponíveis.
            // random.Next(options.Length) retorna um número inteiro aleatório que é maior ou igual a zero e menor que options.Length.
            int randomIndex = random.Next(options.Length);

            // Retorna a escolha correspondente ao índice aleatório gerado.
            // options.GetValue(randomIndex) obtém o valor da enumeração na posição randomIndex.
            // (Choice) faz um cast do valor obtido para o tipo Choice.
            return (Choice)options.GetValue(randomIndex);
        }
    }
}
