using System;
using System.Collections.Generic;
using tabuleiro;
namespace xadrez
{
    class Partida
    {
        public Tabuleiro _TabuleiroPartida { get; private set; }
        public int _rodada { get; private set; }
        public Cor _jogador { get; private set; }
        public bool _fim { get; private set; }
        private HashSet<Peca> pecas;
        private HashSet<Peca> pecasCapturadas;
        public Partida()
        {
            _TabuleiroPartida = new Tabuleiro(8, 8);
            _rodada = 1;
            _jogador = Cor.Branca;
            pecas = new HashSet<Peca>();
            pecasCapturadas = new HashSet<Peca>();
            adicionarPecas();
            _fim = false;
        }

        public Cor adversario(Cor c)
        {
            if (c == Cor.Branca)
            {
                return Cor.Preta;
            }
            else
            {
                return Cor.Branca;
            }
        }
        public void jogada(Posicao inicial, Posicao final)
        {
            Peca p = _TabuleiroPartida.removerPeca(inicial);
            p.qtdMovimentos();
            Peca pecaComida = _TabuleiroPartida.removerPeca(final);
            _TabuleiroPartida.adicionarPeca(p, final);
            if(pecaComida != null)
            {
                pecasCapturadas.Add(pecaComida);
            }
        }

        public HashSet<Peca> cemiterio(Cor c)
        {
            HashSet<Peca> x = new HashSet<Peca>();
            foreach(Peca obj in pecasCapturadas)
            {
                if(obj._cor == c)
                {
                    x.Add(obj);
                }
            }
            return x;
        }

