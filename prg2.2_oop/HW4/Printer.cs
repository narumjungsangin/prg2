using System;
using System.Collections.Generic;
namespace prg2._2_oop
{
    public class Printer : ConsumableMaker
    {
        
        public Printer()
        {
            Ingredients = new Dictionary<System.Type,Consumable>();
            MaxIngredients = new Dictionary<System.Type,double>();
            Ingredients[typeof(Ink)]= new Ink();
            Ingredients[typeof (Paper)]=new Paper();
            Ingredients[typeof(Scanner)]= new Scanner();
            Ingredients[typeof(Stapler)] = new Stapler();
            MaxIngredients[typeof(Paper)] = 30;
            MaxIngredients[typeof(Ink)] = 5;
            MaxIngredients[typeof(Scanner)] = 1;
            MaxIngredients[typeof(Stapler)] = 100;
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

         public void InsertScanner(double AmountOfScanner)
        {
           if(Ingredients[typeof(Scanner)].Quantity + AmountOfScanner > MaxIngredients[typeof(Scanner)])
            {
            Ingredients[typeof(Scanner)].Quantity += AmountOfScanner;
            }
            else
            {
                throw new Exception("Too much inserted to Scan!");
            }
        }

         public void AddStapler(double AmountOfStapler)
        {
           if(Ingredients[typeof(Stapler)].Quantity + AmountOfStapler > MaxIngredients[typeof(Stapler)])
            {
            Ingredients[typeof(Stapler)].Quantity += AmountOfStapler;
            }
            else
            {
                throw new Exception("Too much inserted to Scan!");
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