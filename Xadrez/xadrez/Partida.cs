using System;
using tabuleiro;
namespace xadrez
{
    class Partida
    {
        public Tabuleiro _TabuleiroPartida;
        private int _rodada;
        private Cor _jogador;

        public Partida()
        {
            _TabuleiroPartida = new Tabuleiro(8,8);
            _rodada = 2;
            _jogador = Cor.Branca;
            adicionarPecas();
        }

        public void jogada(Posicao inicial, Posicao final)
        {
            Peca p = _TabuleiroPartida.removerPeca(inicial);
            p.qtdMovimentos();
            Peca pecaComida = _TabuleiroPartida.removerPeca(final);
            _TabuleiroPartida.adicionarPeca(p, final);

        }

        private void adicionarPecas()
        {
            //Branca__________________________________________________________
            _TabuleiroPartida.adicionarPeca(new Peao(Cor.Preta, _TabuleiroPartida), new MapaXadrez('a', 2).toPosicao());
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

            _TabuleiroPartida.adicionarPeca(new Peao(Cor.Branca, _TabuleiroPartida), new MapaXadrez('a', 7).toPosicao());
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

        }
    }

}
