using _04_Decorator.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Decorator.Entities
{
    public class FiltroAberturaNoMesCorrente : Filtro
    {
        public FiltroAberturaNoMesCorrente(Filtro filtro) : base(filtro) { }
        public FiltroAberturaNoMesCorrente() : base() { }

        public override IList<Conta> Filtrar(IList<Conta> contas)
        {
            var contasFiltradas = contas.Where(c => {
                return c.DataAbertura.Month == DateTime.Today.Month &&
                       c.DataAbertura.Year == DateTime.Today.Year;
                }).ToList();
            contasFiltradas.AddRange(FiltrarProximo(contas));
            return contasFiltradas;
        }
    }
}
