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

        private bool ValidarMovimento(Posicao posicao)
        {
            Peca peca = TabuleiroPeca.RetornaPeca(posicao);
            return peca == null || peca.CorPeca != CorPeca;
        }

        public override bool[,] MovimentosPossiveisPeca()
        {
            bool[,] movimentosPossiveis = new bool[TabuleiroPeca.TabuleiroLinhas, TabuleiroPeca.TabuleiroColunas];
            Posicao posicao = new Posicao(0, 0);

            //acima
            posicao.DefinirValoresParaPosicao(PosicaoPeca.PosicaoLinha - 1, PosicaoPeca.PosicaoColuna);
            if (TabuleiroPeca.TestePosicaoValida(posicao) && ValidarMovimento(posicao))
            {
                movimentosPossiveis[posicao.PosicaoLinha, posicao.PosicaoColuna] = true;
            }

            //nordeste
            posicao.DefinirValoresParaPosicao(PosicaoPeca.PosicaoLinha - 1, PosicaoPeca.PosicaoColuna + 1);
            if (TabuleiroPeca.TestePosicaoValida(posicao) && ValidarMovimento(posicao))
            {
                movimentosPossiveis[posicao.PosicaoLinha, posicao.PosicaoColuna] = true;
            }

            //direita
            posicao.DefinirValoresParaPosicao(PosicaoPeca.PosicaoLinha, PosicaoPeca.PosicaoColuna + 1);
            if (TabuleiroPeca.TestePosicaoValida(posicao) && ValidarMovimento(posicao))
            {
                movimentosPossiveis[posicao.PosicaoLinha, posicao.PosicaoColuna] = true;
            }

            //sudeste
            posicao.DefinirValoresParaPosicao(PosicaoPeca.PosicaoLinha + 1, PosicaoPeca.PosicaoColuna + 1);
            if (TabuleiroPeca.TestePosicaoValida(posicao) && ValidarMovimento(posicao))
            {
                movimentosPossiveis[posicao.PosicaoLinha, posicao.PosicaoColuna] = true;
            }

            //abaixo
            posicao.DefinirValoresParaPosicao(PosicaoPeca.PosicaoLinha + 1, PosicaoPeca.PosicaoColuna);
            if (TabuleiroPeca.TestePosicaoValida(posicao) && ValidarMovimento(posicao))
            {
                movimentosPossiveis[posicao.PosicaoLinha, posicao.PosicaoColuna] = true;
            }

            //sudoeste
            posicao.DefinirValoresParaPosicao(PosicaoPeca.PosicaoLinha + 1, PosicaoPeca.PosicaoColuna - 1);
            if (TabuleiroPeca.TestePosicaoValida(posicao) && ValidarMovimento(posicao))
            {
                movimentosPossiveis[posicao.PosicaoLinha, posicao.PosicaoColuna] = true;
            }

            //esquerda
            posicao.DefinirValoresParaPosicao(PosicaoPeca.PosicaoLinha, PosicaoPeca.PosicaoColuna - 1);
            if (TabuleiroPeca.TestePosicaoValida(posicao) && ValidarMovimento(posicao))
            {
                movimentosPossiveis[posicao.PosicaoLinha, posicao.PosicaoColuna] = true;
            }

            //noroeste
            posicao.DefinirValoresParaPosicao(PosicaoPeca.PosicaoLinha - 1, PosicaoPeca.PosicaoColuna - 1);
            if (TabuleiroPeca.TestePosicaoValida(posicao) && ValidarMovimento(posicao))
            {
                movimentosPossiveis[posicao.PosicaoLinha, posicao.PosicaoColuna] = true;
            }
            return movimentosPossiveis;
        }
    }
}

