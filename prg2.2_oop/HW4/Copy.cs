using System;

namespace prg2._2_oop
{
    public class Copy : Consumable
    {
        public double Files;

        public string Copylayer;

        public Copy()
        {
            Quantity=0;
            Files = 0;
            Copylayer="Non existant";
        }
        public Copy(Ink i,Paper p ,Scanner sc, Stapler st, Card c)
        {
            this.Copylayer = p.Copylayer;
        }
    }
}