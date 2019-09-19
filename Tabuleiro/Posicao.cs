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

        public Posicao(char coluna, int linha)
        {
            Coluna = coluna - 'a';
            Linha = 8 - linha;

        }

        
        public void DefinirPosicaoFutura(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }
        
        public override string ToString()
        {
            return Linha + ", " + Coluna;
        }
    }
}
