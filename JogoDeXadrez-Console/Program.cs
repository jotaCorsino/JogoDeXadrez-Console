using System;
using TabuleiroSpace;
using XadrezSpace;

namespace JogoDeXadrez_Console;

internal class Program
{
    static void Main(string[] args)
    {
        Tabuleiro tabuleiro = new Tabuleiro(8, 8);

        tabuleiro.ColocarPecaNoTabuleiro(new PecaTorre(Cor.Preta, tabuleiro), new Posicao(0, 0));
        tabuleiro.ColocarPecaNoTabuleiro(new PecaTorre(Cor.Preta, tabuleiro), new Posicao(1, 3));
        tabuleiro.ColocarPecaNoTabuleiro(new PecaRei(Cor.Preta, tabuleiro), new Posicao(2, 4));
        Tela.ImprimirTabuleiro(tabuleiro);
    }
}