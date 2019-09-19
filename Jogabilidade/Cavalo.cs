using System;
using Tabuleiro;

namespace Jogabilidade
{
    class Cavalo : Peca
    {
        public Cavalo(Mesa mesa, Cor cor) : base(mesa, cor)
        {

        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] possibilidades = new bool[Mesa.Linhas, Mesa.Colunas];

            Posicao posicao = new Posicao(0, 0);

            return null;
        }
        public override string ToString()
        {
            return "C";
        }
    }
}
