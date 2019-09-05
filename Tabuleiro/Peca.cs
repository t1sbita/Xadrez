

namespace Tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Mesa Mesa { get; protected set; }
        public Cor Cor { get; protected set; }
        public int QtdeMovimento {get; protected set;}
        

        public Peca(Mesa mesa, Cor cor)
        {
            Posicao = null;
            Cor = cor;
            Mesa = mesa;
            QtdeMovimento = 0;

        }
    }
}
