using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Peca
    {
        public Posicao _posicao { get; set; }
        public Cor _cor { get; protected set; }
        public int _qtdMovimentos { get; protected set; }
        public Tabuleiro _tabuleiro { get; protected set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tabuleiro)
        {
            _posicao = posicao;
            _cor = cor;
            _qtdMovimentos = 0;
            _tabuleiro = tabuleiro;
        }
    }
}
