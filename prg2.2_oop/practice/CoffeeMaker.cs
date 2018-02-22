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
            Ingredients[typeof(Grain)]= new Grains();


        }
        public void AddWater(double AmountOfWater)
        {
            Ingredients[typeof(Water)].quanitity += AmountOfWater;

        }
        public void AddGrains(double AmountOfGrains)
        {
            
        }
        public void InsertFilter()
        {

        }
        public override Consumable Make()
        {
            throw new NotImplementedException();
        }
    }
}