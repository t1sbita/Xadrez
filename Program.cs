using System;
using Tabuleiro;
namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Mesa mesa = new Mesa(8, 8);

            Tela.ImprimirTabuleiro(mesa);

            Console.WriteLine();

        }
    }
}
