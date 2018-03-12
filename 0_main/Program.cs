using System;
using prg2._1_intro;
using prg2._2_oop;
using prg2._3_design_patterns;
using prg2._4_functional_programming;
using prg2._5_database_design;


namespace _0_main
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Launching main");
        /*Clock clk = new Clock(4,23,14);
        for(int i = 0; i < 5; i++)
         {
           clk.tick();
         }
         int x =  QuickMaths.add(5,6); */

        NodeTest();
         //Console.ReadKey();
        }
         static void NodeTest()
         {
      /*      Console.WriteLine("I'm testing node");
            string done = "";
            Node<int> linkedList = new Node<int>(0);
            Node<int> root = linkedList;
            while(done != "y")
            {
                Console.WriteLine("Insert an integer for Linked List");
                int value = Convert.ToInt32(Console.ReadLine());
                linkedList.next = new Node<int>(value);
                linkedList = linkedList.next;
                Console.WriteLine("Are you done adding y/n?");
                done = Console.ReadLine().ToLower();
            }
            */


                
                Node<int> List = new Node<int>(0);
                List.next = new Node<int>(4,List.root);
                List++;
                List.next = new Node<int>(1,List.root);
                List++;
                List.next = new Node<int>(2,List.root);
                List++;
                List.next = new Node<int>(3,List.root);
                 List++;
                List.next = new Node<int>(7,List.root);
                List++;
                /*
                List.next = new Node<int>(4,List.root);
                List = List.next;
                List.next = new Node<int>(3,List.root);
                List = List.next;
                List.next = new Node<int>(1,List.root);
                List = List.next;
                */
                List = List.root;
                //List.Print();
                List.next.Print();
                Swapper<int>.Swap(List, List.next);
                List.Print("THis is swaped virsooooon");
                List.next.Print();

            /*
                Node<double> n0 = new Node<double>(0.0);
                n0.next = new Node<double>(1.0);

                Node<double> www = n0[0];
                n0[0].Print();

                */

               /* if(n0 == n1)
                {
                    Console.WriteLine("they are equal");

                }
                else
                {
                    Console.WriteLine("they are NOT equal");

                }
                */
   //       linkedList.Print();
   //       linkedList.PrintAll();
          
         }

      

        // Intro i = new Intro(args);  
        //Leapyearcopy l = new Leapyearcopy();
        //  l.run();
        //   test(args);
        //   Console.ReadKey();
        /*
        To add a project, first add a new folder naming it the [projectname]
        then type 
        dotnet new classlib -o [projectname]
        then cd to 0_main and type
        dotnet add reference ../[projectname]/[projectname].csproj
        */
        static void test(string [] args)
        {
              Intro i = new Intro(args);
              OOP o = new OOP(args);
              Design_Patterns d = new Design_Patterns(args);
              Functional_Programming f = new Functional_Programming(args);
              Database_Design dd = new Database_Design(args);
        }
    }
}

