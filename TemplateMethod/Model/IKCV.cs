using System;
using DesignPatterns.Interface;

namespace DesignPatterns.Model
{
    public class IKCV : TemplateImpostoCondicional
    {
        public override bool DeveUsarTaxaMaxima(Orcamento pObjOrcamento)
        {
            return (pObjOrcamento.Valor > 500 && existeItemMaior100(pObjOrcamento));
        }

        public override double TaxaMaxima(Orcamento pObjOrcamento) 
        {
            return pObjOrcamento.Valor * 0.1;
        }

        public override double TaxaMinima(Orcamento pObjOrcamento) 
        {
            return pObjOrcamento.Valor * 0.06;
        }

        private bool existeItemMaior100(Orcamento pObjOrcamento)
        {
            foreach (var item in pObjOrcamento.Itens)
                if (item.Valor > 100)
                    return true;

            return false;
        }
    }
}
