using System;
using tabuleiro;
using xadrez;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {



            Partida partida = new Partida();

            do
            {
                try
                {
                    Console.Clear();
                    Tela.exibirTabuleiro(partida._TabuleiroPartida);
                    Console.WriteLine();
                    Console.WriteLine("\nRodada n°: " + partida._rodada + "\n");
                    Tela.cemiterio(partida);
                    Console.WriteLine();
                    if(partida.xeque == true)
                    {
                        Console.WriteLine("XEQUE!");
                    }
                    Console.WriteLine("\nAguardando jogador: " + partida._jogador);

                    Console.WriteLine("\nEscolha a posição da peça a ser movimentada: ");
                    Posicao inicial = Tela.jogada().toPosicao();
                    partida.validarPosInicial(inicial);
                    bool[,] movPossiveis = partida._TabuleiroPartida.peca(inicial).movimentosPossiveis();

                    Console.Clear();
                    Tela.exibirTabuleiro(partida._TabuleiroPartida, movPossiveis);


                    Console.WriteLine("\nEscolha a posição de destino: ");
                    Posicao final = Tela.jogada().toPosicao();
                    partida.validarPosFinal(inicial, final);
                    partida.realizarJogada(inicial, final);
                    Tela.exibirTabuleiro(partida._TabuleiroPartida);
                }
                catch (ExceptionsTabuleiro e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }

            } while (partida._fim != true);

        }

    }
}


