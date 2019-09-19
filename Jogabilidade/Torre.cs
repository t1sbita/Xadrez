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

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] possibilidades = new bool[Mesa.Linhas, Mesa.Colunas];

            Posicao posicao = new Posicao(0, 0);

            //acima
            posicao.DefinirPosicaoFutura(Posicao.Linha - 1, Posicao.Coluna);

            while(Mesa.PosicaoValida(posicao) && PodeMover(posicao))
            {
                possibilidades[posicao.Linha, posicao.Coluna] = true;

                if(Mesa.PosicaoPeca(posicao) != null && Mesa.PosicaoPeca(posicao).Cor != Cor)
                {
                    break;
                }

                posicao.Linha -- ;
            }

            //abaixo
            posicao.DefinirPosicaoFutura(Posicao.Linha + 1, Posicao.Coluna);

            while (Mesa.PosicaoValida(posicao) && PodeMover(posicao))
            {
                possibilidades[posicao.Linha, posicao.Coluna] = true;

                if (Mesa.PosicaoPeca(posicao) != null && Mesa.PosicaoPeca(posicao).Cor != Cor)
                {
                    break;
                }

                posicao.Linha++;
            }

            //direita
            posicao.DefinirPosicaoFutura(Posicao.Linha, Posicao.Coluna + 1);

            while (Mesa.PosicaoValida(posicao) && PodeMover(posicao))
            {
                possibilidades[posicao.Linha, posicao.Coluna] = true;

                if (Mesa.PosicaoPeca(posicao) != null && Mesa.PosicaoPeca(posicao).Cor != Cor)
                {
                    break;
                }

                posicao.Coluna++;
            }

            //esquerda
            posicao.DefinirPosicaoFutura(Posicao.Linha, Posicao.Coluna - 1);

            while (Mesa.PosicaoValida(posicao) && PodeMover(posicao))
            {
                possibilidades[posicao.Linha, posicao.Coluna] = true;

                if (Mesa.PosicaoPeca(posicao) != null && Mesa.PosicaoPeca(posicao).Cor != Cor)
                {
                    break;
                }

                posicao.Coluna--;
            }

            return possibilidades;
        }
    }
}
