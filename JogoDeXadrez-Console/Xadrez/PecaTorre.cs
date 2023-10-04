using TabuleiroSpace;

namespace XadrezSpace
{
    internal class PecaTorre : Peca
    {
        public PecaTorre(Cor corPeca, Tabuleiro tabuleiroPeca) : base(corPeca, tabuleiroPeca)
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}
