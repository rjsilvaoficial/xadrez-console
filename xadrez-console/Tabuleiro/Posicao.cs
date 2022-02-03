
namespace tabuleiro //ok
{
    public class Posicao
    {
        public int linha { get; set; }
        public int coluna { get; set; }

        public Posicao(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        
        //Esse ToString() possivelmente será descartado futuramente
        public override string ToString()
        {
            return linha + "," + coluna;
        }
        
    }
}
