using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;
using xadrez;

namespace Xadrez
{
    class Tela
    {
        public static void exibirTabuleiro(Tabuleiro tabuleiro)
        {
            ConsoleColor aux;
            for (int i = 0; i < tabuleiro.linhas; i++)
            {
                aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(8 - i + " ");
                Console.ForegroundColor = aux;

                for (int j = 0; j < tabuleiro.colunas; j++)
                {
                    exibirPeca(tabuleiro.peca(i, j));
                }
                Console.WriteLine();
            }
            aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("  A B C D E F G H");
            Console.ForegroundColor = aux;

        }

        public static void exibirTabuleiro(Tabuleiro tabuleiro, bool[,] movPossiveis)
        {
            ConsoleColor aux;
            ConsoleColor fundo = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            for (int i = 0; i < tabuleiro.linhas; i++)
            {
                aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(8 - i + " ");
                Console.ForegroundColor = aux;
                for (int j = 0; j < tabuleiro.colunas; j++)
                {
                    if(movPossiveis[i,j])
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor = fundo;
                    }
                    exibirPeca(tabuleiro.peca(i, j));
                    Console.BackgroundColor = fundo;
                }
                Console.WriteLine();
            }

            aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("  A B C D E F G H");
            Console.BackgroundColor = fundo;
            Console.ForegroundColor = aux;
        }

        public static void exibirPeca(Peca peca)
        {
            if (peca == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (peca._cor == Cor.Branca)
                {
                    Console.Write(peca);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }
        }

        public static MapaXadrez jogada()
        {
            string entrada = Console.ReadLine();
            char coluna = entrada[0];
            int linha = int.Parse(entrada[1] + "");
            return new MapaXadrez(coluna, linha);
        }

        public static void cemiterio(Partida partida)
        {
            Console.WriteLine("\nCemitério das Brancas: ");
            imprimirCemiterio(partida.cemiterio(Cor.Branca));

            Console.WriteLine("\nCemitério das Pretas: ");
            imprimirCemiterio(partida.cemiterio(Cor.Preta));
        }

        public static void imprimirCemiterio(HashSet<Peca> conjPecas)
        {
            Console.Write("[");
            foreach(Peca obj in conjPecas)
            {
                Console.Write(obj + " ");

            }
            Console.Write("]");
        }
    }
}
