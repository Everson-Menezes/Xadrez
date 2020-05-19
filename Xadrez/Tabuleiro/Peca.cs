using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao _posicao { get; set; }
        public Cor _cor { get; protected set; }
        public int _qtdMovimentos { get; protected set; }
        public Tabuleiro _tabuleiro { get; protected set; }

        public Peca(Cor cor, Tabuleiro tabuleiro)
        {
            _posicao = null;
            _cor = cor;
            _qtdMovimentos = 0;
            _tabuleiro = tabuleiro;
        }

        public void qtdMovimentos()
        {
            _qtdMovimentos++;
        }

        public abstract bool[,] movimentosPossiveis();

        public bool moviPossiveis()
        {
            bool[,] matriz = movimentosPossiveis();
            for(int i = 0; i < _tabuleiro.linhas; i++)
            {
                for(int j = 0; j < _tabuleiro.colunas; j++)
                {
                    if(matriz[i,j] == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool podeMoverPara(Posicao posicao)
        {
            return movimentosPossiveis()[posicao._linha, posicao._coluna];
        }
    }
}
