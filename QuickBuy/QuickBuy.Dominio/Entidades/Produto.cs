namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();
            if (Preco < 0)
                AdicionarMensagem("Preço deve ser maior que 0");
            if (string.IsNullOrEmpty(Descricao))
                AdicionarMensagem("Descrição não pode estar vazia");
        }
    }
}