using System;
using System.Collections.Generic;

namespace _06_Builder.Entities.NotaFiscal
{
    public class NotaFiscal
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataDeEmissao { get; set; }
        public decimal ValorBruto { get; set; }
        public decimal Impostos { get; set; }
        public IList<ItemDaNota> Itens { get; set; }
        public string Observacoes { get; set; }

        public NotaFiscal(string razaoSocial, string cnpj, decimal valorBruto, decimal impostos, IList<ItemDaNota> itens, string observacoes, DateTime? dataDeEmissao)
        {
            RazaoSocial = razaoSocial;
            Cnpj = cnpj;
            DataDeEmissao = dataDeEmissao is null ? DateTime.Now : (DateTime)dataDeEmissao;
            ValorBruto = valorBruto;
            Impostos = impostos;
            Itens = itens;
            Observacoes = observacoes;
        }
    }
}
