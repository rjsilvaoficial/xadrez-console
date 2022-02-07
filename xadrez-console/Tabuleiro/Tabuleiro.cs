using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace tabuleiro
{
    public class Tabuleiro
    {
        public int linhas { get; set; }

        public int colunas { get; set; }

        private Peca[,] pecas; //aqui estão todas as peças do tabuleiro e as respectivas posições portanto

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        
        //Este método visa retornar uma peça com base em seus índices na matriz
        public Peca peca (int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
        
        //Este método visa retornar uma peça com base em sua posição
        //É uma variação/sobrecarga do método anterior
        public Peca peca (Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }

        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }

        //atribua peça e posição destas a peças[,] e pos a p.posição
        //este método é usado (até então) apenas na instanciação das peças no início da partida
        public void colocarPeca(Peca p, Posicao pos) 
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nesta posição!");
            }

            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

        public Peca retirarPeca(Posicao pos)
        {
            if (peca(pos) == null)
            {
                return null;
            }
            else
            {
                Peca aux = peca(pos); //busca peça na pos referida
                aux.posicao = null;
                pecas[pos.linha, pos.coluna] = null;
                return aux;
            }
        }

        public bool posicaoValida(Posicao pos)
        {
            if(pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas)
            {
                return false;
            }
            return true;
        }

        public void validarPosicao(Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida!");
            }
        }




    }
}
