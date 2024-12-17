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
            CalculadorDeDescontos lObjCalculador = new CalculadorDeDescontos();

            Orcamento lObjOrcamento = new Orcamento(500);

            lObjOrcamento.AdicionaItem(new Item("Item1", 200));
            lObjOrcamento.AdicionaItem(new Item("Item2", 300));

            double desconto = lObjCalculador.Calcula(lObjOrcamento);
        }
    }
}