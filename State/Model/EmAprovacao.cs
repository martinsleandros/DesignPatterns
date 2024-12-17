using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.Interface;

namespace DesignPatterns.Model
{
    public class EmAprovacao : EstadoOrcamento
    {
        public void AplicaDescontoExtra(Orcamento pObjOrcamento)
        {
            pObjOrcamento.Valor = pObjOrcamento.Valor - (pObjOrcamento.Valor * 0.05);
        }

        public void Aprova(Orcamento pObjOrcamento)
        {
            pObjOrcamento.lObjEstadoOrcamento = new Aprovado();
        }

        public void Reprova(Orcamento pObjOrcamento)
        {
            pObjOrcamento.lObjEstadoOrcamento = new Reprovado();
        }

        public void Finaliza(Orcamento pObjOrcamento)
        {
            throw new Exception("Não em possível finalizar um orçamento em aprovação");
        }
    }
}
