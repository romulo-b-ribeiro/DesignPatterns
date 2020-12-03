using _03_TemplateMethod.Entities;
using System.Collections.Generic;

namespace _03_TemplateMethod.Templates
{
    public abstract class Relatorio
    {
        protected abstract void Cabecalho();
        protected abstract void Rodape();
        protected abstract void Corpo(IList<Conta> contas);

        public void Imprimir(IList<Conta> contas)
        {
            Cabecalho();
            Corpo(contas);
            Rodape();
        }
    }
}
