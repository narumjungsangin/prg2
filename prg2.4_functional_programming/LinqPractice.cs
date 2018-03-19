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

        public void ReadCSV()
        {   
            {
                using(var reader = new StreamReader(@"C:\test.csv"))
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

        public void Problem2()
        {
            ReadCSV();


        }
        public void Problem3()
        {

        }      
        
        }
    
}
