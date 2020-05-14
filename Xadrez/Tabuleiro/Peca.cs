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
    }
}
