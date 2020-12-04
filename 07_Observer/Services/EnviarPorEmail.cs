using _07_Observer.Entities.NotaFiscal;
using _07_Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07_Observer.Services
{
    public class EnviarPorEmail : IAcaoAposGerarNota
    {
        public void Executar(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Simulação de envio por email");
        }
    }
}
