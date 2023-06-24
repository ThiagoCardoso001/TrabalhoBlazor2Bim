namespace CadastroProdutoApi.Models
{
    public class ProdutoRecord : BaseModel
    {
        public ProdutoRecord() { }

        public ProdutoRecord(Produto Produto) 
        {
            this.Produto = Produto;
        }

        public string? IdProduto
        {
            get => Produto == null ? idProduto : Produto.Id;
            set => idProduto = value;
        }

        public DateTime Data { get; set; }

        public string Descricao { get; set; } = "";

        private string? idProduto = null;
        private Produto? Produto;
    }
}
