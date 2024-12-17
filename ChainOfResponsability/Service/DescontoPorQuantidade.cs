using DesignPatterns.Model;
using DesignPatterns.Interface;
using System;

namespace DesignPatterns.Service
{
    public class DescontoPorQuantidade : IDesconto
    {
        public IDesconto Proximo { get; set; }
        public double Desconta(Orcamento pObjOrcamento)
        {
            if (pObjOrcamento.Itens.Count > 5)
                return pObjOrcamento.Valor * 0.1;

            return Proximo.Desconta(pObjOrcamento);
        }
    }
}
