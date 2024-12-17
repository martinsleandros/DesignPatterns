using DesignPatterns.Model;
using DesignPatterns.Interface;
using System;

namespace DesignPatterns.Service
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento pObjOrcamento)
        {
            IDesconto pObjDesconto1 = new DescontoPorQuantidade();
            IDesconto pObjDesconto2 = new DescontoPorValor();
            IDesconto pObjDesconto3 = new SemDesconto();

            pObjDesconto1.Proximo = pObjDesconto2;
            pObjDesconto2.Proximo = pObjDesconto3;

            return pObjDesconto1.Desconta(pObjOrcamento);
        }
    }
}