        private void adicionarPecas2(char coluna, int linha, Peca p)
        {
            _TabuleiroPartida.adicionarPeca(p, new MapaXadrez(coluna, linha).toPosicao());
            pecas.Add(p);
        }
        private void adicionarPecas()
        {
            //Pretas
            adicionarPecas2('a', 2, new Peao(Cor.Preta, _TabuleiroPartida));
            adicionarPecas2('b', 2, new Peao(Cor.Preta, _TabuleiroPartida));
            adicionarPecas2('c', 2, new Peao(Cor.Preta, _TabuleiroPartida));
            adicionarPecas2('d', 2, new Peao(Cor.Preta, _TabuleiroPartida));
            adicionarPecas2('e', 2, new Peao(Cor.Preta, _TabuleiroPartida));
            adicionarPecas2('f', 2, new Peao(Cor.Preta, _TabuleiroPartida));
            adicionarPecas2('g', 2, new Peao(Cor.Preta, _TabuleiroPartida));
            adicionarPecas2('h', 2, new Peao(Cor.Preta, _TabuleiroPartida));
            adicionarPecas2('a', 1, new Torre(Cor.Preta, _TabuleiroPartida));
            adicionarPecas2('b', 1, new Cavalo(Cor.Preta, _TabuleiroPartida));
            adicionarPecas2('c', 1, new Bispo(Cor.Preta, _TabuleiroPartida));
            adicionarPecas2('d', 1, new Rainha(Cor.Preta, _TabuleiroPartida));
            adicionarPecas2('e', 1, new Rei(Cor.Preta, _TabuleiroPartida));
            adicionarPecas2('f', 1, new Bispo(Cor.Preta, _TabuleiroPartida));
            adicionarPecas2('g', 1, new Cavalo(Cor.Preta, _TabuleiroPartida));
            adicionarPecas2('h', 1, new Torre(Cor.Preta, _TabuleiroPartida));

            //Brancas
            adicionarPecas2('a', 7, new Peao(Cor.Branca, _TabuleiroPartida));
            adicionarPecas2('b', 7, new Peao(Cor.Branca, _TabuleiroPartida));
            adicionarPecas2('c', 7, new Peao(Cor.Branca, _TabuleiroPartida));
            adicionarPecas2('d', 7, new Peao(Cor.Branca, _TabuleiroPartida));
            adicionarPecas2('e', 7, new Peao(Cor.Branca, _TabuleiroPartida));
            adicionarPecas2('f', 7, new Peao(Cor.Branca, _TabuleiroPartida));
            adicionarPecas2('g', 7, new Peao(Cor.Branca, _TabuleiroPartida));
            adicionarPecas2('h', 7, new Peao(Cor.Branca, _TabuleiroPartida));
            adicionarPecas2('a', 8, new Torre(Cor.Branca, _TabuleiroPartida));
            adicionarPecas2('b', 8, new Cavalo(Cor.Branca, _TabuleiroPartida));
            adicionarPecas2('c', 8, new Bispo(Cor.Branca, _TabuleiroPartida));
            adicionarPecas2('d', 8, new Rainha(Cor.Branca, _TabuleiroPartida));
            adicionarPecas2('e', 8, new Rei(Cor.Branca, _TabuleiroPartida));
            adicionarPecas2('f', 8, new Bispo(Cor.Branca, _TabuleiroPartida));
            adicionarPecas2('g', 8, new Cavalo(Cor.Branca, _TabuleiroPartida));
            adicionarPecas2('h', 8, new Torre(Cor.Branca, _TabuleiroPartida));

            /*Preta__________________________________________________________
            _TabuleiroPartida.adicionarPeca(new Bispo(Cor.Preta, _TabuleiroPartida), new MapaXadrez('a', 2).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Peao(Cor.Preta, _TabuleiroPartida), new MapaXadrez('b', 2).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Peao(Cor.Preta, _TabuleiroPartida), new MapaXadrez('c', 2).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Peao(Cor.Preta, _TabuleiroPartida), new MapaXadrez('d', 2).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Peao(Cor.Preta, _TabuleiroPartida), new MapaXadrez('e', 2).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Peao(Cor.Preta, _TabuleiroPartida), new MapaXadrez('f', 2).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Peao(Cor.Preta, _TabuleiroPartida), new MapaXadrez('g', 2).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Peao(Cor.Preta, _TabuleiroPartida), new MapaXadrez('h', 2).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Torre(Cor.Preta, _TabuleiroPartida), new MapaXadrez('a', 1).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Torre(Cor.Preta, _TabuleiroPartida), new MapaXadrez('h', 1).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Cavalo(Cor.Preta, _TabuleiroPartida), new MapaXadrez('b', 1).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Cavalo(Cor.Preta, _TabuleiroPartida), new MapaXadrez('g', 1).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Bispo(Cor.Preta, _TabuleiroPartida), new MapaXadrez('c', 1).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Bispo(Cor.Preta, _TabuleiroPartida), new MapaXadrez('f', 1).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Rei(Cor.Preta, _TabuleiroPartida), new MapaXadrez('d', 1).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Rainha(Cor.Preta, _TabuleiroPartida), new MapaXadrez('e', 1).toPosicao());


            //Branca__________________________________________________________

            _TabuleiroPartida.adicionarPeca(new Bispo(Cor.Branca, _TabuleiroPartida), new MapaXadrez('a', 7).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Peao(Cor.Branca, _TabuleiroPartida), new MapaXadrez('b', 7).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Peao(Cor.Branca, _TabuleiroPartida), new MapaXadrez('c', 7).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Peao(Cor.Branca, _TabuleiroPartida), new MapaXadrez('d', 7).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Peao(Cor.Branca, _TabuleiroPartida), new MapaXadrez('e', 7).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Peao(Cor.Branca, _TabuleiroPartida), new MapaXadrez('f', 7).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Peao(Cor.Branca, _TabuleiroPartida), new MapaXadrez('g', 7).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Peao(Cor.Branca, _TabuleiroPartida), new MapaXadrez('h', 7).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Torre(Cor.Branca, _TabuleiroPartida), new MapaXadrez('a', 8).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Torre(Cor.Branca, _TabuleiroPartida), new MapaXadrez('h', 8).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Cavalo(Cor.Branca, _TabuleiroPartida), new MapaXadrez('b', 8).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Cavalo(Cor.Branca, _TabuleiroPartida), new MapaXadrez('g', 8).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Bispo(Cor.Branca, _TabuleiroPartida), new MapaXadrez('c', 8).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Bispo(Cor.Branca, _TabuleiroPartida), new MapaXadrez('f', 8).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Rei(Cor.Branca, _TabuleiroPartida), new MapaXadrez('e', 8).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Rainha(Cor.Branca, _TabuleiroPartida), new MapaXadrez('d', 8).toPosicao());
            */
        }

    


        public void realizarJogada(Posicao inicial, Posicao final)
        {
            jogada(inicial, final);
            _rodada++;
            trocarJogador();
        }

        private void trocarJogador()
        {
            if (_jogador == Cor.Branca)
            {
                _jogador = Cor.Preta;
            }
            else
            {
                _jogador = Cor.Branca;
            }
        }

        public void validarPosInicial(Posicao pos)
        {
            if (_TabuleiroPartida.peca(pos) == null)
            {
                throw new ExceptionsTabuleiro("Não existe peça na posição escolhida!");

            }
            else if (_jogador != _TabuleiroPartida.peca(pos)._cor)
            {
                throw new ExceptionsTabuleiro("A peça escolhida não pertence ao jogador!");
            }
            else if (!_TabuleiroPartida.peca(pos).moviPossiveis())
            {
                throw new ExceptionsTabuleiro("A peça escolhida não pode ser movimentada");
            }

        }
        public void validarPosFinal(Posicao inicio, Posicao fim)
        {
            if (_TabuleiroPartida.peca(inicio).podeMoverPara(fim))
            {

            }
            else
            {
                throw new ExceptionsTabuleiro("Posição de desitino inválida!");
            }
        }
    }

}
