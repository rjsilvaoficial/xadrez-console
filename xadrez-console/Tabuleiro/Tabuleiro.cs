using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    public class Tabuleiro
    {
        public int Linhas { get; set; }

        public int Colunas { get; set; }

        private Peca[,] pecas; //aqui estão todas as peças do tabuleiro e as respectivas posições portanto

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca peca (int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        public void colocarPeca(Peca p, Posicao pos) //atribua peça e posição destas à: peças[] e p.posição
        {
            pecas[pos.Linha, pos.Coluna] = p;
            p.posicao = pos;
        }


    }
}
