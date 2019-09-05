using System;
using Tabuleiro;

namespace Jogabilidade
{
    class Peao : Peca
    {
        public Peao(Mesa mesa, Cor cor) : base(mesa, cor)
        {

        }

        public override string ToString()
        {
            return "P";
        }
    }
}
