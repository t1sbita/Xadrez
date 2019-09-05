

namespace Tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdeMovimento {get; protected set;}
        public Mesa Mesa { get; protected set; }

        public Peca(Posicao posicao, Cor cor, Mesa mesa)
        {
            Posicao = posicao;
            Cor = cor;
            Mesa = mesa;
            QtdeMovimento = 0;

        }
    }
}
