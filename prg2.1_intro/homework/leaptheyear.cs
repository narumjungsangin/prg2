using System;

namespace prg2._1_intro
{
    public class leaptheyear
    {
        
        public void run()
        {
            Console.WriteLine("Print out year if u want");
            int year = Convert.ToInt32(Console.ReadLine());

            if(year % 4 == 0 )
            {
                if(year % 100 == 0)
                {         
                    if(year % 400 == 0)
                    {
                        Console.WriteLine("It is leap year");

                        Console.WriteLine("The next four leap year is...");

                int nleap = year;
                int cout = 0;
                while(cout != 4)
                { 
                    nleap +=4;
                    Console.WriteLine(nleap);
                    cout++;
                }

                    } 

                    else Console.WriteLine("It is NOT leap year");
                   
                    
            }
            else 
            {
                Console.WriteLine("It is leap year");

                Console.WriteLine("The next four leap year is...");

                int nleap = year;
                int cout = 0;
                while(cout != 4)
                { 
                    nleap +=4;
                    Console.WriteLine(nleap);
                    cout++;
                }
            }

         }
            
            if(year % 4 != 0)
            {
                Console.WriteLine("It is NOT leap year");
                
            }
    }
}
}

