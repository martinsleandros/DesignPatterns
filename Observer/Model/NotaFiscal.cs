using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Model
{
    public class NotaFiscal
    {
        public string lStrRazaoSocial { get; set; }
        public string lStrCnpj { get; set; }
        public string lStrObservacoes { get; set; }
        public DateTime lDatData { get; set; }
        private double lDobValorTotal { get; set; }
        private double lDobValorImposto { get; set; }
        private IList<ItemNota> lObjItens { get; set; }

        public NotaFiscal(string pStrRazaoSocial, string pStrCnpj, string pStrObservacoes, DateTime pDatData, double pDobValorTotal, double pDobValorImposto, IList<ItemNota> pObjItens) 
        { 
            this.lStrRazaoSocial = pStrRazaoSocial;
            this.lStrCnpj = pStrCnpj;
            this.lStrObservacoes = pStrObservacoes;
            this.lDatData = pDatData;
            this.lDobValorImposto = pDobValorImposto;
            this.lDobValorTotal = pDobValorTotal;
            this.lObjItens = pObjItens;
        }
    }
}
