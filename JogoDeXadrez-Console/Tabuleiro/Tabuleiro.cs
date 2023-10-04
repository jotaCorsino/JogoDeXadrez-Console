
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

        public void ColocarPecaNoTabuleiro(Peca peca, Posicao posicao)
        {
            Pecas[posicao.PosicaoLinha, posicao.PosicaoColuna] = peca;
            peca.PosicaoPeca = posicao;
        }
    }
}
