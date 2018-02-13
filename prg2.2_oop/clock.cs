using System;
namespace prg2._2_oop
{
    public class Clock
    {
    int sec;
    int min;
    int hour;  
        public void tick()
        {
            sec++;   
            if(sec == 60)
                {
                    min++;
                    sec = 0;
                }
            if(min == 60)
                {
                    hour++;
                    min = 0;
                } 
        }

            public Clock(int hours, int mins, int secs)
            {
                hour = 0;
                mins = 0;
                sec = 0;

            }

          public void displaytime()
        {
           Console.WriteLine("The Current time is: " + hour + " : " + min + " : "+sec);

        }

        public void settime(int hours, int mins, int secs)
        {   
            hour = hours;
            min = mins;
            sec = secs;
        }

    }


}