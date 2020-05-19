using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Cor cor, Tabuleiro tabuleiro) : base(cor, tabuleiro)
        {

        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] matriz = new bool[_tabuleiro.linhas, _tabuleiro.colunas];

            Posicao pos = new Posicao(0, 0);

            // acima
            pos.setarValores(_posicao._linha - 1, _posicao._coluna);

            if(_tabuleiro.posicaoPermitida(pos) && podeMovimentar(pos))
            {
                matriz[pos._linha, pos._coluna] = true;
            }

            // acima direita
            pos.setarValores(_posicao._linha - 1, _posicao._coluna +1);

            if (_tabuleiro.posicaoPermitida(pos) && podeMovimentar(pos))
            {
                matriz[pos._linha, pos._coluna] = true;
            }

            // direita
            pos.setarValores(_posicao._linha, _posicao._coluna + 1);

            if (_tabuleiro.posicaoPermitida(pos) && podeMovimentar(pos))
            {
                matriz[pos._linha, pos._coluna] = true;
            }

            // direita baixo
            pos.setarValores(_posicao._linha + 1, _posicao._coluna + 1);

            if (_tabuleiro.posicaoPermitida(pos) && podeMovimentar(pos))
            {
                matriz[pos._linha, pos._coluna] = true;
            }

            // baixo
            pos.setarValores(_posicao._linha + 1, _posicao._coluna);

            if (_tabuleiro.posicaoPermitida(pos) && podeMovimentar(pos))
            {
                matriz[pos._linha, pos._coluna] = true;
            }

            // baixo esquerda
            pos.setarValores(_posicao._linha + 1, _posicao._coluna - 1);

            if (_tabuleiro.posicaoPermitida(pos) && podeMovimentar(pos))
            {
                matriz[pos._linha, pos._coluna] = true;
            }

            // esquerda
            pos.setarValores(_posicao._linha, _posicao._coluna - 1);

            if (_tabuleiro.posicaoPermitida(pos) && podeMovimentar(pos))
            {
                matriz[pos._linha, pos._coluna] = true;
            }

            // esquerda acima
            pos.setarValores(_posicao._linha + 1, _posicao._coluna - 1);

            if (_tabuleiro.posicaoPermitida(pos) && podeMovimentar(pos))
            {
                matriz[pos._linha, pos._coluna] = true;
            }

            return matriz;
        }

        private bool podeMovimentar(Posicao posicao)
        {
            Peca pecaNoTabuleiro = _tabuleiro.peca(posicao);
            return pecaNoTabuleiro == null || pecaNoTabuleiro._cor != _cor;
        }

        public override string ToString()
        {
            return "R";
        }

    }
}
