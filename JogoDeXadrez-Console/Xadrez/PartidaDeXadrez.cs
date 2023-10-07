using System;
using TabuleiroSpace;

namespace XadrezSpace
{
    internal class PartidaDeXadrez
    {
        public Tabuleiro TabuleiroPartida { get; private set; }
        public int Turno { get; private set; }
        public Cor JogadorAtual { get; private set; }
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

        public void RealizaJogada(Posicao origem, Posicao destino)
        {
            ExecutaMovimento(origem, destino);
            PassarTurno();
        }

        private void PassarTurno()
        {
            if(JogadorAtual == Cor.Branca)
            {
                JogadorAtual = Cor.Preta;
            }
            else
            {
                JogadorAtual = Cor.Branca;
            }
            Turno++;
        }

        public void TestePosicaoDeOrigem(Posicao posicaoOrigem)
        {
            if(TabuleiroPartida.RetornaPeca(posicaoOrigem) == null)
            {
                throw new TabuleiroException("Não existe alguma peça na posição escolhida!");
            }
            if (JogadorAtual != TabuleiroPartida.RetornaPeca(posicaoOrigem).CorPeca)
            {
                throw new TabuleiroException("A peça escolhida não é sua!");
            }
            if (!TabuleiroPartida.RetornaPeca(posicaoOrigem).ExisteMovimentosPossiveis())
            {
                throw new TabuleiroException("Não existem movimentos possiveis para essa peça!");
            }
            /*if (TabuleiroPartida.ExistePecaPosicao(posicaoOrigem)) //BUG : Encontrar uma forma de atribuir uma exceção para seleção de peça fora da area do tabuleiro
            {
                throw new TabuleiroException("Posição não existe no tabuleiro!");
            }*/

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
