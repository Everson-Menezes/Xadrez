using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{

    class Torre : Peca
    {
        public Torre(Cor cor, Tabuleiro tabuleiro) : base(cor, tabuleiro)
        {

        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] matriz = new bool[_tabuleiro.linhas, _tabuleiro.colunas];

            Posicao pos = new Posicao(0, 0);

            // acima
            pos.setarValores(_posicao._linha - 1, _posicao._coluna);

            while(_tabuleiro.posicaoPermitida(pos) && podeMovimentar(pos))
            {
                matriz[pos._linha, pos._coluna] = true;
                if(_tabuleiro.peca(pos) != null && _tabuleiro.peca(pos)._cor != _cor)
                {
                    break;
                }
                pos._linha = pos._linha - 1;
            }


            // baixo
            pos.setarValores(_posicao._linha + 1, _posicao._coluna);

            while (_tabuleiro.posicaoPermitida(pos) && podeMovimentar(pos))
            {
                matriz[pos._linha, pos._coluna] = true;
                if (_tabuleiro.peca(pos) != null && _tabuleiro.peca(pos)._cor != _cor)
                {
                    break;
                }
                pos._linha = pos._linha + 1;
            }

            // esquerda
            pos.setarValores(_posicao._linha, _posicao._coluna - 1);

            while (_tabuleiro.posicaoPermitida(pos) && podeMovimentar(pos))
            {
                matriz[pos._linha, pos._coluna] = true;
                if (_tabuleiro.peca(pos) != null && _tabuleiro.peca(pos)._cor != _cor)
                {
                    break;
                }
                pos._coluna = pos._coluna - 1;
            }


            // direita
            pos.setarValores(_posicao._linha, _posicao._coluna + 1);

            while (_tabuleiro.posicaoPermitida(pos) && podeMovimentar(pos))
            {
                matriz[pos._linha, pos._coluna] = true;
                if (_tabuleiro.peca(pos) != null && _tabuleiro.peca(pos)._cor != _cor)
                {
                    break;
                }
                pos._coluna = pos._coluna + 1;
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
            return "T";
        }

    }

}
