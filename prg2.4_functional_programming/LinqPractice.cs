using System;
using System.Collections.Generic;
using System.Linq;

namespace prg2._4_functional_programming
{
    public class LinqPractice
    {
         public void Problem1()
        {
           // List<string> TheWord = new List<string>();
            String TheStatement = "I am Korean but I am not sure";
           // TheWord = TheStatement.Split(new char[]{' '}).ToList();
            char[] WordMatter = TheStatement.ToCharArray();
                foreach(char word in WordMatter)
                {
                    if(word < 90 && word > 65)
                    {
                        Console.WriteLine(word);
                    }

                }
            }
        
        public static bool IsUpper(char c)
        {
            return (0x40 < c && 0x5b > c) ? true : false;
        }

       
            
        

        public void Problem2()
        {

        }
        public void Problem3()
        {

        }      
        
        }
    
}
