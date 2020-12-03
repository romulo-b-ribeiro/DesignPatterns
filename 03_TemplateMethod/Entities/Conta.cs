namespace _03_TemplateMethod.Entities
{
    public class Conta
    {
        public string Titular { get; private set; }
        public string Numero { get; private set; }
        public string Agencia { get; private set; }
        public decimal Saldo { get; private set; }

        public Conta(string titular, decimal saldo)
        {
            Titular = titular;
            Saldo = saldo;
        }
    }
}
