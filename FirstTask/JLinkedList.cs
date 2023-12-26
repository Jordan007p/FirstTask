using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    public class JLinkedList<T>
    {
        public Node<T> First { get; private set; }
        public Node<T> Last { get; private set; }

        public JLinkedList()
        {
            this.First = null;
            this.Last = null;
        }
        public bool IsEmpty()
        {
            return First == null;
        }
        public void AddFirst(T data)
        {
            Node<T> newNode = new(data);

            if (First == null)
            {
                First = Last = newNode;
            }
            else
            {
                newNode.Next = First;
                First = newNode;
            }
        }
        public void AddLast(T data)
        {
            Node<T> newNode = new(data);
            if (First == null)
            {
                First = Last = newNode;
            }
            else
            {
                Last.Next = newNode;
                Last = newNode;
            }
        }
        public void AddAfter(T key, T data)
        {
            Node<T> current = Find(key);
            if (current == null)
            {
                Console.WriteLine("No key found");
                return;
            }

            Node<T> newNode = new Node<T>(data) { Next = current.Next };
            current.Next = newNode;

            if (current == Last)
            {
                Last = newNode;
            }
        }

        public void Remove(T data)
        {
            if (IsEmpty())
            {
                return;
            }

            if (First.Value.Equals(data))
            {
                First = First.Next;
                if (First == null)
                {
                    Last = null;
                    Console.WriteLine("Success in removal");
                    return;
                }
            }

            Node<T> current = First;
            while (current.Next != null)
            {
                if (current.Next.Value.Equals(data))
                {
                    current.Next = current.Next.Next;
                    if (current.Next == null)
                    {
                        Last = current;
                    }
                    Console.WriteLine("Success in removal");
                    return;
                }
                current = current.Next;
            }
            Console.WriteLine("Something went wrong during removal"); 
            return;
        }
        public Node<T> Find(T data)
        {
            Node<T> current = First;
            while (current != null)
            {
                if (current.Value.Equals(data))
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }
        public void Clear()
        {
            First = Last = null;
        }
        public int Count()
        {
            int count = 0;
            Node<T> current = First;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }

        public override string ToString()
        {
            if (IsEmpty())
            {
                return "List is empty";
            }

            StringBuilder sb = new StringBuilder();
            Node<T> current = First;
            while (current != null)
            {
                sb.Append(current.Value + " >>> ");
                current = current.Next;
            }
            sb.Append("END");
            return sb.ToString();
        }

    }
}
