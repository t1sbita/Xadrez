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

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] possibilidades = new bool[Mesa.Linhas, Mesa.Colunas];

            Posicao posicao = new Posicao(0, 0);

            //acima
            posicao.DefinirPosicaoFutura(Posicao.Linha - 1, Posicao.Coluna);
            if(Mesa.PosicaoValida(posicao) && PodeMover(posicao))
            {
                possibilidades[posicao.Linha, posicao.Coluna] = true;
            }

            //abaixo
            posicao.DefinirPosicaoFutura(Posicao.Linha + 1, Posicao.Coluna);
            if (Mesa.PosicaoValida(posicao) && PodeMover(posicao))
            {
                possibilidades[posicao.Linha, posicao.Coluna] = true;
            }

            //esquerda
            posicao.DefinirPosicaoFutura(Posicao.Linha, Posicao.Coluna - 1);
            if (Mesa.PosicaoValida(posicao) && PodeMover(posicao))
            {
                possibilidades[posicao.Linha, posicao.Coluna] = true;
            }

            //direita
            posicao.DefinirPosicaoFutura(Posicao.Linha, Posicao.Coluna + 1);
            if (Mesa.PosicaoValida(posicao) && PodeMover(posicao))
            {
                possibilidades[posicao.Linha, posicao.Coluna] = true;
            }

            //Noroeste
            posicao.DefinirPosicaoFutura(Posicao.Linha - 1, Posicao.Coluna - 1);
            if (Mesa.PosicaoValida(posicao) && PodeMover(posicao))
            {
                possibilidades[posicao.Linha, posicao.Coluna] = true;
            }

            //Nordeste
            posicao.DefinirPosicaoFutura(Posicao.Linha - 1, Posicao.Coluna + 1);
            if (Mesa.PosicaoValida(posicao) && PodeMover(posicao))
            {
                possibilidades[posicao.Linha, posicao.Coluna] = true;
            }

            //Sudoeste
            posicao.DefinirPosicaoFutura(Posicao.Linha + 1, Posicao.Coluna - 1);
            if (Mesa.PosicaoValida(posicao) && PodeMover(posicao))
            {
                possibilidades[posicao.Linha, posicao.Coluna] = true;
            }

            //Sudeste
            posicao.DefinirPosicaoFutura(Posicao.Linha + 1, Posicao.Coluna + 1);
            if (Mesa.PosicaoValida(posicao) && PodeMover(posicao))
            {
                possibilidades[posicao.Linha, posicao.Coluna] = true;
            }

            return possibilidades;
        }
    }
}
