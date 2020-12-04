namespace _07_Observer.Entities.NotaFiscal
{
    public class ItemDaNota
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }

        public ItemDaNota(string nome, decimal valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}