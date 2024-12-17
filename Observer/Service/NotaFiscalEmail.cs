using DesignPatterns.Interface;
using DesignPatterns.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Service
{
    public class NotaFiscalEmail : IAcoesNotaFiscal
    {
        public void Executa(NotaFiscal pObjNotaFiscal)
        {
            Console.WriteLine("Mock Envio de Email");
        }
    }
}
