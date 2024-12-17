using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Interface;
using DesignPatterns.Model;

namespace DesignPatterns.Service
{
    public class NotaFiscalBuilder
    {
        public string lStrRazaoSocial { get; private set; }
        public string lStrCnpj { get; private set; }
        public string lStrObservacoes { get; private set; }
        public DateTime lDatData { get; private set; }

        private double lDobValorTotal;
        private double lDobValorImposto;
        private IList<ItemNota> lObjItens = new List<ItemNota>();

        private IImposto lObjImpostos = new ISS();

        public NotaFiscalBuilder Cliente(string pStrRazaoSocial)
        {
            this.lStrRazaoSocial = pStrRazaoSocial;
            return this;
        }

        public NotaFiscalBuilder DocumentoNota(string pStrCnpj)
        {
            this.lStrCnpj = pStrCnpj;
            return this;
        }

        public NotaFiscalBuilder AddItens(ItemNota pObjItem)
        {
            this.lObjItens.Add(pObjItem);
            this.lDobValorTotal += pObjItem.lDobValor;

            Orcamento lObjOrcamento = new Orcamento(this.lDobValorTotal);
            lDobValorImposto = lObjImpostos.Calcula(lObjOrcamento);

            return this;
        }

        public NotaFiscalBuilder NaDataAtual()
        {
            this.lDatData = DateTime.Now;
            return this;
        }

        public NotaFiscalBuilder Observacoes(string pStrObservacoes)
        {
            this.lStrObservacoes = pStrObservacoes;
            return this;
        }
    }
}
