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

                    Console.WriteLine("Escolha a posição de destino: ");
                    Posicao final = Tela.jogada().toPosicao();

                    partida.jogada(inicial, final);


                } while (!partida._fim);
               


                Tela.exibirTabuleiro(partida._TabuleiroPartida);

            }
            catch(ExceptionsTabuleiro e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
