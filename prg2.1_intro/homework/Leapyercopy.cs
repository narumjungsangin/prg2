using System;

namespace prg2._1_intro
{
    public class Leapyearcopy
    {
        public void run()
        {
            Console.WriteLine("Print out year if youu want");
            int year = Convert.ToInt32(Console.ReadLine());
            if(year % 4 == 0 )
            {
                if(year % 100 == 0)
                {         
                    if(year % 400 == 0)
                    {
                        Console.WriteLine("It is leap year");
                        Console.WriteLine("The next 20 leap year is...");
                        int nleap = year;
                        int cout = 0;
                        while(cout != 20)
                            {    
                            nleap +=4;
                            Console.WriteLine(nleap);
                            cout++;
                            }
                    } 
                    else 
                    {
                        Console.WriteLine("It is NOT leap year");  
                        int cyear = year;
                        for(int x = 0; x < 4; x++)
                            {
                                cyear ++;
                                if(cyear % 4 == 0 || cyear % 400 == 0)
                                    break;
                            }
                            Console.WriteLine("The next Leap year is" + cyear);
                            Console.WriteLine("The next twenith leap year is...");
                            int nleap = cyear;
                            int cout = 0;
                            while(cout != 20)
                             {    
                                nleap +=4;
                                Console.WriteLine(nleap);
                                cout++;
                             }

                    }             
            }
            else 
            {
                Console.WriteLine("It is leap year");
                Console.WriteLine("The next four leap year is...");
                int nleap = year;
                int cout = 0;
                    while(cout != 20)
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
                int cyear = year;
                        for(int x = 0; x < 4; x++)
                            {
                                cyear ++;
                                if(cyear % 4 == 0 || cyear % 400 == 0)
                                    break;
                                
                            }
                Console.WriteLine("The next Leap year is" + cyear);
                Console.WriteLine("The next 20 leap year is...");
                int nleap = cyear;
                int cout = 0;
                while(cout != 20)
                 {    
                     nleap +=4;
                     Console.WriteLine(nleap);
                     cout++;
                 }
            }        
    }
}
}

