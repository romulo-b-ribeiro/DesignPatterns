using _02_ChainOfResponsibilty.Entities;

namespace _02_ChainOfResponsibilty
{
    class CalculadorDeDescontosSemCoR
    {
        public decimal Calcular(Orcamento orcamento)
        {
            // verifica primeira regra de possível desconto
            if (orcamento.Itens.Count > 5)
            {
                return orcamento.Valor * 0.1M;
            }
            // verifica segunda regra de possível desconto
            else if (orcamento.Valor > 500.0M)
            {
                return orcamento.Valor * 0.07M;
            }
            // verifica terceira, quarta, quinta regra de possível desconto ...
            // um monte de ifs daqui pra baixo
            return 0;
        }
    }
}
