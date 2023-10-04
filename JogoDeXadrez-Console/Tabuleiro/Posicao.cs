
namespace TabuleiroSpace
{
    internal class Posicao
    {
        public int PosicaoLinha { get; set; }
        public int PosicaoColuna { get; set; }

        public Posicao(int posicaoLinha, int posicaoColuna)
        {
            PosicaoLinha = posicaoLinha;
            PosicaoColuna = posicaoColuna;
        }

        public override string ToString()
        {
            return $"{PosicaoLinha}, {PosicaoColuna}";
        }

    }
}
