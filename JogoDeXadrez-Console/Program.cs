using System;
using Tabuleiro;

namespace JogoDeXadrez_Console;

internal class Program
{
    static void Main(string[] args)
    {
        Posicao posicao = new Posicao(3, 4);

        Console.WriteLine("Posição: " + posicao);
    }
}