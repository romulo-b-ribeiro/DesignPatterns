namespace _06_Builder.Entities.NotaFiscal
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