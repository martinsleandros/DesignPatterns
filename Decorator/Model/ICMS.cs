using System;

namespace DesignPatterns.Model
{
    public class ICMS : Imposto
    {

        public ICMS(Imposto pObjImpostoAdicional) : base(pObjImpostoAdicional) { }

        public ICMS() : base() { }
        public override double Calcula(Orcamento pObjOrcamento)
        {
            return pObjOrcamento.Valor * 0.1 + CalculoImpostoAdicional(pObjOrcamento);
        }
    }
}
