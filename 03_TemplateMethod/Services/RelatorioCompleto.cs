using _03_TemplateMethod.Entities;
using _03_TemplateMethod.Templates;
using System;
using System.Collections.Generic;

namespace _03_TemplateMethod.Services
{
    public class RelatorioCompleto : Relatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Banco XYZ");
            Console.WriteLine("Avenida Paulista, 1234");
            Console.WriteLine("(11) 1234-5678");
        }

        protected override void Corpo(IList<Conta> contas)
        {
            foreach (var conta in contas)
            {
                Console.WriteLine(conta.Titular + " - " + conta.Agencia + " - " + conta.Numero + " - " + conta.Saldo);
            }
        }

        protected override void Rodape()
        {
            Console.WriteLine("banco@xyz.com.br");
            Console.WriteLine(DateTime.Now);
        }
    }
}
