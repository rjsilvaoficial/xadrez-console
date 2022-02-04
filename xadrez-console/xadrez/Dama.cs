using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{
    public class  Dama : Peca
    {
        public Dama(Tabuleiro tab, Cor cor) : base(tab, cor) { }

        public override bool[,] movimentosPossiveis()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "D";
        }
    }
}
