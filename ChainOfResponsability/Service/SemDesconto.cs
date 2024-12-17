using DesignPatterns.Interface;
using DesignPatterns.Model;
using System;


namespace DesignPatterns.Service
{
    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; } 

        public double Desconta(Orcamento pObjOrcamento)
        {
            return 0;
        }
    }
}
