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
            Ingredients[typeof(Card)] =  new Card();
            Ingredients[typeof(ColoredInk)] = new ColoredInk();
            MaxIngredients[typeof(Paper)] = 30;
            MaxIngredients[typeof(Ink)] = 5;
            MaxIngredients[typeof(Scanner)] = 1;
            MaxIngredients[typeof(Stapler)] = 100;
            MaxIngredients[typeof(Card)] = 1;
            MaxIngredients[typeof(ColoredInk)] = 5;
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

         public void InsertCard(double AmountOfCards)
        {
           if(Ingredients[typeof(Card)].Quantity + AmountOfCards > MaxIngredients[typeof(Card)])
            {
            Ingredients[typeof(Card)].Quantity += AmountOfCards;
            }
            else
            {
                throw new Exception("Only one card at a time!");
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

          public void AddColoredInk(double AmountOfColoredInk)
        {
            if(Ingredients[typeof(ColoredInk)].Quantity + AmountOfColoredInk > MaxIngredients[typeof(ColoredInk)])
            {
            Ingredients[typeof(Ink)].Quantity += AmountOfColoredInk;
            }
            else
            {
                throw new Exception("Too Much Ink!");
            }

        }

        public override Consumable Make()
        {
             Ingredients[typeof(Copy)] = new Copy((Ink)Ingredients[typeof(Ink)],(Paper)Ingredients[typeof(Paper)], (Scanner)Ingredients[typeof(Scanner)],(Stapler)Ingredients[typeof(Stapler)], (Card)Ingredients[typeof(Card)], (ColoredInk)Ingredients[typeof(ColoredInk)]);


            Ingredients[typeof(Copy)].Quantity = Ingredients[typeof(Water)].Quantity;
            Ingredients[typeof(Ink)].Quantity = 0;
           
            return Ingredients[typeof(Copy)];
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