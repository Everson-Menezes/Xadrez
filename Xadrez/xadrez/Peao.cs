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

        public override string ToString()
        {
            return "P";
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] matriz = new bool[_tabuleiro.linhas, _tabuleiro.colunas];
            Posicao posicaoMatriz = new Posicao(0, 0);

            posicaoMatriz.setarValores(posicaoMatriz._linha -1, posicaoMatriz._coluna);
            //acima
           if(_tabuleiro.posicaoPermitida(posicaoMatriz) && podeMovimentar(posicaoMatriz))
            {
                
            }
        }

        public override bool podeMovimentar()
        {
            Peca peca = _tabuleiro.peca(_posicao);
            return peca == null || peca._cor != _cor;
        }
    }

}
