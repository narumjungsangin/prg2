using System;

namespace prg2._1_intro
{
    public class leaptheyear
    {
        
        public void run()
        {
            Console.WriteLine("HELLLLLLO");
            int year = Convert.ToInt32(Console.ReadLine());

            if(year % 4 == 0 )
            {
                if(year % 100 == 0)
                {         
                    if(year % 400 == 0)
                        Console.WriteLine("It is leap year");
                    else
                    {
                        Console.WriteLine("It is NOT leap year");
                        Console.WriteLine("The next four leap year is...");
                        for(int x = year; x % 4 == 0; x++)
                        {
                            Console.WriteLine(x);
                        }
                    }
            }
            else Console.WriteLine("It is leap year");

         }
            
            if(year % 4 != 0)
            {
                Console.WriteLine("It is NOT leap year");
                Console.WriteLine("The next four leap year is...");

                int nleap = year;
                while(year % 4 != 0)
                { 
                    nleap ++;
                }
            }
    }
}
}

