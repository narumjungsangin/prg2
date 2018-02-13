using System;
namespace prg2._2_oop
{
    public class CoffeeMaker
    {
        //methood, constructor
        double water_amount;
        double  MAX_WATER_AMOUNT;
        double coffee_amount;
        double  MAX_COFEE_AMOUNT;
        double grain_amount;
        double  MAX_GRAIN_AMOUNT;
        bool on_off;
        //hotplate
        bool filterin;
        
       
        
        public CoffeeMaker()
        {
             MAX_COFEE_AMOUNT = 12;
        on_off = false;
        filterin = false;
            water_amount = 0;
//                  throw new Exception("NONONONo");

        }
        public void InsertFilter()
        {
            if(filterin == true)
            {
                throw new Exception ("Filter already inn");
            }
            else
            {
                filterin = ture;
            }
        }


        public void Addwater(double wateramountAdd)
        {
            if(water_amount + wateramountAdd > MAX_WATER_AMOUNT)
            {
                throw new Exception("TOO MUCH");
            }
            else
            {
                water_amount += wateramountAdd;
            }
            

        }

        public void AddGrains(double scoops_of_grains)
        {
            if(grain_amount + scoops_of_grains > MAX_GRAIN_AMOUNT)
            {
                throw new Exception("put some of that back");
            }
            else
            {
                grain_amount = grain_amount + scoops_of_grains;
            }

        }

        public double GetMaxGrains()
        {
            return MAX_GRAIN_AMOUNT;
        }

        public void makecoffee()
        {


        }

    }

}