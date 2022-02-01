using System;
using tabuleiro;

namespace xadrez_console
{
    public class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for(int i = 0; i < tab.Linhas; i++)
            {
                Console.Write($"{8 - i} ");
                for(int j = 0; j < tab.Colunas; j++)
                {
                    if(tab.peca(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Tela.imprimirPeca(tab.peca(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.Write(" ");

            /*
             * Seria muito mais prático eu incluir na linha acima apenas um WriteLine("  A B C D E F G H")
             * Entretanto, apesar de ser uma solução fácil, me pareceu preguiçosa!
             * O for abaixo porém, me forçou a dar uma espiada na tabela ASCII
             * Além de me exigir alguma lógica, mesmo que rudimentar
             */

            for (int k = 65; k < tab.Colunas + 65; k++)
            {
                Console.Write($" {(char)k}");
            }
        }
        
        public static void imprimirPeca(Peca peca)
        {
            if(peca.cor == Cor.Branca)
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
        }
    }
}
