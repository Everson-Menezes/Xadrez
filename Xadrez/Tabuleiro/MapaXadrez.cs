using System;
using tabuleiro;
namespace xadrez
{
    class MapaXadrez
    {
        public char _coluna { get; set; }
        public int _linha { get; set; }

        public MapaXadrez(char coluna, int linha)
        {
            _coluna = coluna;
            _linha = linha;
        }

        public override string ToString()
        {
            return "" + _coluna + _linha;
        }

        public Posicao toPosicao()
        {
            return new Posicao(8 - _linha, _coluna - 'a');
        }

    }
}
