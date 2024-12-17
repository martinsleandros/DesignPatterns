using DesignPatterns.Model;
using System;


namespace DesignPatterns.Interface
{
    public interface IDesconto
    {
        double Desconta(Orcamento pObjOrcamento);

        IDesconto Proximo { get; set; }
    }
}
