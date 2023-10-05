using System;
using TabuleiroSpace;
using XadrezSpace;

namespace JogoDeXadrez_Console
{
    internal class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.TabuleiroLinhas; i++)
            {
                Console.Write($"{8 - i} ");
                for (int j = 0; j < tabuleiro.TabuleiroColunas; j++)
                {

                    ImprimirPeca(tabuleiro.RetornaPeca(i, j));

                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void ImprimirTabuleiro(Tabuleiro tabuleiro, bool[,] movimentosPossiveis)
        {

            ConsoleColor corConsolePadrão = Console.BackgroundColor;
            ConsoleColor corMarcaMovimento = ConsoleColor.DarkGray;

            for (int i = 0; i < tabuleiro.TabuleiroLinhas; i++)
            {
                Console.Write($"{8 - i} ");
                for (int j = 0; j < tabuleiro.TabuleiroColunas; j++)
                {
                    if (movimentosPossiveis[i, j] == true)
                    {
                        Console.BackgroundColor = corMarcaMovimento;
                    }
                    else
                    {
                        Console.BackgroundColor = corConsolePadrão;
                    }
                    ImprimirPeca(tabuleiro.RetornaPeca(i, j));
                    Console.BackgroundColor = corConsolePadrão;

                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = corConsolePadrão;
        }

        public static PosicaoTabuleiroXadrez LerPosicaoTabuleiroXadrez()
        {
            string lerPosicaoTabuleiroXadrez = Console.ReadLine();
            char coordenadaLetraColuna = lerPosicaoTabuleiroXadrez[0];
            int coordenadaNumeroLinha = int.Parse($"{lerPosicaoTabuleiroXadrez[1]}");
            return new PosicaoTabuleiroXadrez(coordenadaLetraColuna, coordenadaNumeroLinha);
        }

        public static void ImprimirPeca(Peca peca)
        {
            if (peca == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (peca.CorPeca == Cor.Branca)
                {
                    Console.Write(peca);
                }
                else
                {
                    ConsoleColor corPadrãoConsole = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(peca);
                    Console.ForegroundColor = corPadrãoConsole;
                }
                Console.Write(" ");
            }
        }
    }
}
