namespace tabuleiro
{
    public abstract class Peca
    {
        //recebe uma intância de posição contendo o local atual da peça com base em ints
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

        public bool existeMovimentoPossiveis()
        {
            var mat = movimentosPossiveis();
            for(int i = 0; i < tab.linhas; i++)
            {
                for(int j = 0; j < tab.colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;

        }

        public bool podeMoverPara(Posicao pos)
        {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }

        /*Este método registrará todas as casas do tabuleiro
         *Avaliará se é possível ou não mover para a casa em questão (a configuração de critério será por classe) 
         *É abstrato pois a implementação é responsabilidade de quem herda da classe
         */
        public abstract bool[,] movimentosPossiveis();

    }
}
