
using System;

namespace TabuleiroSpace
{
    internal class Tabuleiro
    {
        public int TabuleiroLinhas { get; set; }
        public int TabuleiroColunas { get; set; }
        private Peca[,] Pecas;

        public Tabuleiro(int tabuleiroLinhas, int tabuleiroColunas)
        {
            TabuleiroLinhas = tabuleiroLinhas;
            TabuleiroColunas = tabuleiroColunas;
            Pecas = new Peca[tabuleiroLinhas, tabuleiroColunas];
        }

        public Peca RetornaPeca(int pecaLinha, int pecaColuna)
        {
            return Pecas[pecaLinha, pecaColuna];
        }
        public Peca RetornaPeca(Posicao posicao)
        {
            return Pecas[posicao.PosicaoLinha, posicao.PosicaoColuna];
        }

        public bool ExistePecaPosicao(Posicao posicao)
        {
            ValidarPosicao(posicao);
            return RetornaPeca(posicao) != null;
        }

        public void ColocarPecaNoTabuleiro(Peca peca, Posicao posicao)
        {
            if (ExistePecaPosicao(posicao))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }
            Pecas[posicao.PosicaoLinha, posicao.PosicaoColuna] = peca;
            peca.PosicaoPeca = posicao;
        }

        public Peca RetirarPecaDoTabuleiro(Posicao posicao)
        {
            if (RetornaPeca(posicao) == null)
            {
                return null;
            }
            Peca pecaNaPosicao = RetornaPeca(posicao);
            pecaNaPosicao.PosicaoPeca = null;
            Pecas[posicao.PosicaoLinha, posicao.PosicaoColuna] = null;
            return pecaNaPosicao;
        }

        public bool TestePosicaoValida(Posicao posicao)
        {
            if (posicao.PosicaoLinha < 0 || posicao.PosicaoLinha >= TabuleiroLinhas || posicao.PosicaoColuna >= TabuleiroColunas || posicao.PosicaoColuna < 0)
            {
                return false;
            }
            return true;
        }

        public void ValidarPosicao(Posicao posicao)
        {
            if (!TestePosicaoValida(posicao))
            {
                throw new TabuleiroException("Posição inválida!");
            }
        }
    }
}
