using System;
using System.Collections.Generic;
using System.Text;

namespace Tabuleiro
{
    class Posicao
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Posicao()
        {

        }
        public Posicao(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }

        public void EntradaPosicao(char coluna, int linha)
        {
            Linha = 8 - linha;
            Coluna = coluna - 'a';
        }

        public override string ToString()
        {
            return Linha + ", " + Coluna;
        }
    }
}
