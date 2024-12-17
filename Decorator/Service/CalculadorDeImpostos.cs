using System;
using DesignPatterns.Model;

namespace DesignPatterns.Service
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento pObjOrcamento, Imposto pObjImposto)
        {
            double valor = pObjImposto.Calcula(pObjOrcamento);
        }
    }
}
