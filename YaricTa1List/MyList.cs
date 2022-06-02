using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaricTa1List
{
    class MyList<T>
        where T: IComparable

    {
        private Node<T> Root;

        private int Index;

        public int Length() => Index;

        public void Add(T dat)
        {
            if (Root == null)
            {
                Root = new Node<T>(dat);
                Index = 1;
            }
            else
            {
                void Add1(Node<T> node, int ind)
                {
                    if (ind == Index)
                    {
                        node.SetNext(dat);
                    }
                    else
                    {
                        Add1(node.GetNext(), ind + 1);
                    }
                }
                Add1(Root,1);
                Index++;
            }

        }
        public T this[int index]
        {
            // Это аксессор get.
            get
            {
                if (ok(index))
                {
                    return GetIt(Root, index);
                }
                else
                {
                    throw new Exception("Ind out of Range");
                }
            }
            // Это аксессор set.
            set
            {
                if (ok(index))
                {
                    if (index == 0)
                    {
                        Node<T> reset = Root.GetNext();
                        Root = new Node<T>(value);
                        Root.SetNext(reset);
                    }
                    else SetIt(Root, index, value);
                  
                }
                else throw new Exception("Ind out of Range");
            }
        }

        T GetIt(Node<T> node, int ind)
        {
      
            if (ind == 0)
            {
                return node.GetData();
            }
            else
            {
                return GetIt(node.GetNext(), ind-1);
            }
        }

        void SetIt(Node<T> node, int ind, T val)
        {

            if (ind == 1)
            {

             
                Node<T> reset = node.GetNext().GetNext();
                node.SetNext(val);
                node.GetNext().SetNext(reset);
                

            }
            else
            {
                SetIt(node.GetNext(), ind - 1, val);
            }
        }

        public void SetInto(int index, T value)
        {
            if (ok(index))
            {
                if (index == 0)
                {
                    Node<T> reset = Root;
                    Root = new Node<T>(value);
                    Root.SetNext(reset);
                    Index++;
                }
                else
                {
                    SetAt(Root, index, value);
                    Index++;
                }

            }
            else throw new Exception("Ind out of Range");
        }
        void SetAt(Node<T> node, int ind, T val)
        {

            if (ind == 1)
            {
                Node<T> reset = node.GetNext();
                node.SetNext(val);
                node.GetNext().SetNext(reset);

            }
            else
            {
                SetAt(node.GetNext(), ind - 1, val);
            }
        }

        public bool RemoveAt(int index)
        {
            if (ok(index))
            {
                if (index == 0)
                {
                    Node<T> reset = Root.GetNext().GetNext();
                    Root = new Node<T>(Root.GetNext().GetData());
                    Root.SetNext(reset);
                    Index--;
                    return true;
                }
                else
                { 
                    DellIt(Root, index);
                    Index--;
                    return true; 
                }
               
            }
            else throw new Exception("Ind out of Range");
        }
        void DellIt(Node<T> node, int ind)
        {

            if (ind == 1)
            {
                Node<T> reset = node.GetNext().GetNext();

                node.SetNext(reset);

            }
            else
            {
                DellIt(node.GetNext(), ind - 1);
            }
        }
        public bool Remove(T dat)
        {
            if (Root.GetData().CompareTo(dat) == 0)
            {
                Node<T> reset = Root.GetNext().GetNext();
                Root = new Node<T>(Root.GetNext().GetData());
                Root.SetNext(reset);
                Index--;
                return true;
            }
            else
            {
                bool res = DellIt(Root, dat);
                if (res)
                {
                    Index--;
                }
                return res;
            }

        }
        bool DellIt(Node<T> node, T dat)
        {
            if (node == null)
            {
                return false;
            }
            if (node.GetNext().GetData().CompareTo(dat)==0)
            {
                Node<T> reset = node.GetNext().GetNext();
                node.SetNext(reset);
                return true;
            }
           
            else
            {
                return DellIt(node.GetNext(), dat);
            }
        }



        bool ok(int i)
        {
            if (i >= 0 && i < Index)
            {
                return true;
            }
            return false;
        }




    }
}
