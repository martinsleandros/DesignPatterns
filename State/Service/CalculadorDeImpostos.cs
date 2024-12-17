using System;
using DesignPatterns.Interface;
using DesignPatterns.Model;

namespace DesignPatterns.Service
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento pObjOrcamento, IImposto pObjImposto)
        {
            double valor = pObjImposto.Calcula(pObjOrcamento);
        }
    }
}
