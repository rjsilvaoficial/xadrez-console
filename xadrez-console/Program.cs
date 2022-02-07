using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();
                
                while (!partida.terminada)
                {
                    try
                    {


                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab);

                        Console.WriteLine($"Turno atual: {partida.turno}");
                        Console.WriteLine();
                        Console.WriteLine($"Aguardando jogada: {partida.jogadorAtual}");
                        Console.WriteLine();

                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoOrigem(origem);

                        //trecho destinado a "pintar" as posições passíveis de movimento
                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);


                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDestino(origem, destino);
                        partida.realizaJogada(origem, destino);
                    }
                    catch(TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
                

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            
        }
    }
}
