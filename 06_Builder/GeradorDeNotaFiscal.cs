using _06_Builder.Entities.NotaFiscal;
using _06_Builder.Services;
using System;
using System.Collections.Generic;

namespace _06_Builder
{
    public class GeradorDeNotaFiscal
    {
        public void Executar()
        {
            var listaDeItens = new List<ItemDaNota>
            {
                new ItemDaNota("item1", 25M),
                new ItemDaNota("item2", 30M)
            };

            var notaFiscalBuilder = new NotaFiscalBuilder();
            notaFiscalBuilder
                .AdicionarEmpresa("Empresa XYZ")
                .AdicionarCnpj("12345678901231")
                .AdicionarData(DateTime.Today.AddDays(7))
                .AdicionarObservacoes("Sem observações")
                .AdicionarItens(listaDeItens); // Method chaining

            var notaFiscal = notaFiscalBuilder.GerarNota();
        }
    }
}
