using _07_Observer.Entities.NotaFiscal;
using _07_Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_Observer.Services
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

        private IList<IAcaoAposGerarNota> _acoesAposGerarNota;

        /*
         * Também pode-se passar a lista de ações pelo construtor
         * O  que possibilita injeção de dependência
         * 
        public NotaFiscalBuilder(IList<IAcaoAposGerarNota> acoesAposGerarNota)
        {
            _acoesAposGerarNota = acoesAposGerarNota;
        }
        */

        public NotaFiscal GerarNota()
        {
            var notaFiscal = new NotaFiscal(_razaoSocial, _cnpj, _valorTotal, _impostos, _todosItens, _observacoes, _data);
            
            // Design Pattern: Observer
            foreach (var acao in _acoesAposGerarNota)
            {
                acao.Executar(notaFiscal);
            }
            return notaFiscal;
        }

        public void AdicionarAcao(IAcaoAposGerarNota acao)
        {
            _acoesAposGerarNota.Add(acao);
        }

        public NotaFiscalBuilder AdicionarEmpresa(string razaoSocial)
        {
            _razaoSocial = razaoSocial;
            return this;
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
