using _04_Decorator.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_Decorator.Entities
{
    public class FiltroSaldoMaiorQue500Mil : Filtro
    {
        public FiltroSaldoMaiorQue500Mil(Filtro filtro) : base(filtro) { }
        public FiltroSaldoMaiorQue500Mil() : base() { }

        public override IList<Conta> Filtrar(IList<Conta> contas)
        {
            var contasFiltradas = contas.Where(c => c.Saldo < 500_000M).ToList();
            contasFiltradas.AddRange(FiltrarProximo(contas));
            return contasFiltradas;
        }
    }
}
