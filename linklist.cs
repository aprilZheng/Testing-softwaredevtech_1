using System;
namespace linkedList
{//lalala
    interface ILinked_list<T>
    {
        //interface only store public messages
        void Push(T data);

        void Pop();

        int GetLength();

        bool InsertAfter(Node<T> targerElem, T data);

        bool Remove(Node<T> removeTarget);

        LinkedList<T> Clone();

        bool Swap(Node<T> firstnode, Node<T> secondnode);
    }
}

