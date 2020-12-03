using _04_Decorator.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_Decorator.Entities
{
    public class FiltroSaldoMenorQue100 : Filtro
    {
        public FiltroSaldoMenorQue100(Filtro filtro) : base(filtro) { }
        public FiltroSaldoMenorQue100() : base() { }

        public override IList<Conta> Filtrar(IList<Conta> contas)
        {
            var contasFiltradas = contas.Where(c => c.Saldo < 100M).ToList();
            contasFiltradas.AddRange(FiltrarProximo(contas));
            return contasFiltradas;
        }
    }
}
