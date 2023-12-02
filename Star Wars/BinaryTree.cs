using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Wars
{
    

    class BinaryTree<T> where T : class, IComparable
    {
        
        class Node
        {
            public T value;
            public Node left;
            public Node right;

        }
        Node root;
        void PrivateAdd(ref Node p, T value)
        {
            if (p==null)
            {
                p= new Node();
                p.value= value;
            }
            else
            {
                int bal = (p.value as Urhajo).HarciEro;
                int jobb = (value as Urhajo).HarciEro;
                int compare=bal.CompareTo(jobb);
                if (compare>0)
                {
                    PrivateAdd(ref p.left, value);
                }
                else if(compare<0)
                {
                    PrivateAdd(ref p.right, value);
                }
            }
        }
        public void Add(T value)
        {
            PrivateAdd(ref root, value);
        }
        public delegate void NodeDelegate(T value);
        public event NodeDelegate eventHandler;
        void PrivateInOrder(ref Node p)
        {
            if (p!=null)
            {
                PrivateInOrder(ref p.left);
                eventHandler?.Invoke(p.value);
                PrivateInOrder(ref p.right);

            }
        }
        public void InOrder()
        {
            PrivateInOrder(ref root);
        }
        void PrivateMakeList(ref Node p,ref List<T> list)
        {
            if (p != null)
            {
                PrivateMakeList(ref p.left,ref list);
                list.Add(p.value);
                PrivateMakeList(ref p.right,ref list);

            }
        }
        public void MakeList(ref List<T> l)
        {
            PrivateMakeList(ref root,ref l);
        }
    }
}
