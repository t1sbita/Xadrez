using System;
using Tabuleiro;
using Jogabilidade;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Mesa mesa = new Mesa(8, 8);

            mesa.ColocarPeca(new Torre(mesa, Cor.Preta), new Posicao(0, 0));
            mesa.ColocarPeca(new Cavalo(mesa, Cor.Preta), new Posicao(0, 1));
            mesa.ColocarPeca(new Bispo(mesa, Cor.Preta), new Posicao(0, 2));
            mesa.ColocarPeca(new Rainha(mesa, Cor.Preta), new Posicao(0, 3));
            mesa.ColocarPeca(new Rei(mesa, Cor.Preta), new Posicao(0, 4));
            mesa.ColocarPeca(new Bispo(mesa, Cor.Preta), new Posicao(0, 5));
            mesa.ColocarPeca(new Cavalo(mesa, Cor.Preta), new Posicao(0, 6));
            mesa.ColocarPeca(new Torre(mesa, Cor.Preta), new Posicao(0, 7));
            mesa.ColocarPeca(new Peao(mesa, Cor.Preta), new Posicao(1, 0));
            mesa.ColocarPeca(new Peao(mesa, Cor.Preta), new Posicao(1, 1));
            mesa.ColocarPeca(new Peao(mesa, Cor.Preta), new Posicao(1, 2));
            mesa.ColocarPeca(new Peao(mesa, Cor.Preta), new Posicao(1, 3));
            mesa.ColocarPeca(new Peao(mesa, Cor.Preta), new Posicao(1, 4));
            mesa.ColocarPeca(new Peao(mesa, Cor.Preta), new Posicao(1, 5));
            mesa.ColocarPeca(new Peao(mesa, Cor.Preta), new Posicao(1, 6));
            mesa.ColocarPeca(new Peao(mesa, Cor.Preta), new Posicao(1, 7));


            mesa.ColocarPeca(new Torre(mesa, Cor.Amarela), new Posicao(7, 0));
            mesa.ColocarPeca(new Cavalo(mesa, Cor.Amarela), new Posicao(7, 1));
            mesa.ColocarPeca(new Bispo(mesa, Cor.Amarela), new Posicao(7, 2));
            mesa.ColocarPeca(new Rei(mesa, Cor.Amarela), new Posicao(7, 3));
            mesa.ColocarPeca(new Rainha(mesa, Cor.Amarela), new Posicao(7, 4));
            mesa.ColocarPeca(new Bispo(mesa, Cor.Amarela), new Posicao(7, 5));
            mesa.ColocarPeca(new Cavalo(mesa, Cor.Amarela), new Posicao(7, 6));
            mesa.ColocarPeca(new Torre(mesa, Cor.Amarela), new Posicao(7, 7));
            mesa.ColocarPeca(new Peao(mesa, Cor.Amarela), new Posicao(6, 0));
            mesa.ColocarPeca(new Peao(mesa, Cor.Amarela), new Posicao(6, 1));
            mesa.ColocarPeca(new Peao(mesa, Cor.Amarela), new Posicao(6, 2));
            mesa.ColocarPeca(new Peao(mesa, Cor.Amarela), new Posicao(6, 3));
            mesa.ColocarPeca(new Peao(mesa, Cor.Amarela), new Posicao(6, 4));
            mesa.ColocarPeca(new Peao(mesa, Cor.Amarela), new Posicao(6, 5));
            mesa.ColocarPeca(new Peao(mesa, Cor.Amarela), new Posicao(6, 6));
            mesa.ColocarPeca(new Peao(mesa, Cor.Amarela), new Posicao(6, 7));


            Tela.ImprimirTabuleiro(mesa);

            Console.ReadLine();

        }
    }
}
