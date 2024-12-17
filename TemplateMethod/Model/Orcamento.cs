using System;


namespace DesignPatterns.Model
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public IList<Item> Itens { get; private set; }

        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
        }

        public void AdicionaItem(Item pObjItem)
        {
            Itens.Add(pObjItem);
        }
    }
}
