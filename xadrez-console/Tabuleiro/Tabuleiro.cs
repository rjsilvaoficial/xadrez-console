using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    public class Tabuleiro
    {
        public int Linhas { get; set; }

        public int Colunas { get; set; }

        private Peca[,] pecas; //aqui estão todas as peças do tabuleiro

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
    }
}
