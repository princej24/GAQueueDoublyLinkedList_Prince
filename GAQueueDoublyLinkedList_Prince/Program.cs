using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// prince jeff 
// 3/2/24

namespace GAQueueDoublyLinkedList_Prince
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new queue of integers
            Queue<int> queue = new Queue<int>();

            // Enqueue elements
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            // Dequeue an element
            Console.WriteLine($"Dequeued: {queue.Dequeue()}");

            // Peek at the front element
            Console.WriteLine($"Front element: {queue.Peek()}");

            // Display count
            Console.WriteLine($"Count: {queue.Count}");

            Console.ReadLine();
        }
    }
}