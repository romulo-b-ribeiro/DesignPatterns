using _02_ChainOfResponsibilty.Entities;

namespace _02_ChainOfResponsibilty.Interfaces
{
    public interface IResposta
    {
        string Responder(Requisicao req, Conta conta);
        IResposta OutraResposta { get; set; }
    }
}
