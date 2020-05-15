using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] _pecasTabuleiro;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            _pecasTabuleiro = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna)
        {
            return _pecasTabuleiro[linha, coluna];
        }

        public Peca peca(Posicao pos)
        {
            return _pecasTabuleiro[pos._linha, pos._coluna];
        }

        public void adicionarPeca(Peca peca, Posicao posicao)
        {
            if (existePeca(posicao))
            {
                throw new ExceptionsTabuleiro("Já existe uma peça nesta posição!");
            }
            _pecasTabuleiro[posicao._linha, posicao._coluna] = peca;
            peca._posicao = posicao;
        }

        public Peca removerPeca(Posicao posicao)
        {
            if (peca(posicao) == null)
            {
                return null;
            }
            else
            {
                Peca aux = peca(posicao);
                aux._posicao = null;
                _pecasTabuleiro[posicao._linha, posicao._coluna] = null;
                return aux;
            }
        }

        public bool posicaoPermitida(Posicao posicao)
        {
            if (posicao._linha < 0 || posicao._linha >= linhas || posicao._coluna < 0 || posicao._coluna >= colunas)
            {
                return false;
            }
            return true;
        }

        public void validarPosicao(Posicao posicao)
        {
            if (!posicaoPermitida(posicao))
            {
                Console.WriteLine(posicao);
                throw new ExceptionsTabuleiro("Posição inválida!");
            }
        }

        public bool existePeca(Posicao posicao)
        {
            validarPosicao(posicao);
            return peca(posicao) != null;
        }
    }
}
