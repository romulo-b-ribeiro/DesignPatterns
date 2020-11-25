using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_Alura._01_Strategy.SemDP
{
    public class Orcamento
    {
        public decimal Valor { get; private set; }

        public Orcamento(decimal valor)
        {
            Valor = valor;
        }
    }

    public class ICMS
    {
        public decimal CalculaICMS(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1M;
        }
    }

    public class ISS
    {
        public decimal CalculaISS(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06M;
        }
    }

    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, String imposto)
        {
            if ("ICMS".Equals(imposto))
            {
                var icms = new ICMS().CalculaICMS(orcamento);
                Console.WriteLine(icms);
            }
            else if ("ISS".Equals(imposto))
            {
                var iss = new ISS().CalculaISS(orcamento);
                Console.WriteLine(iss);
            }
            // Mas e se quisermos outro imposto?
        }
    }
}
