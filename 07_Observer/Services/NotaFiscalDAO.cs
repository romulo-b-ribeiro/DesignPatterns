using _07_Observer.Entities.NotaFiscal;
using _07_Observer.Interfaces;
using System;

namespace _07_Observer.Services
{
    public class NotaFiscalDAO : IAcaoAposGerarNota
    {
        public void Executar(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Simulação de envio de Data Access Object ao banco de dados");
        }
    }
}
