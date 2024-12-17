using DesignPatterns.Interface;
using System;


namespace DesignPatterns.Model
{
    public class Orcamento
    {
        public double Valor { get; set; }

        public EstadoOrcamento lObjEstadoOrcamento { get; set; }

        public Orcamento(double valor)
        {
            Valor = valor;
            lObjEstadoOrcamento = new EmAprovacao();
        }

        public void AplicaDescontoExtra()
        {
            lObjEstadoOrcamento.AplicaDescontoExtra(this);
        }

        public void Aprova()
        {
            lObjEstadoOrcamento.Aprova(this);
        }

        public void Reprova()
        {
            lObjEstadoOrcamento.Reprova(this);
        }

        public void Finaliza()
        {
            lObjEstadoOrcamento.Finaliza(this);
        }
    }
}
