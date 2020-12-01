namespace _01_Strategy.Entities
{
    public class Orcamento
    {
        public decimal Valor { get; private set; }

        public Orcamento(decimal valor)
        {
            Valor = valor;
        }
    }
}
