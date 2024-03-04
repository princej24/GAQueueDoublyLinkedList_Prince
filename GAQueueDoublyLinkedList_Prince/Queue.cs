using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAQueueDoublyLinkedList_Prince
{
    class Queue<T>
    {
        // Nested class QueueNode representing elements in the queue.
        class QueueNode<T>
        {
            public T Value { get; set; }           // Data stored in the node.
            public QueueNode<T> Next { get; set; } // Reference to the next node.
            public QueueNode<T> Previous { get; set; } // Reference to the previous node.

            public QueueNode(T value)
            {
                Value = value;
                Next = null;
                Previous = null;
            }
        }

        // Private fields to track the front and rear elements of the queue.
        private QueueNode<T> front;
        private QueueNode<T> rear;
        private int count; // Private field to store the count of elements.

        // Public property to access the count of elements.
        public int Count
        {
            get { return count; }
        }

        // Constructor to initialize an empty queue.
        public Queue()
        {
            front = null;
            rear = null;
            count = 0;
        }

        // Enqueue method adds elements to the rear of the queue.
        public void Enqueue(T value)
        {
            QueueNode<T> newNode = new QueueNode<T>(value);

            if (rear == null)
            {
                front = newNode;
                rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                newNode.Previous = rear;
                rear = newNode;
            }

            count++;
        }

        // Dequeue method removes and returns the element from the front of the queue.
        public T Dequeue()
        {
            if (front == null)
                throw new InvalidOperationException("Queue is empty.");

            T value = front.Value;
            front = front.Next;

            if (front == null)
                rear = null;
            else
                front.Previous = null;

            count--;
            return value;
        }

        // Peek method returns the element at the front without removing it.
        public T Peek()
        {
            if (front == null)
                throw new InvalidOperationException("Queue is empty.");

            return front.Value;
        }

        // Clear method empties the queue.
        public void Clear()
        {
            front = null;
            rear = null;
            count = 0;
        }
    }

}