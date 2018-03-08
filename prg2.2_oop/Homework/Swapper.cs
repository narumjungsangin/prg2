using System;
namespace prg2._2_oop
{
    public static class Swapper<T>
    {
        public static void Swap (Node<T> A, Node<T> B)
        {
            Node<T> temp =  A;
            A = B;
            B = temp;
        }



    }

}
