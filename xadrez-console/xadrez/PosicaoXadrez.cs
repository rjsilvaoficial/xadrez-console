using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez_console.xadrez
{
    public class PosicaoXadrez
    {
        public char Coluna { get; set; }

        public int Linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }

        public Posicao toPosicao()
        {
            return new Posicao(8 - Linha, Coluna - 'a');
        }

        public override string ToString()
        {
            return "" + Coluna + Linha;
        }
    }
}
