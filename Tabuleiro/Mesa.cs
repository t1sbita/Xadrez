

namespace Tabuleiro
{
    class Mesa
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }

        private Peca[,] Pecas;

        public Mesa(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[linhas, colunas];
        }

        public Peca PosicaoPecas(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }
    }   
}
