using System;
using TabuleiroSpace;

namespace JogoDeXadrez_Console
{
    internal class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.TabuleiroLinhas; i++)
            {
                for (int j = 0; j < tabuleiro.TabuleiroColunas; j++)
                {
                    if (tabuleiro.RetornaPeca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tabuleiro.RetornaPeca(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
