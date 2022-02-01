using System;
using tabuleiro;
using xadrez;
using xadrez_console.xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {

            PosicaoXadrez pos = new PosicaoXadrez('a', 1);
            Console.WriteLine($"{pos}");
            Console.WriteLine($"{pos.toPosicao()}");
            //Tabuleiro tab = new Tabuleiro(8, 8);

            //tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0)); //auto-ref confirmada

            //Tela.ImprimirTabuleiro(tab);
        }
    }
}
