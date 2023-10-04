using TabuleiroSpace;

namespace XadrezSpace
{
    internal class PosicaoTabuleiroXadrez
    {
        public char PosicaoTabuleiroColuna { get; set; }
        public int PosicaoTabuleiroLinha { get; set; }

        public PosicaoTabuleiroXadrez(char posicaoTabuleiroColuna, int posicaoTabuleiroLinha)
        {
            PosicaoTabuleiroColuna = posicaoTabuleiroColuna;
            PosicaoTabuleiroLinha = posicaoTabuleiroLinha;
        }

        public Posicao ConvertePosicao()
        {
            return new Posicao(8 - PosicaoTabuleiroLinha, PosicaoTabuleiroColuna - 'a');
        }
        public override string ToString()
        {
            return ($"{PosicaoTabuleiroColuna}, {PosicaoTabuleiroLinha}");
        }
    }
}
