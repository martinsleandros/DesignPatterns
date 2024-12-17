using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Model;

namespace DesignPatterns.Interface
{
    public interface IImposto
    {
        double Calcula(Orcamento pObjOrcamento);
    }
}
