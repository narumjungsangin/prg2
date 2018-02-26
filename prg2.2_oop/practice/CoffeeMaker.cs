using System;
using System.Collections.Generic;
namespace prg2._2_oop
{
    public class CoffeeMaker : ConsumableMaker
    {
        
        public CoffeeMaker()
        {
            Ingredients = new Dictionary<System.Type,Consumable>();
            MaxIngredients = new Dictionary<System.Type,double>();
            Ingredients[typeof(Water)]= new Water();
            Ingredients[typeof (Coffee)]=new Coffee();
            Ingredients[typeof(Grains)]= new Grains();
            Ingredients[typeof(PaperFilter)] = new PaperFilter();
            MaxIngredients[typeof(Water)] = 12.0;
            MaxIngredients[typeof(Grains)] = 6.0;
            MaxIngredients[typeof(Coffee)] = 12.0;
            MaxIngredients[typeof(PaperFilter)] = 2.0;
        }
        public void AddWater(double AmountOfWater)
        {
            if(Ingredients[typeof(Water)].Quantity + AmountOfWater > MaxIngredients[typeof(Water)])
            {
            Ingredients[typeof(Water)].Quantity += AmountOfWater;
            }
            else
            {
                throw new Exception("Too Much Water!");
            }

        }
        public void AddGrains(double AmountOfGrains)
        {

              if(Ingredients[typeof(Grains)].Quantity + AmountOfGrains > MaxIngredients[typeof(Grains)])
            {
            Ingredients[typeof(Grains)].Quantity += AmountOfGrains;
            }
            else
            {
                throw new Exception("Too Much Grains!");
            }

            Ingredients[typeof(Grains)].Quantity += AmountOfGrains;
        }
        public void InsertFilter()
        {
            Ingredients[typeof(PaperFilter)].Quantity += 1.0;

        }
        public override Consumable Make()
        {
            
            {
                Ingredients[typeof(Coffee)] = new Coffee();
                Ingredients[typeof(Coffee)].Quantity = Ingredients[typeof(Water)].Quantity;
                Ingredients[typeof(Coffee)].Quantity = 0;

                return Ingredients
            }
        }

        public void Clean()
            {


            }
        
    }
}