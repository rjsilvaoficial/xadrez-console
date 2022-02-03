using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez_console.xadrez
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
            return new Posicao(8 - linha, coluna - 'a');
        }

        public override string ToString()
        {
            return "" + coluna + linha;
        }
    }
}
