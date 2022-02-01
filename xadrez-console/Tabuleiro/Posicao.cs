
namespace tabuleiro
{
    public class Posicao
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Posicao(int linha, int coluna)
        {
            Linha = linha;
            Coluna = Coluna;
        }

        
        //Esse ToString() possivelmente será descartado futuramente
        public override string ToString()
        {
            return Linha + "," + Coluna;
        }
        
    }
}
