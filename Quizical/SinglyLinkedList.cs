using System.Collections;
using System.Collections.Generic;

namespace Quizical
{
    internal class SinglyLinkedList<T> :IEnumerable<T>
    {
        public Node<T> HeadNode { get; private set; }
        public Node<T> TailNode { get; private set; }

        public int Count { get; private set; }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = HeadNode;
            while (current != null)
            {
                yield return current.NodeData;
                current = current.NextNode;
            }
        }

        internal void AddFirst(T nodeData)
        {

            Node<T> tempNode = HeadNode;
            HeadNode = new Node<T>(nodeData);
            HeadNode.NextNode = tempNode;
            if (Count == 0) TailNode = HeadNode;
            Count++;
        }

        internal void AddLast(T nodeData)
        {
            TailNode.NextNode = new Node<T>(nodeData);
            TailNode = TailNode.NextNode;
            if (Count == 0) HeadNode = TailNode;
            Count++;
        }

        internal void RemoveFirst()
        {
            if(Count != 0)
            {
                HeadNode = HeadNode.NextNode;
                Count--;
                if (Count == 0) TailNode = null;
            }
        }

        internal void RemoveLast()
        {
            if (HeadNode != null)
            {
                if (HeadNode.NextNode == null)
                {
                    HeadNode = TailNode = null;
                }
                else
                {
                    Node<T> tempNode = HeadNode;
                    while (tempNode.NextNode.NextNode != null)
                    {
                        tempNode = tempNode.NextNode;
                    }
                    TailNode = tempNode;
                    TailNode.NextNode = null;
                }
                Count--;
            }
        }

        internal void Clear()
        {
            Node<T> current = HeadNode;
            while (current != null)
            {
                RemoveLast();
                current = HeadNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Node<T>
    {
        public Node(T nodeData)
        {
            NodeData = nodeData;
        }

        public T NodeData { get; private set; }
        public Node<T> NextNode { get; set; }
    }

}