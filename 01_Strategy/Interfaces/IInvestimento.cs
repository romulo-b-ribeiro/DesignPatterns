using _01_Strategy.Entities;

namespace _01_Strategy.Interfaces
{
    interface IInvestimento
    {
        decimal CalcularRetorno(Conta investimento);
    }
}
