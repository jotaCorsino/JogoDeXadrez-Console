using System;
using TabuleiroSpace;

namespace XadrezSpace
{
    internal class PartidaDeXadrez
    {
        public Tabuleiro TabuleiroPartida { get; private set; }
        private int Turno;
        private Cor JogadorAtual;
        public bool TerminouPartida { get; private set; }

        public PartidaDeXadrez()
        {
            TabuleiroPartida = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            TerminouPartida = false;
            IniciaPecasNoTabuleiro();
        }

        public void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca peca = TabuleiroPartida.RetirarPecaDoTabuleiro(origem);
            peca.IncrementarQuantidadeDeMovimento();
            Peca pecaCapturada = TabuleiroPartida.RetirarPecaDoTabuleiro(destino);
            TabuleiroPartida.ColocarPecaNoTabuleiro(peca, destino);
        }

        private void IniciaPecasNoTabuleiro()
        {
            // Peças Brancas

            TabuleiroPartida.ColocarPecaNoTabuleiro(new PecaTorre(Cor.Branca, TabuleiroPartida), new PosicaoTabuleiroXadrez('e', 2).ConvertePosicao());
            TabuleiroPartida.ColocarPecaNoTabuleiro(new PecaTorre(Cor.Branca, TabuleiroPartida), new PosicaoTabuleiroXadrez('e', 1).ConvertePosicao());
            TabuleiroPartida.ColocarPecaNoTabuleiro(new PecaRei(Cor.Branca, TabuleiroPartida), new PosicaoTabuleiroXadrez('d', 1).ConvertePosicao());


            //Peças Pretas
            TabuleiroPartida.ColocarPecaNoTabuleiro(new PecaTorre(Cor.Preta, TabuleiroPartida), new PosicaoTabuleiroXadrez('c', 7).ConvertePosicao());
            TabuleiroPartida.ColocarPecaNoTabuleiro(new PecaTorre(Cor.Preta, TabuleiroPartida), new PosicaoTabuleiroXadrez('c', 8).ConvertePosicao());
            TabuleiroPartida.ColocarPecaNoTabuleiro(new PecaTorre(Cor.Preta, TabuleiroPartida), new PosicaoTabuleiroXadrez('d', 7).ConvertePosicao());
            TabuleiroPartida.ColocarPecaNoTabuleiro(new PecaTorre(Cor.Preta, TabuleiroPartida), new PosicaoTabuleiroXadrez('e', 7).ConvertePosicao());
            TabuleiroPartida.ColocarPecaNoTabuleiro(new PecaTorre(Cor.Preta, TabuleiroPartida), new PosicaoTabuleiroXadrez('e', 8).ConvertePosicao());
            TabuleiroPartida.ColocarPecaNoTabuleiro(new PecaRei(Cor.Preta, TabuleiroPartida), new PosicaoTabuleiroXadrez('d', 8).ConvertePosicao());

        }
    }
}
