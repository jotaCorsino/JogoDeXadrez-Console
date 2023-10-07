
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

        public bool ExisteMovimentosPossiveis()
        {
            bool[,] movimentosPossiceisPeca = MovimentosPossiveisPeca();
            for (int i = 0; i < TabuleiroPeca.TabuleiroLinhas; i++)
            {
                for (int j = 0; j < TabuleiroPeca.TabuleiroColunas; j++)
                {
                    if (movimentosPossiceisPeca[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void IncrementarQuantidadeDeMovimento()
        {
            QuantidadeDeMovimentosPeca++;
        }

        public void DecrementarQuantidadeDeMovimento()
        {
            QuantidadeDeMovimentosPeca--;
        }

        public abstract bool[,] MovimentosPossiveisPeca();
    }
}
