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

        public static void ImprimirPartida(PartidaDeXadrez partidaDeXadrez)
        {
            Console.WriteLine();
            Console.WriteLine($"Turno: {partidaDeXadrez.Turno}");

            if (partidaDeXadrez.JogadorAtual == Cor.Branca)
            {
                Console.Write($"Aguardando jogada: {partidaDeXadrez.JogadorAtual}");
                Console.WriteLine();
            }
            else
            {
                Console.Write("Aguardando jogada: ");
                ConsoleColor corConsolePadrao = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(partidaDeXadrez.JogadorAtual);
                Console.ForegroundColor = corConsolePadrao;
                Console.WriteLine();
            }
        }

        public static PosicaoTabuleiroXadrez LerPosicaoTabuleiroXadrez(string descricaoDaLeitura, PartidaDeXadrez partidaDeXadrez)
        {
            char[] charValidos = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };

            while (true)
            {
                try
                {
                    Console.WriteLine();
                    Console.Write(descricaoDaLeitura);
                    string lerPosicaoTabuleiroXadrez = Console.ReadLine();

                    if (!string.IsNullOrEmpty(lerPosicaoTabuleiroXadrez) && lerPosicaoTabuleiroXadrez.Any())
                    {
                        char coluna = lerPosicaoTabuleiroXadrez[0];

                        if (charValidos.Any(item => item == coluna))
                        {
                            string coordenadaLinha = lerPosicaoTabuleiroXadrez[1].ToString() ?? "";
                            if (int.TryParse(coordenadaLinha, out int linha))
                            {
                                if (linha >= 1 || linha <= 8)
                                {
                                    return new PosicaoTabuleiroXadrez(coluna, linha);
                                }
                                else
                                {
                                    throw new TabuleiroException("O valor da linha não existe no tabuleiro!");
                                }
                            }
                            else
                            {
                                throw new TabuleiroException("O valor da linha não é um número!");
                            }
                        }
                        else
                        {
                            throw new TabuleiroException("Coluna inválida!");
                        }
                    }
                    else
                    {
                        throw new TabuleiroException("Digite algum valor válido!");
                    }
                }
                catch (TabuleiroException ex)
                {
                    ConsoleColor corConsolePadrao = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = corConsolePadrao;
                    Console.ReadLine();
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partidaDeXadrez.TabuleiroPartida);
                    ImprimirPartida(partidaDeXadrez);
                }
            }
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
