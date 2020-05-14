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

        public Peca peca(Posicao pos)
        {
            return _pecas[pos._linha, pos._coluna];
        }

        public void adicionarPeca(Peca peca, Posicao posicao)
        {
            _pecas[posicao._linha, posicao._coluna] = peca;
            peca._posicao = posicao;
        }

        public bool posicaoPermitida(Posicao pos)
        {
            if (pos._linha < 0 || pos._linha >= linhas || pos._coluna < 0 || pos._coluna >= colunas)
            {
                return false;
            }
            return true;
        }

        public void vaalidarPosicao()
        {

        }
    }
}
