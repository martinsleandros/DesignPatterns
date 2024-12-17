using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.Interface;

namespace DesignPatterns.Model
{
    public class Reprovado : EstadoOrcamento
    {
        public void AplicaDescontoExtra(Orcamento pObjOrcamento)
        {
            throw new Exception("Orçamentos Reprovados não podem aplicar descontos extras");
        }

        public void Aprova(Orcamento pObjOrcamento)
        {
            throw new Exception("Orçamento já reprovado");
        }

        public void Reprova(Orcamento pObjOrcamento)
        {
            throw new Exception("Estado atual já é reprovado");
        }

        public void Finaliza(Orcamento pObjOrcamento)
        {
            pObjOrcamento.lObjEstadoOrcamento = new Finalizado();
        }
    }
}
