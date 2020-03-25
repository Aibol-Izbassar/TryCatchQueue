using System;
using System.Collections.Generic;
namespace TryCatch
{

    class QueueEmpty : Exception
    {
        public override string Message
        {
            get { return "Queue Empty"; }
        }
    }

    class QueueFullException:Exception
    {
        public override string Message
        {
            get
            {
                return "No place";
            }
        }
    }
    class Note
    {
        public int value;
        public Note next;
        public Note()
        {

        }
    }
    class Queue
    {
        
        int _count = 0;
        public Note current;
        public Note head;
        public int Counter { get { return _count; } }
        public Queue()
        {

        }
        public void Enqueue(int n)
        {
            if (_count<=10)
            {
                Note b = new Note();
                b.value = n;
                if (head == null)
                {
                    head = b;
                    current = b;
                    _count++;
                }
                current.next = b;
                current = b;
                _count++;
            }
            else
            {
                throw new QueueFullException();
            }
        }

        public int Dequeue()
        {
            if (head!=null)
            {
                int GetValue = head.value;
                head = head.next;
                _count--;
                return GetValue;
            }
            else
            {
                throw new QueueEmpty();
            }
        }
    }

   
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            try
            {
                q.Enqueue(1);
                q.Enqueue(2);
                q.Enqueue(3);
                q.Enqueue(4);
                q.Enqueue(5);
                q.Enqueue(6);
                q.Enqueue(7);
                q.Enqueue(8);
                q.Enqueue(9);
                q.Enqueue(10);
                q.Enqueue(11);
                q.Enqueue(12);
            }
            catch (QueueEmpty)
            {
                Console.WriteLine("Empty");
            }
            catch(QueueFullException)
            {
                Console.WriteLine("Queue Full");
            }
            
        }
    }
}
