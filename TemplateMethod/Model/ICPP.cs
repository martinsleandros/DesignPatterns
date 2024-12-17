using System;
using DesignPatterns.Interface;

namespace DesignPatterns.Model
{
    public class ICPP : TemplateImpostoCondicional
    {
        public override bool DeveUsarTaxaMaxima(Orcamento pObjOrcamento)
        {
            return (pObjOrcamento.Valor >= 500);
        }

        public override double TaxaMaxima(Orcamento pObjOrcamento)
        {
            return pObjOrcamento.Valor * 0.07;
        }

        public override double TaxaMinima(Orcamento pObjOrcamento)
        {
            return pObjOrcamento.Valor * 0.05;
        }
    }
}
