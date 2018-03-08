using System;
using System.Collections.Generic;

namespace prg2._2_oop
{
    public class Node <T>
    {
        public T data;
        public Node<T> next;
        public Node<T> root;
        internal int value;


        public int Value { get; internal set; }

        public Node(T data, Node<T> root)
        {
            this.data = data;
            this.root = root;
        }
          public Node(T data)
        {
            this.data = data;  
            this.root = this;   
        }
        public void Print()
        {
            Node<T> copy = this;
            this.Display(copy);
        }
        public void PrintAll()
        {
            Node<T> copy = this.root;
            this.Display(copy);
        }
        private void Display(Node<T> copy)
        {
            while(copy.next != null)
            {
                Console.WriteLine(copy.data);
                copy = copy.next;
            }
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return 0;
        }

        //#region operator

       public static bool operator ==(Node<T> obj1, Node<T> obj2)
        {
            bool dataEqual = obj1.data.Equals(obj2.data);
            if(null != obj1.next && null !=obj2.next)
            {
            bool nextEqual = obj1.next == obj2.next;
            bool rootEqual = obj1.root == obj2.root;
            return dataEqual && nextEqual && rootEqual;
            }
                return dataEqual;
        }

        
        public static bool operator !=(Node<T> obj1, Node<T> obj2)
        {
            return !(obj1 == obj2);
        }

        public static Node<T> operator ++(Node<T> n)
        {
            return n.next;
        }
        

        public Node<T> this[int key]
        {
            get
            {
                Node<T> iterator = root;
                for(int i =0; i < key; i++)
                {
                    if(iterator == null)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    iterator = iterator.next;
                }

                return iterator;
                
            }

            set
            {
                ;
            }

        }

    }
}
