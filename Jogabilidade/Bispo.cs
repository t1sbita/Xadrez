using System;
using Tabuleiro;

namespace Jogabilidade
{
    class Bispo : Peca
    {
        public Bispo(Mesa mesa, Cor cor) : base(mesa, cor)
        {

        }

        public override string ToString()
        {
            return "B";
        }
    }
}
