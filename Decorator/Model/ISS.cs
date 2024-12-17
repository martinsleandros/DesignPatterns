using System;

namespace DesignPatterns.Model
{
    public class ISS : Imposto
    {
        public ISS(Imposto pObjImpostoAdicional) : base(pObjImpostoAdicional) { }

        public ISS() : base() { }

        public override double Calcula(Orcamento pObjOrcamento)
        {
            return pObjOrcamento.Valor * 0.06 + CalculoImpostoAdicional(pObjOrcamento);
        }
    }
}
