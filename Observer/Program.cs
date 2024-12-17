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
            NotaFiscalBuilder builder = new NotaFiscalBuilder();

            builder.Cliente("Cliente SA")
                .DocumentoNota("12.345.678/0001-90")
                .AddItens(new ItemNota("Item 1", 100d))
                .AddItens(new ItemNota("Item 2", 200d))
                .NaDataAtual()
                .Observacoes("Nota Fiscal de Teste");

            builder.AdicionaAcao(new NotaFiscalEmail());
            builder.AdicionaAcao(new NotaFiscalService());
            builder.AdicionaAcao(new NotaFiscalSMS());

            NotaFiscal lObjNotaFiscal = builder.Monta();
        }
    }
}