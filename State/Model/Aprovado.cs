using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.Interface;

namespace DesignPatterns.Model
{
    public class Aprovado : EstadoOrcamento
    {
        public void AplicaDescontoExtra(Orcamento pObjOrcamento)
        {
            pObjOrcamento.Valor = pObjOrcamento.Valor - (pObjOrcamento.Valor * 0.02);
        }

        public void Aprova(Orcamento pObjOrcamento)
        {
            throw new Exception("Estado atual já é aprovado"); 
        }

        public void Reprova(Orcamento pObjOrcamento)
        {
            pObjOrcamento.lObjEstadoOrcamento = new Reprovado();
        }

        public void Finaliza(Orcamento pObjOrcamento)
        {
            pObjOrcamento.lObjEstadoOrcamento = new Finalizado();
        }
    }
}
