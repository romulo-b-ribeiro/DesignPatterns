using _07_Observer.Entities.NotaFiscal;
using _07_Observer.Services;
using System;
using System.Collections.Generic;

namespace _07_Observer
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
                .AdicionarItens(listaDeItens);

            // Design Pattern: Observer
            notaFiscalBuilder.AdicionarAcao(new EnviarPorEmail());
            notaFiscalBuilder.AdicionarAcao(new EnviarPorSms());
            notaFiscalBuilder.AdicionarAcao(new NotaFiscalDAO());
            notaFiscalBuilder.AdicionarAcao(new MultiplicarPorFator(5M));

            var notaFiscal = notaFiscalBuilder.GerarNota();
        }
    }
}
