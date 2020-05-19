using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{

    class Rainha : Peca
    {
        public Rainha(Cor cor, Tabuleiro tabuleiro) : base(cor, tabuleiro)
        {

        }

        public override bool[,] movimentosPossiveis()
        {
            throw new NotImplementedException();
        }

        public  bool podeMovimentar()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Q";
        }

    }

}
