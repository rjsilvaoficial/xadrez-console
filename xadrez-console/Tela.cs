using System;
using System.Collections.Generic;
using tabuleiro;

namespace xadrez
{
    public class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab) //aqui geramos o tabuleiro na tela
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++)
                {                   
                    imprimirPeca(tab.peca(i, j));                                        
                }
                Console.WriteLine();
            }
            Console.Write(" ");

            //Console.WriteLine("  A B C D E F G H");

            /*
             * Seria muito mais prático (e performático) eu incluir na linha acima apenas um WriteLine("  A B C D E F G H")
             * Entretanto, apesar de ser uma solução fácil, me pareceu preguiçosa!
             * O for abaixo entretanto, me forçou a dar uma espiada na tabela ASCII
             * Além de me exigir alguma lógica, mesmo que rudimentar, algo que acho importante treinar
             */

            for (int k = 65; k < tab.colunas + 65; k++)
            {
                Console.Write($" {(char)k}");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void imprimirPartida(PartidaDeXadrez partida)
        {
            imprimirTabuleiro(partida.tab);
            Console.WriteLine();
            imprimirPecasCapturadas(partida);
            Console.WriteLine($"Turno atual: {partida.turno}");
            Console.WriteLine();
            Console.WriteLine($"Aguardando jogada: {partida.jogadorAtual}");
            Console.WriteLine();
        }

        public static void imprimirPecasCapturadas(PartidaDeXadrez partida)
        {
            Console.WriteLine("Peças capturadas: ");
            Console.WriteLine();

            Console.Write("Brancas: ");
            imprimirConjunto(partida.pecasCapturadas(Cor.Branca));
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Pretas: ");
            imprimirConjunto(partida.pecasCapturadas(Cor.Preta));
            Console.WriteLine();
            Console.WriteLine();

        }

        public static void imprimirConjunto(HashSet<Peca> conjunto)
        {
            Console.Write("[");
            foreach(Peca peca in conjunto)
            {
                Console.Write($"{ peca} ");
            }
            Console.Write("]");

        }

        //Esta sobrecarga gera em tela a marcação visual das posições possíveis para mover uma peça
        public static void imprimirTabuleiro(Tabuleiro tab, bool[,] posicoesPossiveis) 
        {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (posicoesPossiveis[i,j])
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor = fundoOriginal;
                    }
                    imprimirPeca(tab.peca(i, j));
                    Console.BackgroundColor = fundoOriginal;
                }
                Console.WriteLine();
            }
            Console.Write(" ");

            for (int k = 65; k < tab.colunas + 65; k++)
            {
                Console.Write($" {(char)k}");
            }
            Console.WriteLine();
            Console.BackgroundColor = fundoOriginal;
            Console.WriteLine();

        }


        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }


        public static void imprimirPeca(Peca peca)
        {
            if (peca == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (peca.cor == Cor.Branca)
                {
                    Console.Write(peca);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }
        }
    }
}
