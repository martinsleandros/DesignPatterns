using DesignPatterns.Interface;
using DesignPatterns.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Service
{
    public class NotaFiscalSMS : IAcoesNotaFiscal
    {
        public void Executa(NotaFiscal pObjNotaFiscal)
        {
            Console.WriteLine("Mock Envia SMS");
        }
    }
}
