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
            throw new NotImplementedException();
        }

        public  bool podeMovimentar()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "P";
        }

       
    }

}
