﻿using _01_Strategy.Interfaces;
using System;

namespace _01_Strategy
{
    public class Orcamento
    {
        public decimal Valor { get; private set; }

        public Orcamento(decimal valor)
        {
            Valor = valor;
        }
    }

    public class ICMS_Strategy : IImposto
    {
        public decimal Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05M + 50M;
        }
    }

    public class ISS_Strategy : IImposto
    {
        public decimal Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06M;
        }
    }

    public class ICCC : IImposto
    {
        public decimal Calcular(Orcamento orcamento)
        {
            if (orcamento.Valor < 1000M)
            {
                return orcamento.Valor * 0.05M;
            }
            if (orcamento.Valor >= 1000M && orcamento.Valor <= 3000M)
            {
                return orcamento.Valor * 0.07M;
            }
            return orcamento.Valor * 0.08M + 30M;
        }
    }

    public class CalculadorDeImposto
    {
        public CalculadorDeImposto(Orcamento orcamento, IImposto imposto)
        {
            Console.WriteLine(imposto.Calcular(orcamento));
        }
    }
}