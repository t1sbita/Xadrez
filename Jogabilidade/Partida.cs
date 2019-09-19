using Tabuleiro;
using Erros;

namespace Jogabilidade
{
    class Partida
    {
        public Mesa Mesa { get; private set; }
        private int Turno;
        private Cor JogadorAtual;
        public bool Terminada;

        public Partida()
        {
            Mesa = new Mesa(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            Terminada = false;
            IniciarPecas();
        }

        public void Movimentacao(Posicao origem, Posicao destino)
        {
            Peca pecaMovida = Mesa.RetirarPeca(origem);
            if(pecaMovida == null)
            {
                throw new Exceptions("Nenhuma Peça selecionada!");
            }
            pecaMovida.IncrementarMovimento();
            Peca pecaRemovida = Mesa.RetirarPeca(destino);
            Mesa.ColocarPeca(pecaMovida, destino);
        }

        public void IniciarPecas()
        {
            Mesa.ColocarPeca(new Torre(Mesa, Cor.Preta), new Posicao(0, 0));
            Mesa.ColocarPeca(new Cavalo(Mesa, Cor.Preta), new Posicao(0, 1));
            Mesa.ColocarPeca(new Bispo(Mesa, Cor.Preta), new Posicao(0, 2));
            Mesa.ColocarPeca(new Rainha(Mesa, Cor.Preta), new Posicao(0, 3));
            Mesa.ColocarPeca(new Rei(Mesa, Cor.Preta), new Posicao(0, 4));
            Mesa.ColocarPeca(new Bispo(Mesa, Cor.Preta), new Posicao(0, 5));
            Mesa.ColocarPeca(new Cavalo(Mesa, Cor.Preta), new Posicao(0, 6));
            Mesa.ColocarPeca(new Torre(Mesa, Cor.Preta), new Posicao(0, 7));
            Mesa.ColocarPeca(new Peao(Mesa, Cor.Preta), new Posicao(1, 0));
            Mesa.ColocarPeca(new Peao(Mesa, Cor.Preta), new Posicao(1, 1));
            Mesa.ColocarPeca(new Peao(Mesa, Cor.Preta), new Posicao(1, 2));
            Mesa.ColocarPeca(new Peao(Mesa, Cor.Preta), new Posicao(1, 3));
            Mesa.ColocarPeca(new Peao(Mesa, Cor.Preta), new Posicao(1, 4));
            Mesa.ColocarPeca(new Peao(Mesa, Cor.Preta), new Posicao(1, 5));
            Mesa.ColocarPeca(new Peao(Mesa, Cor.Preta), new Posicao(1, 6));
            Mesa.ColocarPeca(new Peao(Mesa, Cor.Preta), new Posicao(1, 7));
            
            Mesa.ColocarPeca(new Torre(Mesa, Cor.Branca), new Posicao(7, 0));
            Mesa.ColocarPeca(new Cavalo(Mesa, Cor.Branca), new Posicao(7, 1));
            Mesa.ColocarPeca(new Bispo(Mesa, Cor.Branca), new Posicao(7, 2));
            Mesa.ColocarPeca(new Rei(Mesa, Cor.Branca), new Posicao(7, 3));
            Mesa.ColocarPeca(new Rainha(Mesa, Cor.Branca), new Posicao(7, 4));
            Mesa.ColocarPeca(new Bispo(Mesa, Cor.Branca), new Posicao(7, 5));
            Mesa.ColocarPeca(new Cavalo(Mesa, Cor.Branca), new Posicao(7, 6));
            Mesa.ColocarPeca(new Torre(Mesa, Cor.Branca), new Posicao(7, 7));
            Mesa.ColocarPeca(new Peao(Mesa, Cor.Branca), new Posicao(6, 0));
            Mesa.ColocarPeca(new Peao(Mesa, Cor.Branca), new Posicao(6, 1));
            Mesa.ColocarPeca(new Peao(Mesa, Cor.Branca), new Posicao(6, 2));
            Mesa.ColocarPeca(new Peao(Mesa, Cor.Branca), new Posicao(6, 3));
            Mesa.ColocarPeca(new Peao(Mesa, Cor.Branca), new Posicao(6, 4));
            Mesa.ColocarPeca(new Peao(Mesa, Cor.Branca), new Posicao(6, 5));
            Mesa.ColocarPeca(new Peao(Mesa, Cor.Branca), new Posicao(6, 6));
            Mesa.ColocarPeca(new Peao(Mesa, Cor.Branca), new Posicao(6, 7));
        }
    }

    
}
