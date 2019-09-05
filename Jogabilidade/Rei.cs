using System;
using Tabuleiro;

namespace Jogabilidade
{
    class Rei : Peca
    {
        public Rei(Mesa mesa, Cor cor) : base(mesa, cor)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
