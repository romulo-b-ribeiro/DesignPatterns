using _07_Observer.Entities.NotaFiscal;
using _07_Observer.Interfaces;
using System;

namespace _07_Observer.Services
{
    public class MultiplicarPorFator : IAcaoAposGerarNota
    {
        private readonly decimal _fator;
        public MultiplicarPorFator(decimal fator)
        {
            _fator = fator;
        }
        public void Executar(NotaFiscal notaFiscal)
        {
            Console.WriteLine($"Valor da nota multiplicado por {_fator}: {notaFiscal.ValorBruto * _fator}");
        }
    }
}
