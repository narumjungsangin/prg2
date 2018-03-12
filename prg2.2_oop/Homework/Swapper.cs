using System;
namespace prg2._2_oop
{
    public static class Swapper<T>
    {

         public static T data;
        public static Node<T> next;
        public static Node<T> root;
        public static (Node<T> data, Node<T> root ) Swap (Node<T> A, Node<T> B)
        {

            A.root = root;
            B.root = root;
            Node<T> temp =  A;
            A = B;
            B = temp;
           // Node<int> order = new Node<int>(66);
            return(A , B);
            
        }

       
    }
}
