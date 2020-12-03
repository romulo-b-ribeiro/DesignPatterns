using _06_Builder.Entities.NotaFiscal;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_Builder.Services
{
    public class NotaFiscalBuilder
    {
        public string _razaoSocial;
        public string _cnpj;
        public string _observacoes;
        public DateTime _data;
        private decimal _valorTotal;
        private decimal _impostos;
        private IList<ItemDaNota> _todosItens = new List<ItemDaNota>();

        public NotaFiscal GerarNota()
        {
            return new NotaFiscal(_razaoSocial, _cnpj, _valorTotal, _impostos, _todosItens, _observacoes, _data);
        }

        public NotaFiscalBuilder AdicionarEmpresa(string razaoSocial)
        {
            _razaoSocial = razaoSocial;
            return this; // Fluent interface
        }
        
        public NotaFiscalBuilder AdicionarCnpj(string cnpj)
        {
            _cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder AdicionarObservacoes(string observacoes)
        {
            _observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder AdicionarData(DateTime data)
        {
            _data = data;
            return this;
        }

        public NotaFiscalBuilder AdicionarItens(IList<ItemDaNota> itens)
        {
            _todosItens = itens;
            _valorTotal = itens.Select(item => item.Valor).Sum();
            _impostos = _valorTotal * 0.05M;
            return this;
        }
    }
}
