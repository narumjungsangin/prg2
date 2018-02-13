using System;
namespace prg2._2_oop
{
    public class Clock
    {
    int sec;
    int min;
    int hour;
    int day;
    
        public int GetMin (int sec)
        {
            if(sec > 60)
            {
                min = sec/60;
                sec %= 60;
            }
            return(min);
        }

        public int GetHour (int min)
        {
            if(min > 60)
            {
                hour = min/60;
                min %= 60;
            }
            return(hour);
        }
      

        static void tick(int count)
        {
            int tick = 0;
            Clock CLK = new Clock();

            min = 0;

            for(int i = 0; i < count; i++)
            {
                tick++;
                if(tick == 60) 
                {
                CLK.GetMin(tick);
                }  
                if(min == 60 )
                {
                    CLK.GetHour(tick);
                }

            }


        }


        static void main()
        {

            



        }

    }


}