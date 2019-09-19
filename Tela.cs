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
                
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Write(8 - i + " ");
                Console.BackgroundColor = background;
                for(int j = 0; j < mesa.Colunas; j++)
                {
                    ImprimePecas(mesa.IniciaPecas(i, j));
                    
                }
                Console.WriteLine();
            }
            
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("   a  b  c  d  e  f  g  h");
            Console.BackgroundColor = background;
        }

        public static void ImprimirPossibilidades(Mesa mesa, bool[,] possiveisMovimentos)
        {
            ConsoleColor background = Console.BackgroundColor;

            for (int i = 0; i < mesa.Linhas; i++)
            {

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Write(8 - i + " ");
                Console.BackgroundColor = background;
                for (int j = 0; j < mesa.Colunas; j++)
                {
                    if (possiveisMovimentos[i, j])
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                    }
                    ImprimePecas(mesa.IniciaPecas(i, j));
                    Console.BackgroundColor = background;

                }
                Console.WriteLine();
            }

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("   a  b  c  d  e  f  g  h");
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
            if (peca == null)
            {
                Console.Write(" - ");

            }
            else
            {
                Console.Write(" ");
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
                Console.Write(" ");
            }
        }

    }
}
