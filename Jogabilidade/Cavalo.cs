using System;
using Tabuleiro;

namespace Jogabilidade
{
    class Cavalo : Peca
    {
        public Cavalo(Mesa mesa, Cor cor) : base(mesa, cor)
        {

        }

        public override string ToString()
        {
            return "C";
        }
    }
}
