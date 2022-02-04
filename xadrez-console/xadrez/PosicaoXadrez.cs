using tabuleiro;

namespace xadrez
{
    public class PosicaoXadrez
    {
        public char coluna { get; set; }

        public int linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        public Posicao toPosicao() //converte posição da matriz para posicao da interface de usuário
        {
            //a lógica aqui compreende a quantidade de linhas total do tabuleiro - a linha atual
            //seguida da coluna - o caractere 'a' (que vale um int), isso permite a movimentação adequada
            return new Posicao(8 - linha, coluna - 'a');
        }

        public override string ToString()
        {
            return "" + coluna + linha;//essa sintaxe é gambiarra pois obriga a conversão para string
        }
    }
}
