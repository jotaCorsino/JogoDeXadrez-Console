using System;
using TabuleiroSpace;
using XadrezSpace;

namespace JogoDeXadrez_Console;

internal class Program
{
    static void Main(string[] args)
    {
        PosicaoTabuleiroXadrez posicao = new PosicaoTabuleiroXadrez('c', 7);

        Console.WriteLine(posicao);

        Console.WriteLine(posicao.ConvertePosicao());
    }
}