using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Posicao
    {
        public int _linha { get; set; }
        public int _coluna { get; set; }

        public Posicao(int linha, int coluna)
        {
            _linha = linha;
            _coluna = coluna;
        }

        public override string ToString()
        {
            return _linha + ", " + _coluna;
        }
    }


}
