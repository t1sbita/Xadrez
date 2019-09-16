using Erros;

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

        public Peca PosicaoPeca(Posicao posicao)
        {
            return Pecas[posicao.Linha, posicao.Coluna];
        }

        public Peca IniciaPecas(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }

        public void ColocarPeca(Peca peca, Posicao posicao)
        {
            if (ExistePeca(posicao))
            {
                throw new Exceptions("Já existe uma peça nesta posição!");
            }
            Pecas[posicao.Linha, posicao.Coluna] = peca;
            peca.Posicao = posicao;
        }

        public bool ExistePeca(Posicao posicao)
        {
            ValidarPosicao(posicao);
            return PosicaoPeca(posicao) != null;
        }

        public bool PosicaoValida(Posicao posicao)
        {
            if(posicao.Linha < 0 || posicao.Linha >= Linhas || posicao.Coluna < 0 || posicao.Coluna >= Colunas)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
        public void ValidarPosicao(Posicao posicao)
        {
            if (!PosicaoValida(posicao))
            {
                throw new Exceptions("Posição Inválida!");
            }
        }
    }

}
