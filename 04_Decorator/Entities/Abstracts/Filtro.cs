using System.Collections.Generic;

namespace _04_Decorator.Entities.Abstracts
{
    public abstract class Filtro
    {
        public Filtro OutroFiltro { get; set; }

        public Filtro(Filtro outroFiltro)
        {
            OutroFiltro = outroFiltro;
        }

        public Filtro()
        {
            OutroFiltro = null;
        }

        public abstract IList<Conta> Filtrar(IList<Conta> contas);

        protected IList<Conta> FiltrarProximo(IList<Conta> contas)
        {
            if (OutroFiltro is null) return new List<Conta>();
            return OutroFiltro.Filtrar(contas);
        }
    }
}
