﻿using System;
using DesignPatterns.Interface;
using DesignPatterns.Model;
using DesignPatterns.Service;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args) 
        {
            IImposto iss = new ISS();
            IImposto icms = new ICMS();

            Orcamento lObjOrcamento = new Orcamento(500);

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            calculador.RealizaCalculo(lObjOrcamento, iss);
        }
    }
}