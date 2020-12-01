using _02_ChainOfResponsibilty.Entities;
using _02_ChainOfResponsibilty.Entities.Enums;
using _02_ChainOfResponsibilty.Interfaces;

namespace _02_ChainOfResponsibilty.Services.Respostas
{
    public class RespostaEmCSV : IResposta
    {
        public IResposta OutraResposta { get; set; }

        public RespostaEmCSV(IResposta outraResposta)
        {
            OutraResposta = outraResposta;
        }

        public string Responder(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.CSV)
            {
                return $"{conta.Titular};{conta.Saldo}";
            }
            return OutraResposta.Responder(req, conta);
        }
    }
}
