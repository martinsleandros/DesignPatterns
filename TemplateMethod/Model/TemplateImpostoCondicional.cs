using DesignPatterns.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Model
{
    public abstract class TemplateImpostoCondicional : IImposto
    {
        public double Calcula(Orcamento pObjOrcamento)
        {
            if (DeveUsarTaxaMaxima(pObjOrcamento))
                return TaxaMaxima(pObjOrcamento);

            return TaxaMinima(pObjOrcamento);
        }

        public abstract bool DeveUsarTaxaMaxima(Orcamento pObjOrcamento);
        public abstract double TaxaMaxima(Orcamento pObjOrcamento);
        public abstract double TaxaMinima(Orcamento pObjOrcamento);
    }
}
