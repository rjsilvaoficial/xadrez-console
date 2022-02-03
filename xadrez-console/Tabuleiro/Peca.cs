using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace tabuleiro
{
    public class Peca
    {
        public Posicao posicao { get; set; }

        public Cor cor { get; protected set; }

        public int qtdMovimentos { get; protected set; }

        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            this.posicao = null; //Posição inicia nula pois quem gerencia a posição é o tabuleiro
            this.tab = tabuleiro;
            this.cor = cor;
            this.qtdMovimentos = 0;

        }

        public void incrementarQteMovimentos()
        {
            qtdMovimentos++;
            
        }
    }
}
