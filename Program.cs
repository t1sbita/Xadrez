using System;
using Tabuleiro;
using Jogabilidade;
using Erros;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Partida iniciar = new Partida();

                while (!iniciar.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(iniciar.Mesa);

                    Console.WriteLine("Origem");
                    Posicao origem = Tela.LeituraPosicao();
                    Console.WriteLine("Destino");
                    Posicao destino = Tela.LeituraPosicao();
                    iniciar.Movimentacao(origem, destino);
                }
               
                

                
            }
            catch(Exceptions excecoes)
            {
                Console.WriteLine(excecoes.Message);
            }
            Console.ReadLine();

        }
    }
}
