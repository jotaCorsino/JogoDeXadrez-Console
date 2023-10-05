
namespace TabuleiroSpace
{
    abstract class Peca
    {
        public Posicao PosicaoPeca { get; set; }
        public Cor CorPeca { get; protected set; }
        public int QuantidadeDeMovimentosPeca { get; protected set; }
        public Tabuleiro TabuleiroPeca { get; protected set; }

        public Peca(Cor corPeca, Tabuleiro tabuleiroPeca)
        {
            PosicaoPeca = null;
            CorPeca = corPeca;
            TabuleiroPeca = tabuleiroPeca;
            QuantidadeDeMovimentosPeca = 0;
        }

        public abstract bool[,] MovimentosPossiveisPeca();

        public void IncrementarQuantidadeDeMovimento()
        {
            QuantidadeDeMovimentosPeca++;
        }
        public void DecrementarQuantidadeDeMovimento()
        {
            QuantidadeDeMovimentosPeca--;
        }
    }
}
