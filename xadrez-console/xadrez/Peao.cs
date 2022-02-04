using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{
    public class Peao : Peca
    {
        public Peao(Tabuleiro tab, Cor cor) :base(tab, cor) { }

        public override bool[,] movimentosPossiveis()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "P";
        }
    }
}
