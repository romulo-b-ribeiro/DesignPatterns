namespace _05_State.Entities.Orcamento
{
    public class Item
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }

        public Item(string nome, decimal valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}
