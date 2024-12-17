using System;
using DesignPatterns.Interface;
using DesignPatterns.Model;
using DesignPatterns.Service;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args) 
        {
            Orcamento lObjOrcamento = new Orcamento(500);

            lObjOrcamento.AplicaDescontoExtra();

            lObjOrcamento.Aprova();

            lObjOrcamento.AplicaDescontoExtra();

            lObjOrcamento.Finaliza();
        }
    }
}