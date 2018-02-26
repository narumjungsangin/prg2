using System;
using System.Collections.Generic;
namespace prg2._2_oop
{

    public class Coffee : Consumable
    {
        public int Caffine;
        public string RoastLevel;
        public Coffee()
        {
        Quantity = 0;
        Caffine = 0;
        RoastLevel = "Non Exist";
        }

        public Coffee(Water w, Grains g, PaperFilter pf)
        {
            this.RoastLevel = g.RoastLevel;
            w.Quantity;
            g.Quantity;
            this.Caffine = w.Quantity/g.Quantity;

        }
    }
}