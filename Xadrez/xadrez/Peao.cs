using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{

    class Peao : Peca
    {
        public Peao(Cor cor, Tabuleiro tabuleiro) : base(cor, tabuleiro)
        {

        }

        public override bool[,] movimentosPossiveis()
        {
            //posição teste. implementar entrada depois
            Posicao pos = new Posicao(0, 0);
            Posicao posInicial = new Posicao(0, 0);
            // recebe todas as linhas e colunas do tabuleiro em verdadeiro ou falso
            bool[,] matriz = new bool[_tabuleiro.linhas, _tabuleiro.colunas];

            // instacia uma peca auxiliar que recebe a peça do tabuleiro
            Peca pecaNoTabuleiro = _tabuleiro.peca(_posicao);


            //primeiro movimento
            if (pecaNoTabuleiro._cor == Cor.Branca && pecaNoTabuleiro._qtdMovimentos == 0)
            {
                posInicial.setarValores(_posicao._linha + 2, _posicao._coluna);
                pos.setarValores(_posicao._linha + 1, _posicao._coluna);

            }
            else if (pecaNoTabuleiro._cor == Cor.Preta && _qtdMovimentos == 0)
            {
                posInicial.setarValores(_posicao._linha - 2, _posicao._coluna);
                pos.setarValores(_posicao._linha - 1, _posicao._coluna);
            }
            if (_tabuleiro.posicaoPermitida(pos) && podeMovimentar(pos))
            {
                matriz[pos._linha, pos._coluna] = true;
                matriz[posInicial._linha, posInicial._coluna] = true;
            }
            // verificar acima
            if (pecaNoTabuleiro._cor == Cor.Branca)
            {
                pos.setarValores(_posicao._linha + 1, _posicao._coluna);
            }
            else if (pecaNoTabuleiro._cor == Cor.Preta)
            {
                pos.setarValores(_posicao._linha - 1, _posicao._coluna);
            }

            if (_tabuleiro.posicaoPermitida(pos) && podeMovimentar(pos))
            {
                matriz[pos._linha, pos._coluna] = true;
            }

            // verificar acima direita
            if (pecaNoTabuleiro._cor == Cor.Branca)
            {
                pos.setarValores(_posicao._linha + 1, _posicao._coluna + 1);
            }
            else if (pecaNoTabuleiro._cor == Cor.Preta)
            {
                pos.setarValores(_posicao._linha - 1, _posicao._coluna - 1);
            }

            if (_tabuleiro.posicaoPermitida(pos) && adversario(pos))
            {
                matriz[pos._linha, pos._coluna] = true;

            }

            // verificar acima esquerda
            if (pecaNoTabuleiro._cor == Cor.Branca)
            {
                pos.setarValores(_posicao._linha + 1, _posicao._coluna - 1);
            }
            else if (pecaNoTabuleiro._cor == Cor.Preta)
            {
                pos.setarValores(_posicao._linha - 1, _posicao._coluna + 1);
            }

            if (_tabuleiro.posicaoPermitida(pos) && adversario(pos))
            {
                matriz[pos._linha, pos._coluna] = true;

            }

            return matriz;
        }

        public bool podeMovimentar(Posicao posicao)
        {
            Peca pecaNoTabuleiro = _tabuleiro.peca(posicao);

            return pecaNoTabuleiro == null;
        }

        private bool adversario(Posicao posicao)
        {
            Peca pAdversaria = _tabuleiro.peca(posicao);
            return pAdversaria!= null && pAdversaria._cor != _cor;
        }

        public override string ToString()
        {
            return "P";
        }


    }

}
