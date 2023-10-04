using TabuleiroSpace;

namespace XadrezSpace
{
    internal class PecaRei : Peca
    {
        public PecaRei(Cor corPeca, Tabuleiro tabuleiroPeca) : base(corPeca, tabuleiroPeca)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
