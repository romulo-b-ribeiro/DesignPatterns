using _07_Observer.Entities.NotaFiscal;

namespace _07_Observer.Interfaces
{
    public interface IAcaoAposGerarNota
    {
        void Executar(NotaFiscal notaFiscal);
    }
}
