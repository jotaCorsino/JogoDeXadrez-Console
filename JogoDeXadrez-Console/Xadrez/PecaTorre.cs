
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
            while (TabuleiroPeca.TestePosicaoValida(posicao) && ValidarMovimento(posicao))
            {
                movimentosPossiveis[posicao.PosicaoLinha, posicao.PosicaoColuna] = true;
                if (TabuleiroPeca.RetornaPeca(posicao) != null && TabuleiroPeca.RetornaPeca(posicao).CorPeca != CorPeca)
                {
                    break;
                }
                posicao.PosicaoLinha = posicao.PosicaoLinha - 1;
            }

            //abaixo
            posicao.DefinirValoresParaPosicao(PosicaoPeca.PosicaoLinha + 1, PosicaoPeca.PosicaoColuna);
            while (TabuleiroPeca.TestePosicaoValida(posicao) && ValidarMovimento(posicao))
            {
                movimentosPossiveis[posicao.PosicaoLinha, posicao.PosicaoColuna] = true;
                if (TabuleiroPeca.RetornaPeca(posicao) != null && TabuleiroPeca.RetornaPeca(posicao).CorPeca != CorPeca)
                {
                    break;
                }
                posicao.PosicaoLinha = posicao.PosicaoLinha + 1;
            }

            //direita
            posicao.DefinirValoresParaPosicao(PosicaoPeca.PosicaoLinha, PosicaoPeca.PosicaoColuna + 1);
            while (TabuleiroPeca.TestePosicaoValida(posicao) && ValidarMovimento(posicao))
            {
                movimentosPossiveis[posicao.PosicaoLinha, posicao.PosicaoColuna] = true;
                if (TabuleiroPeca.RetornaPeca(posicao) != null && TabuleiroPeca.RetornaPeca(posicao).CorPeca != CorPeca)
                {
                    break;
                }
                posicao.PosicaoColuna = posicao.PosicaoColuna + 1;
            }

            //direita
            posicao.DefinirValoresParaPosicao(PosicaoPeca.PosicaoLinha, PosicaoPeca.PosicaoColuna - 1);
            while (TabuleiroPeca.TestePosicaoValida(posicao) && ValidarMovimento(posicao))
            {
                movimentosPossiveis[posicao.PosicaoLinha, posicao.PosicaoColuna] = true;
                if (TabuleiroPeca.RetornaPeca(posicao) != null && TabuleiroPeca.RetornaPeca(posicao).CorPeca != CorPeca)
                {
                    break;
                }
                posicao.PosicaoColuna = posicao.PosicaoColuna - 1;
            }


            return movimentosPossiveis;
        }
    }
}
