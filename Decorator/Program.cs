using System;
using DesignPatterns.Model;
using DesignPatterns.Service;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args) 
        {
            Imposto iss = new ISS(new ICMS());

            Orcamento lObjOrcamento = new Orcamento(500);

            iss.Calcula(lObjOrcamento);
        }
    }
}