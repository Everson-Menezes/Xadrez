using System;
using tabuleiro;
namespace xadrez
{
    class Partida
    {
        public Tabuleiro _TabuleiroPartida { get; private set; }
        public int _rodada { get; private set; }
        public Cor _jogador { get; private set; }
        public bool _fim { get; private set; }

        public Partida()
        {
            _TabuleiroPartida = new Tabuleiro(8, 8);
            _rodada = 2;
            _jogador = Cor.Branca;
            adicionarPecas();
            _fim = false;
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
            /*_TabuleiroPartida.adicionarPeca(new Bispo(Cor.Preta, _TabuleiroPartida), new MapaXadrez('a', 2).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Peao(Cor.Preta, _TabuleiroPartida), new MapaXadrez('b', 2).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Peao(Cor.Preta, _TabuleiroPartida), new MapaXadrez('c', 2).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Peao(Cor.Preta, _TabuleiroPartida), new MapaXadrez('d', 2).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Peao(Cor.Preta, _TabuleiroPartida), new MapaXadrez('e', 2).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Peao(Cor.Preta, _TabuleiroPartida), new MapaXadrez('f', 2).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Peao(Cor.Preta, _TabuleiroPartida), new MapaXadrez('g', 2).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Peao(Cor.Preta, _TabuleiroPartida), new MapaXadrez('h', 2).toPosicao());*/
            _TabuleiroPartida.adicionarPeca(new Torre(Cor.Preta, _TabuleiroPartida), new MapaXadrez('a', 1).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Torre(Cor.Preta, _TabuleiroPartida), new MapaXadrez('h', 1).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Cavalo(Cor.Preta, _TabuleiroPartida), new MapaXadrez('b', 1).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Cavalo(Cor.Preta, _TabuleiroPartida), new MapaXadrez('g', 1).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Bispo(Cor.Preta, _TabuleiroPartida), new MapaXadrez('c', 1).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Bispo(Cor.Preta, _TabuleiroPartida), new MapaXadrez('f', 1).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Rei(Cor.Preta, _TabuleiroPartida), new MapaXadrez('d', 1).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Rainha(Cor.Preta, _TabuleiroPartida), new MapaXadrez('e', 1).toPosicao());


            //Branca__________________________________________________________

            /*_TabuleiroPartida.adicionarPeca(new Bispo(Cor.Branca, _TabuleiroPartida), new MapaXadrez('a', 7).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Peao(Cor.Branca, _TabuleiroPartida), new MapaXadrez('b', 7).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Peao(Cor.Branca, _TabuleiroPartida), new MapaXadrez('c', 7).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Peao(Cor.Branca, _TabuleiroPartida), new MapaXadrez('d', 7).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Peao(Cor.Branca, _TabuleiroPartida), new MapaXadrez('e', 7).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Peao(Cor.Branca, _TabuleiroPartida), new MapaXadrez('f', 7).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Peao(Cor.Branca, _TabuleiroPartida), new MapaXadrez('g', 7).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Peao(Cor.Branca, _TabuleiroPartida), new MapaXadrez('h', 7).toPosicao());*/
            _TabuleiroPartida.adicionarPeca(new Torre(Cor.Branca, _TabuleiroPartida), new MapaXadrez('a', 8).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Torre(Cor.Branca, _TabuleiroPartida), new MapaXadrez('h', 8).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Cavalo(Cor.Branca, _TabuleiroPartida), new MapaXadrez('b', 8).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Cavalo(Cor.Branca, _TabuleiroPartida), new MapaXadrez('g', 8).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Bispo(Cor.Branca, _TabuleiroPartida), new MapaXadrez('c', 8).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Bispo(Cor.Branca, _TabuleiroPartida), new MapaXadrez('f', 8).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Rei(Cor.Branca, _TabuleiroPartida), new MapaXadrez('e', 8).toPosicao());
            _TabuleiroPartida.adicionarPeca(new Rainha(Cor.Branca, _TabuleiroPartida), new MapaXadrez('d', 8).toPosicao());

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
