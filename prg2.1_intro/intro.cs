using System;

namespace prg2._1_intro
{
    public class Intro
    {
        public Intro(string[] args)
        {
            Console.WriteLine("Launched intro");
            string answer = Console.ReadLine();

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = x + y;

            string zs = (x+y).ToString;
            Console.WriteLine(zs);

            bool xIsEqualToy = x == y;
            
            if(xIsEqualToy)

        } 
    }
}
