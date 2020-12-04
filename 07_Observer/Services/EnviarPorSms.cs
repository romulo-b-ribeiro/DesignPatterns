using _07_Observer.Entities.NotaFiscal;
using _07_Observer.Interfaces;
using System;

namespace _07_Observer.Services
{
    public class EnviarPorSms : IAcaoAposGerarNota
    {
        public void Executar(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Simulação de envio por SMS");
        }
    }
}
