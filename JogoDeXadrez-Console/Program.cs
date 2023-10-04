using System;
using TabuleiroSpace;
using XadrezSpace;

namespace JogoDeXadrez_Console;

internal class Program
{
    static void Main(string[] args)
    {
        Tabuleiro tabuleiro = new Tabuleiro(8, 8);

        try
        {
            // Peças pretas
            tabuleiro.ColocarPecaNoTabuleiro(new PecaTorre(Cor.Preta, tabuleiro), new Posicao(0, 0));
            tabuleiro.ColocarPecaNoTabuleiro(new PecaTorre(Cor.Preta, tabuleiro), new Posicao(1, 3));
            tabuleiro.ColocarPecaNoTabuleiro(new PecaRei(Cor.Preta, tabuleiro), new Posicao(0, 2));

            //Peças brancas
            tabuleiro.ColocarPecaNoTabuleiro(new PecaTorre(Cor.Branca, tabuleiro), new Posicao(3, 5));
            tabuleiro.ColocarPecaNoTabuleiro(new PecaTorre(Cor.Branca, tabuleiro), new Posicao(2, 3));
            tabuleiro.ColocarPecaNoTabuleiro(new PecaRei(Cor.Branca, tabuleiro), new Posicao(2, 2));

            Tela.ImprimirTabuleiro(tabuleiro);
        }
        catch (TabuleiroException mensagemErro)
        {
            Console.WriteLine(mensagemErro.Message);
        }
        Console.ReadLine();
    }
}