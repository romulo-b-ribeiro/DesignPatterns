﻿namespace _03_TemplateMethod.Entities
{
    public class Item
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }

        public Item(string nome, decimal valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}
