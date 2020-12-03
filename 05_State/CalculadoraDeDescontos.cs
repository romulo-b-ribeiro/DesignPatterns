using _05_State.Entities.Orcamento;
using System;

namespace _05_State
{
    public class CalculadoraDeDescontos
    {
        public void Executar()
        {
            var reforma = new Orcamento(500);
            reforma.AplicarDescontoExtra();
            Console.WriteLine(reforma.Valor); // imprime 500 - 5%

            reforma.Aprovar();
            reforma.AplicarDescontoExtra();
            Console.WriteLine(reforma.Valor); // imprime (500 - 5%) - 2%

            reforma.Finalizar();
            //reforma.Reprovar() -> lança Exceção
            //reforma.AplicarDescontoExtra() -> lança Exceção
        }
    }
}
