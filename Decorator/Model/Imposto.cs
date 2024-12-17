using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Model
{
    public abstract class Imposto
    {
        public Imposto lObjImpostoAdicional {  get; set; }

        public Imposto(Imposto pObjImpostoAdicional)
        {
            lObjImpostoAdicional = pObjImpostoAdicional;
        }

        public Imposto()
        {
            lObjImpostoAdicional = null;
        }

        public abstract double Calcula(Orcamento pObjOrcamento);

        protected double CalculoImpostoAdicional(Orcamento pObjOrcamento)
        {
            if (lObjImpostoAdicional == null)
                return 0;

            return lObjImpostoAdicional.Calcula(pObjOrcamento);
        }
    }
}
