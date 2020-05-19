using System;
using tabuleiro;
using xadrez;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               
                    Partida partida = new Partida();
                do
                {

                    Console.Clear();
                    Tela.exibirTabuleiro(partida._TabuleiroPartida);

                    Console.WriteLine();
                    Console.WriteLine("\nEscolha a posição da peça a ser movimentada: ");
                    Posicao inicial = Tela.jogada().toPosicao();
                    bool[,] movPossiveis = partida._TabuleiroPartida.peca(inicial).movimentosPossiveis();

                    Console.Clear();
                    Tela.exibirTabuleiro(partida._TabuleiroPartida, movPossiveis);


                    Console.WriteLine("Escolha a posição de destino: ");
                    Posicao final = Tela.jogada().toPosicao();

                    partida.jogada(inicial, final);
                    Tela.exibirTabuleiro(partida._TabuleiroPartida);

                } while (partida._fim != true);

            }
            catch (ExceptionsTabuleiro e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
