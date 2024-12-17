using DesignPatterns.Model;
using DesignPatterns.Interface;
using System;

namespace DesignPatterns.Service
{
    public class DescontoPorValor : IDesconto
    {
        public IDesconto Proximo { get; set; }
        public double Desconta(Orcamento pObjOrcamento)
        {
            if (pObjOrcamento.Valor > 500)
                return pObjOrcamento.Valor * 0.07;

            return Proximo.Desconta(pObjOrcamento);
        }
    }
}
