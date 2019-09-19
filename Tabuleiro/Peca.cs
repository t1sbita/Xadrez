

namespace Tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Mesa Mesa { get; protected set; }
        public Cor Cor { get; protected set; }
        public int QtdeMovimento { get; protected set; }


        public Peca(Mesa mesa, Cor cor)
        {
            Posicao = null;
            Cor = cor;
            Mesa = mesa;
            QtdeMovimento = 0;

        }

        public void IncrementarMovimento()
        {
            QtdeMovimento++;
        }

        public abstract bool[,] MovimentosPossiveis();

        public bool PodeMover(Posicao posicao)
        {
            Peca peca = Mesa.PosicaoPeca(posicao);
            return peca == null || peca.Cor != Cor;
        }
    }   
}
