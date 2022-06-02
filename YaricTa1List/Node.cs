using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaricTa1List
{
    class Node<T>
        where T: IComparable
    {
        T Data;

        private Node<T> Next;

        public Node(T data)
        {
            Data = data;
        }

        public T GetData() => Data;
     

        public Node<T> GetNext() => Next;
        public void SetNext(T dat) => Next = new Node<T>(dat);
        public void SetNext(Node<T> nex) => Next = nex;


        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
