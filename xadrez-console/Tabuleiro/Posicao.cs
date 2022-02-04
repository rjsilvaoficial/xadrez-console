namespace tabuleiro
{
    public class Posicao  //essa classe representa a posição atual de uma peça
    {
        public int linha { get; set; }
        public int coluna { get; set; }

        public Posicao(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        public void definirValores(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }


        //Esse ToString() possivelmente será descartado futuramente

        //impressão de linha e coluna baseados em inteiros (padrão com base nas props da classe)
        public override string ToString() 
        {
            return linha + "," + coluna;
        }
        
    }
}
