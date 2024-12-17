using System;
using DesignPatterns.Interface;

namespace DesignPatterns.Model
{
    public class ICMS : IImposto
    {
        public double Calcula(Orcamento pObjOrcamento)
        {
            return pObjOrcamento.Valor * 0.1;
        }
    }
}
