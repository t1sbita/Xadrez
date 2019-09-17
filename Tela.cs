using Tabuleiro;
using System;

namespace Xadrez
{
    class Tela
    {
        public static void ImprimirTabuleiro(Mesa mesa)
        {
            ConsoleColor background = Console.BackgroundColor;

            for (int i = 0; i < mesa.Linhas; i++)
            {
                
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.Write(8 - i + " ");
                Console.BackgroundColor = background;
                for(int j = 0; j < mesa.Colunas; j++)
                {
                    if(mesa.IniciaPecas(i, j) == null)
                    {
                        Console.Write(" -");
                    }
                    else
                    {
                        Console.Write(" ");
                        ImprimePecas(mesa.IniciaPecas(i, j));
                        
                    }
                    
                }
                Console.WriteLine();
            }
            
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("   a b c d e f g h");
            Console.BackgroundColor = background;
        }

        public static Posicao LeituraPosicao()
        {
            string posicao = Console.ReadLine();
            char coluna = char.Parse(posicao[0] + "");
            int linha = int.Parse(posicao[1] + "");

            return new Posicao(coluna, linha);
        }

        public static void ImprimePecas(Peca peca)
        {
            if (peca.Cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor color = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(peca);
                Console.ForegroundColor = color;
            }
        }

    }
}
