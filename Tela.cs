using Tabuleiro;
using System;

namespace Xadrez
{
    class Tela
    {
        public static void ImprimirTabuleiro(Mesa mesa)
        {
            for (int i = 0; i < mesa.Linhas; i++)
            {
                for(int j = 0; j < mesa.Colunas; j++)
                {
                    if(mesa.IniciaPecas(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(mesa.IniciaPecas(i, j) + " ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
