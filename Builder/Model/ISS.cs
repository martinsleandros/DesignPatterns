using System;
using DesignPatterns.Interface;

namespace DesignPatterns.Model
{
    public class ISS : IImposto
    {
        public double Calcula(Orcamento pObjOrcamento)
        {
            return pObjOrcamento.Valor * 0.06;
        }
    }
}
