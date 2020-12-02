using _03_TemplateMethod.Entities;

namespace _03_TemplateMethod.Interfaces
{
    public interface IImposto
    {
        decimal Calcular(Orcamento orcamento);
    }
}
