using System;
namespace prg2._2_oop
{
    public static class Swapper<T>
    {

         public static T data;
        public static Node<T> next;
        public static Node<T> root;
        public static void Swap (Node<T> A, Node<T> B)
        {

            Node<T> tempa = new Node<T>(A.data);
            Node<T> tempb = new Node<T>(B.data);
            
            /*tempa = A;
            tempb = B;
            A=B;
            B=tempa;
            A.next = tempb.next;
            B.next = tempa.next;*/
            if(NodeAreInSameList(A,B))
            {
            if(A==A.root)
            {
                Node<T> iterator = A;
                while(iterator !=null)
                {
                    iterator.root = B.root;
                    iterator ++;
                }
            }

            else if(B== B.root)
            {
                Node<T> iterator = B.root;
                while(iterator !=null)
                {
                    iterator.root = A;
                    iterator ++;
                }

            }
            }

           //Node<int> order = new Node<int>(66);
           // return(A , B);
            
        }

        private static bool NodeAreInSameList(Node<T> a, Node<T> b)
        {
            Node<T> iteratora = a.root;
            Node<T> iteratorb = b.root;
            while(iteratora != null && iteratorb != null)
            {
                if(iteratora != iteratorb)
                {
                    return false;
                }
                iteratora++;
                iteratorb++;
            }

            if(iteratora != null && iteratorb != null)
            {
                return false;
            }
            return true;

        }
    }
}
