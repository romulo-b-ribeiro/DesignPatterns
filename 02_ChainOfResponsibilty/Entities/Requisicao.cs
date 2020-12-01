using _02_ChainOfResponsibilty.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _02_ChainOfResponsibilty.Entities
{
    public class Requisicao
    {
        public Formato Formato { get; private set; }

        public Requisicao(Formato formato)
        {
            Formato = formato;
        }
    }
}
