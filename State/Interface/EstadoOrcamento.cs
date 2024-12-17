using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.Model;

namespace DesignPatterns.Interface
{
    public interface EstadoOrcamento
    {
        void AplicaDescontoExtra(Orcamento pObjOrcamento);

        void Aprova(Orcamento pObjOrcamento);

        void Reprova(Orcamento pObjOrcamento);

        void Finaliza(Orcamento pObjOrcamento);
    }
}
