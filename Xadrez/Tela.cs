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
                    if (tabuleiro.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                       exibirPeca(tabuleiro.peca(i, j));
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine(" ");
            }
            aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("  A B C D E F G H");
            Console.ForegroundColor = aux;
            
        }
        public static void exibirPeca(Peca peca)
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
        }

        public static MapaXadrez jogada()
        {
            string entrada = Console.ReadLine();
            char coluna = entrada[0];
            int linha = int.Parse(entrada[1] + "");
            return new MapaXadrez(coluna, linha);
        }
    }
}
