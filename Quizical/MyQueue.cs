using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Quizical
{
    internal class MyQueue : MyQueue<string>
    {
    }

    internal class MyQueue<T> : IEnumerable<T>
    {
        SinglyLinkedList<T> myLinkedList = new SinglyLinkedList<T>();

        public int Count { get; private set; }

        public MyQueue()
        {
        }
        internal void Enqueue(T item)
        {
            // if queue is empty add at first position otherwise add at last
            if (myLinkedList.Count == 0)
            {
                myLinkedList.AddFirst(item);
            }
            else
            {
                myLinkedList.AddLast(item);
            }
            Count = myLinkedList.Count;
        }

        internal T Peek()
        {
            // it returns the first node 
            T item = myLinkedList.HeadNode.NodeData;
            return item;
        }

        internal T Dequeue()
        {
            //removes the first queue element
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
