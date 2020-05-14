using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] _pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            _pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna)
        {
            return _pecas[linha, coluna];
        }

        public void adicionarPeca(Peca peca, Posicao posicao)
        {
            _pecas[posicao._linha, posicao._coluna] = peca;
            peca._posicao = posicao;
        }
    }
}
