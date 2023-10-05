using System;
using TabuleiroSpace;
using XadrezSpace;

namespace JogoDeXadrez_Console;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {

            PartidaDeXadrez partidaDeXadrez = new PartidaDeXadrez();

            while (!partidaDeXadrez.TerminouPartida)
            {
                Console.Clear();
                Tela.ImprimirTabuleiro(partidaDeXadrez.TabuleiroPartida);

                Console.WriteLine();
                Console.Write("Selecionar peça: ");
                Posicao origem = Tela.LerPosicaoTabuleiroXadrez().ConvertePosicao();

                bool[,] marcaMovimentosPossiveis = partidaDeXadrez.TabuleiroPartida.RetornaPeca(origem).MovimentosPossiveisPeca();

                Console.Clear();
                Tela.ImprimirTabuleiro(partidaDeXadrez.TabuleiroPartida, marcaMovimentosPossiveis);

                Console.WriteLine();
                Console.Write("Mover para: ");
                Posicao destino = Tela.LerPosicaoTabuleiroXadrez().ConvertePosicao();

                partidaDeXadrez.ExecutaMovimento(origem, destino);
            }


        }
        catch (TabuleiroException mensagemErro)
        {
            Console.WriteLine(mensagemErro.Message);
        }
        Console.ReadLine();
    }
}