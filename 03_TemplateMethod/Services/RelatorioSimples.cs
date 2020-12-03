using _03_TemplateMethod.Entities;
using _03_TemplateMethod.Templates;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03_TemplateMethod.Services
{
    public class RelatorioSimples : Relatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Banco XYZ");
        }

        protected override void Corpo(IList<Conta> contas)
        {
            foreach (var conta in contas)
            {
                Console.WriteLine(conta.Titular + " - " + conta.Saldo);
            }
        }

        protected override void Rodape()
        {
            Console.WriteLine("(11) 1234-5678");
        }
    }
}
