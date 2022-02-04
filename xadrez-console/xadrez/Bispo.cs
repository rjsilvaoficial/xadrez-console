using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{
    public class Bispo :  Peca
    {
        public Bispo(Tabuleiro tab, Cor cor) : base(tab, cor) { }

        public override bool[,] movimentosPossiveis()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "B";
        }
    }
}
