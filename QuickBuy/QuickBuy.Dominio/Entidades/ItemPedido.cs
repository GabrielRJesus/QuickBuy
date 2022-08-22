namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoID { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();
            if (Quantidade < 1)
                AdicionarMensagem("Quantidade deve ser maior que um");
        }
    }
}