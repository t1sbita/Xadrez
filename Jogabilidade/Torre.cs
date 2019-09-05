using System;
using Tabuleiro;

namespace Jogabilidade
{
    class Torre : Peca
    {
        public Torre(Mesa mesa, Cor cor) : base(mesa, cor)
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}
