using System;
using tabuleiro;
using xadrez_console.xadrez;

namespace xadrez_console
{
    public class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for(int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for(int j = 0; j < tab.colunas; j++)
                {
                    if(tab.peca(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        imprimirPeca(tab.peca(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            //Console.Write(" ");

            Console.WriteLine("  A B C D E F G H");

            /*
             * Seria muito mais prático eu incluir na linha acima apenas um WriteLine("  A B C D E F G H")
             * Entretanto, apesar de ser uma solução fácil, me pareceu preguiçosa!
             * O for abaixo porém, me forçou a dar uma espiada na tabela ASCII
             * Além de me exigir alguma lógica, mesmo que rudimentar
             */
            /*
            for (int k = 65; k < tab.colunas + 65; k++)
            {
                Console.Write($" {(char)k}");
            }
            */
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
