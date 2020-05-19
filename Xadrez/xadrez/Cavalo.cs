using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{

    class Cavalo : Peca
    {
        public Cavalo(Cor cor, Tabuleiro tabuleiro) : base(cor, tabuleiro)
        {

        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] matriz = new bool[_tabuleiro.linhas, _tabuleiro.colunas];

            Posicao pos = new Posicao(0, 0);

            // L1 a direita cima
            pos.setarValores(_posicao._linha - 1, _posicao._coluna + 2);

            if (_tabuleiro.posicaoPermitida(pos) && podeMovimentar(pos))
            {
                matriz[pos._linha, pos._coluna] = true;
            }
            // L2 a direita cima
            pos.setarValores(_posicao._linha - 2, _posicao._coluna + 1);

            if (_tabuleiro.posicaoPermitida(pos) && podeMovimentar(pos))
            {
                matriz[pos._linha, pos._coluna] = true;
            }
            // L1 a direita baixo
            pos.setarValores(_posicao._linha + 1, _posicao._coluna + 2);

            if (_tabuleiro.posicaoPermitida(pos) && podeMovimentar(pos))
            {
                matriz[pos._linha, pos._coluna] = true;
            }
            // L2 a direita baixo
            pos.setarValores(_posicao._linha + 2, _posicao._coluna + 1);

            if (_tabuleiro.posicaoPermitida(pos) && podeMovimentar(pos))
            {
                matriz[pos._linha, pos._coluna] = true;
            }

            // L1 a esquerda cima
            pos.setarValores(_posicao._linha - 1, _posicao._coluna - 2);

            if (_tabuleiro.posicaoPermitida(pos) && podeMovimentar(pos))
            {
                matriz[pos._linha, pos._coluna] = true;
            }
            // L2 a esquerda cima
            pos.setarValores(_posicao._linha - 2, _posicao._coluna - 1);

            if (_tabuleiro.posicaoPermitida(pos) && podeMovimentar(pos))
            {
                matriz[pos._linha, pos._coluna] = true;
            }
            // L1 a esquerda baixo
            pos.setarValores(_posicao._linha + 1, _posicao._coluna - 2);

            if (_tabuleiro.posicaoPermitida(pos) && podeMovimentar(pos))
            {
                matriz[pos._linha, pos._coluna] = true;
            }
            // L2 a direita baixo
            pos.setarValores(_posicao._linha + 2, _posicao._coluna - 1);

            if (_tabuleiro.posicaoPermitida(pos) && podeMovimentar(pos))
            {
                matriz[pos._linha, pos._coluna] = true;
            }

            return matriz;
        }

        public bool podeMovimentar(Posicao posicao)
        {
            Peca pecaNoTabuleiro = _tabuleiro.peca(posicao);
            return pecaNoTabuleiro == null || pecaNoTabuleiro._cor != _cor;
        }

        public override string ToString()
        {
            return "C";
        }

    }

}
