using System;
using System.Collections.Generic;

namespace prg2._1_intro
{
    public class Intro
    {
        public Intro(string[] args)
        {

            List<string> students = new List<string>();
            students.Add("Slosar");
            students.Add("Engel");
            students.Add("Yoon");
            students.Add("Gallager");

             

            foreach(string student in students)
                Console.Write(student + " ");
            
            Console.WriteLine();

            while(students.Count != 10)
                students.Add("empty spot");

            Dictionary<string,int> studentGrades = new Dictionary<string,int>();
            studentGrades["Yoon"] = 110;
            /*Console.WriteLine("Launched intro");
            string answer = Console.ReadLine();

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = x + y;

            string zs = (x+y).ToString;
            Console.WriteLine(zs);

            bool xIsEqualToy = x == y;
            
            if(xIsEqualToy)
            */

        } 
    }
}
