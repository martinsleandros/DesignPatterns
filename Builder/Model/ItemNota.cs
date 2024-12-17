using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Model
{
    public class ItemNota
    {
        public string lStrNome { get; private set; }
        public double lDobValor{ get; private set; }

        public ItemNota(string pStrNome, double pDobValor)
        {
            this.lStrNome = pStrNome;
            this.lDobValor = pDobValor;
        }
    }
}
