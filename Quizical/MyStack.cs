using System;
using System.Collections;
using System.Collections.Generic;

namespace Quizical
{
    internal class MyStack : MyStack<string>
    {
    }
    internal class MyStack<T> : IEnumerable<T>
    {
        SinglyLinkedList<T> myLinkedList = new SinglyLinkedList<T>();

        public int Count { get; private set; }
        public MyStack()
        {
        }

        internal void Push(T item)
        {
            //Add new items at top position in stack
            myLinkedList.AddFirst(item);
            Count = myLinkedList.Count;
        }

        internal T Peek()
        {
            T item = myLinkedList.HeadNode.NodeData;
            return item;
        }

        internal T Pop()
        {
            //remove last stack element
            T item = myLinkedList.HeadNode.NodeData;
            myLinkedList.RemoveFirst();
            Count = myLinkedList.Count;
            return item;
        }

        internal void Clear()
        {
            myLinkedList.Clear();
            Count = myLinkedList.Count;
        }
        //IEnumerator implementation from linked list
        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)myLinkedList).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)myLinkedList).GetEnumerator();
        }
    }
}