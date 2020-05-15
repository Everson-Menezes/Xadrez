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
                Tabuleiro tb = new Tabuleiro(8, 8);


                //Branca__________________________________________________________
                tb.adicionarPeca(new Peao(Cor.Preta, tb), new Posicao(1, 0));
                tb.adicionarPeca(new Peao(Cor.Preta, tb), new Posicao(1, 1));
                tb.adicionarPeca(new Peao(Cor.Preta, tb), new Posicao(1, 2));
                tb.adicionarPeca(new Peao(Cor.Preta, tb), new Posicao(1, 3));
                tb.adicionarPeca(new Peao(Cor.Preta, tb), new Posicao(1, 4));
                tb.adicionarPeca(new Peao(Cor.Preta, tb), new Posicao(1, 5));
                tb.adicionarPeca(new Peao(Cor.Preta, tb), new Posicao(1, 6));
                tb.adicionarPeca(new Peao(Cor.Preta, tb), new Posicao(1, 7));
                tb.adicionarPeca(new Torre(Cor.Preta, tb), new Posicao(0, 7));
                tb.adicionarPeca(new Torre(Cor.Preta, tb), new Posicao(0, 0));
                tb.adicionarPeca(new Cavalo(Cor.Preta, tb), new Posicao(0, 6));
                tb.adicionarPeca(new Cavalo(Cor.Preta, tb), new Posicao(0, 1));
                tb.adicionarPeca(new Bispo(Cor.Preta, tb), new Posicao(0, 5));
                tb.adicionarPeca(new Bispo(Cor.Preta, tb), new Posicao(0, 2));
                tb.adicionarPeca(new Rei(Cor.Preta, tb), new Posicao(0, 3));
                tb.adicionarPeca(new Rainha(Cor.Preta, tb), new Posicao(0, 4));


                //Branca__________________________________________________________

                tb.adicionarPeca(new Peao(Cor.Branca, tb), new Posicao(6, 0));
                tb.adicionarPeca(new Peao(Cor.Branca, tb), new Posicao(6, 1));
                tb.adicionarPeca(new Peao(Cor.Branca, tb), new Posicao(6, 2));
                tb.adicionarPeca(new Peao(Cor.Branca, tb), new Posicao(6, 3));
                tb.adicionarPeca(new Peao(Cor.Branca, tb), new Posicao(6, 4));
                tb.adicionarPeca(new Peao(Cor.Branca, tb), new Posicao(6, 5));
                tb.adicionarPeca(new Peao(Cor.Branca, tb), new Posicao(6, 6));
                tb.adicionarPeca(new Peao(Cor.Branca, tb), new Posicao(6, 7));
                tb.adicionarPeca(new Torre(Cor.Branca, tb), new Posicao(7, 0));
                tb.adicionarPeca(new Torre(Cor.Branca, tb), new Posicao(7, 7));
                tb.adicionarPeca(new Cavalo(Cor.Branca, tb), new Posicao(7, 6));
                tb.adicionarPeca(new Cavalo(Cor.Branca, tb), new Posicao(7, 1));
                tb.adicionarPeca(new Bispo(Cor.Branca, tb), new Posicao(7, 5));
                tb.adicionarPeca(new Bispo(Cor.Branca, tb), new Posicao(7, 2));
                tb.adicionarPeca(new Rei(Cor.Branca, tb), new Posicao(7, 4));
                tb.adicionarPeca(new Rainha(Cor.Branca, tb), new Posicao(7, 3));


                Tela.exibirTabuleiro(tb);

            }
            catch(ExceptionsTabuleiro e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
