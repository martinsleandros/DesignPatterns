using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.Interface;

namespace DesignPatterns.Model
{
    public class Finalizado : EstadoOrcamento
    {
        public void AplicaDescontoExtra(Orcamento pObjOrcamento)
        {
            throw new Exception("Orçamentos Finalizados não podem aplicar descontos extras");
        }

        public void Aprova(Orcamento pObjOrcamento)
        {
            throw new Exception("Orçamento já finalizado");
        }

        public void Reprova(Orcamento pObjOrcamento)
        {
            throw new Exception("Orçamento já finalizado"); 
        }

        public void Finaliza(Orcamento pObjOrcamento)
        {
            throw new Exception("Estado atual já é finalizado");
        }
    }
}
