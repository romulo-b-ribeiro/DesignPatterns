namespace _04_Decorator.Entities
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
