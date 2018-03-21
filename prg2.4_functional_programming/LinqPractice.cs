using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;


namespace prg2._4_functional_programming
{
    public class LinqPractice
    {
        public void Problem1()
        {
            Console.WriteLine("Write the word");
            String TheStatement = Console.ReadLine();
            List<String> TheWord = new List<String>();
            List<String> BigWord = new List<String>();
            //TheWord.AddRange(TheStatement);
            TheWord  = TheStatement.Split(' ').ToList();
            BigWord  = TheStatement.ToUpper().Split(' ').ToList();
           List<string> matching = TheWord.Intersect(BigWord).ToList();
           Console.WriteLine(" ",matching.ToArray());
            }

        public void ReadCSV()
        {   
              
             string csvlines= "forcsv.csv";
             List<String> Person = new List<String>();
                var Gear = csvlines.Select(x => x.Split(",")[0]).ToList();
                var Gear = csvlines.Select(x => x.Split(",")[1]).ToList();
                var GPA = csvlines.Select(x => x.Split(",")[2]).ToArray();

 


        }
    

        public void Problem2()
        {
            ReadCSV();
            string ear = DateTime.Now.ToString("yyyy");
            int numear = Convert.ToInt32(ear);

        }
     /*   public int Problem3()
        {   
            string<int> returnanse = new List<String>;

            return null;

        }      
        */
        }
    
}
