using _02_ChainOfResponsibilty.Entities;
using _02_ChainOfResponsibilty.Entities.Enums;
using _02_ChainOfResponsibilty.Interfaces;

namespace _02_ChainOfResponsibilty.Services.Requisicoes
{
    public class RespostaEmXML : IResposta
    {
        public IResposta OutraResposta { get; set; }

        public RespostaEmXML(IResposta outraResposta)
        {
            OutraResposta = outraResposta;
        }

        public string Responder(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.XML)
            {
                return $"<conta><titular>{conta.Titular}</titular>" +
                       $"<saldo>{conta.Saldo}</saldo></conta>";
            }
            return OutraResposta.Responder(req, conta);
        }
    }
}
