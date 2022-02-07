using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{
    public class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor) { }

        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] posicoesDisponiveis = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            //acima

            pos.definirValores(posicao.linha - 1, posicao.coluna);
            while(tab.posicaoValida(pos) && podeMover(pos))
            {
                posicoesDisponiveis[pos.linha, pos.coluna] = true;
                if(tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.linha--;
            }

            //abaixo

            pos.definirValores(posicao.linha + 1, posicao.coluna);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                posicoesDisponiveis[pos.linha, pos.coluna] = true;
                if(tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.linha++;
            }

            //esquerda

            pos.definirValores(posicao.linha, posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                posicoesDisponiveis[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.coluna--;

            }

            //direita

            pos.definirValores(posicao.linha, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                posicoesDisponiveis[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.coluna++;

            }

            return posicoesDisponiveis;

        }


        public override string ToString()
        {
            return "T";
        }
    }
}
