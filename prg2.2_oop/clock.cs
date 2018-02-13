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
        public int GetDay (int hour)
        {
            if(hour > 24)
            {
                day = hour/60;
                hour %= 60;
            }
            return(day);
        }


        static void main()
        {

            



        }

    }


}