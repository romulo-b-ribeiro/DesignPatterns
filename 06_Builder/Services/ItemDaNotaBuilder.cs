using _06_Builder.Entities.NotaFiscal;

namespace _06_Builder.Services
{
    public class ItemDaNotaBuilder
    {
        public string _nome;
        public decimal _valor;

        public ItemDaNota GerarItemDaNota()
        {
            return new ItemDaNota(_nome, _valor);
        }

        public ItemDaNotaBuilder AdicionarNome(string nome)
        {
            _nome = nome;
            return this;
        }
        
        public ItemDaNotaBuilder AdicionarValor(decimal valor)
        {
            _valor = valor;
            return this;
        }
    }
}
