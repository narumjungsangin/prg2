using System;
using System.Collections.Generic;
using System.Linq;

namespace prg2._4_functional_programming
{
    public class Select
    {
        public void run()
        {
            List<string> words = new List<string>();
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();
            words = sentence.Split(new char[]{' '}).ToList();
            
            foreach(string word in words)
            {
                Console.Write(word + " ");
            }
            List<string> changedWords = words.Select(word => word.ToLower() == "programming2" ? "Programmin2 is awsome" : word).ToList();
            List<string> approvedWords = changedWords.Where(word => !word.Contains("cheeto")).ToList();
            List<string> upperWords = words.Select(MakeUpperCase).ToList();
            List<int> nums = new List<int>(3);
            List<int> nums2 = nums.Select(make10).ToList();
            List<string> combinedWords = words.Zip(changedWords,(word1,word2) => word1 + ":" + word2).ToList();
            Console.WriteLine();
            foreach(string word in approvedWords)
            {
                Console.Write(word + " ");
            }


                DoSomething(Something);
                DoSomething(MakeUpperCase);
        }
        public int NoLoop( List<int> A)
        {
           
            A= A.Where(num => num > 0).ToList();
            return A.Sum()/A.Count();

        }

        public string Something(string msg)
                {
                    return "help me obi won kanobi" + msg;
                }
                public int make10(int input)
                {
                    return 10;
                }
                public string MakeUpperCase(string msg)
                {
                    return msg.ToUpper();
                }
                public void DoSomething(Func<string,string> anything)
                {
                    Console.WriteLine(anything(Console.ReadLine()));
                    anything(anything("okay"));
                }
    }
}