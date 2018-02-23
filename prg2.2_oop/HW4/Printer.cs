using System;
using System.Collections.Generic;
namespace prg2._2_oop
{
    public class Printer : PaperConsumable
    {
        
        public Printer()
        {
            Ingredients = new Dictionary<System.Type,Consumable>();
            MaxIngredients = new Dictionary<System.Type,double>();
            Ingredients[typeof(Ink)]= new Ink();
            Ingredients[typeof (Paper)]=new Paper();
         //     Ingredients[typeof(Grains)]= new Grains();
         //     Ingredients[typeof(PaperFilter)] = new PaperFilter();
            MaxIngredients[typeof(Paper)] = 12.0;
            MaxIngredients[typeof(Ink)] = 6.0;
         //     MaxIngredients[typeof(Coffee)] = 12.0;
         //     MaxIngredients[typeof(PaperFilter)] = 2.0;
        }
        public void AddInk(double AmountOfInk)
        {
            if(Ingredients[typeof(Ink)].Quantity + AmountOfInk > MaxIngredients[typeof(Ink)])
            {
            Ingredients[typeof(Ink)].Quantity += AmountOfInk;
            }
            else
            {
                throw new Exception("Too Much Ink!");
            }

        }
        public void AddPaper(double AmountOfPaper)
        {
           if(Ingredients[typeof(Paper)].Quantity + AmountOfPaper > MaxIngredients[typeof(Paper)])
            {
            Ingredients[typeof(Paper)].Quantity += AmountOfPaper;
            }
            else
            {
                throw new Exception("Too Much Paper!");
            }
        }

        public override Consumable Make()
        {
            throw new NotImplementedException();
        }

        /*
            public void InsertFilter()
            {
                Ingredients[typeof(PaperFilter)].quantity += 1.0;

            }
            public override Consumable Make()
            {
                //throw new NotImplementedException();
            }
            */
    }
}