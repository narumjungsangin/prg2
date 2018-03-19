using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace prg2._4_functional_programming
{
    public class LinqPractice
    {
        public void Problem1()
        {
            String TheStatement = "I am Korean BUT I AM not sUre";
            List<String> TheWord = new List<String>();
            List<String> BigWord = new List<String>();
            //TheWord.AddRange(TheStatement);
            TheWord  = TheStatement.Split(' ').ToList();
            BigWord  = TheStatement.ToUpper().Split(' ').ToList();
           List<string> matching = TheWord.Intersect(BigWord).ToList();
           Console.WriteLine(" ",matching.ToArray());
            }

      /*  public void ReadCSV()
        {   
            {
                using(var reader = new StreamReader("C:\Users\user\Desktop/csv"))
                {
                    List<string> Student = new List<string>();
                    List<int> Cyear = new List<int>();
                    List<int> GPA = new List<int>();
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        Student.Add(values[0]);
                        Cyear.Add(Convert.ToInt32(values[1]));
                        GPA.Add(Convert.ToInt32(values[2]));
                    }
               string ear = DateTime.Now.ToString("yyyy");
               int numear = Convert.ToInt32(ear);
               int[] ceararr = new int[Cyear.Count];
               for(int i = 0; i < Cyear.Count; i++)
                {
                    ceararr[i] = Cyear[i];
                }
                //class year arr 로 변환까지 함....
                }
            }
        }
        */

        public void Problem2()
        {
            //ReadCSV();


        }
        public void Problem3()
        {

        }      
        
        }
    
}
