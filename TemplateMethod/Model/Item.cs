using System;


namespace DesignPatterns.Model
{
    public class Item
    {
        public string Nome {  get; private set; }
        public double Valor { get; private set; }

        public Item(string pStrNome, double pDblValor) 
        { 
            Nome = pStrNome;
            Valor = pDblValor;
        }
    }
}
