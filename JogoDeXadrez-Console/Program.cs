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
                try
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partidaDeXadrez.TabuleiroPartida);

                    Tela.ImprimirPartida(partidaDeXadrez);

                    Posicao origem = Tela.LerPosicaoTabuleiroXadrez("Selecionar Peça: ", partidaDeXadrez).ConvertePosicao();
                    partidaDeXadrez.TestePosicaoDeOrigem(origem);


                    bool[,] marcaMovimentosPossiveis = partidaDeXadrez.TabuleiroPartida.RetornaPeca(origem).MovimentosPossiveisPeca();

                    Console.Clear();
                    Tela.ImprimirTabuleiro(partidaDeXadrez.TabuleiroPartida, marcaMovimentosPossiveis);

                    Posicao destino = Tela.LerPosicaoTabuleiroXadrez("Mover para: ", partidaDeXadrez).ConvertePosicao();

                    partidaDeXadrez.RealizaJogada(origem, destino);

                }
                catch (TabuleiroException mensagemErro)
                {
                    ConsoleColor corConsolePadrao = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(mensagemErro.Message);
                    Console.ReadLine();
                    Console.ForegroundColor = corConsolePadrao;
                }
            }


        }
        catch (TabuleiroException mensagemErro)
        {
            ConsoleColor corConsolePadrao = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mensagemErro.Message);
            Console.ReadLine();
            Console.ForegroundColor = corConsolePadrao;
        }
    }
}