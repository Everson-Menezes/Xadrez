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


               


                Tela.exibirTabuleiro(partida._TabuleiroPartida);

            }
            catch(ExceptionsTabuleiro e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
