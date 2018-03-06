using System;
namespace prg2._2_oop
{
    public class Swap<T>
    {


        public Swap (Node<T> A, Node<T> B)
        {
            Node<T> c = A;
            A = B;
            B = c;


        }



    }

}