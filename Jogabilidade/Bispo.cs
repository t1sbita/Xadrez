using System;
using Tabuleiro;

namespace Jogabilidade
{
    class Bispo : Peca
    {
        public Bispo(Mesa mesa, Cor cor) : base(mesa, cor)
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
            return "B";
        }
    }
}
