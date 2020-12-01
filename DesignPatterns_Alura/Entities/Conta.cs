namespace _01_Strategy.Entities
{
    public class Conta
    {
        public decimal Saldo { get; private set; }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }
    }
}
