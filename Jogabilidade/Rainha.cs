using System;
using Tabuleiro;

namespace Jogabilidade
{
    class Rainha : Peca
    {
        public Rainha(Mesa mesa, Cor cor) : base(mesa, cor)
        {

        }

        public override string ToString()
        {
            return "Q";
        }
    }
}
