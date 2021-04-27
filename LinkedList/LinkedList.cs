using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList
    {
        Node head = null;

        public LinkedList()
        {

        }

        public void GetLength()
        {
            int count = 0;
            Node current = head;
            while(current != null)
            {
                count++;
                current = current.next;
            }
            Console.WriteLine(count);
        }

        public void PrintList()
        {
            Node current = head;
            while(current != null)
            {
                Console.WriteLine(current.name);
                current = current.next;
            }
        }

        public bool Find(string name)
        {
            Node current = head;
            while (current != null)
            {
                if (current.name == name)
                {
                    return true;
                }
                current = current.next;
            }
            return false;
        }

        public void Add(string name)
        {
            if (head == null)
            {
                head = new Node(name, null);
            }
            else
            {
                Node current = head;
                while(current.next != null)
                {
                    current = current.next;
                }
                Node newNode = new Node(name, null);
                current.next = newNode;
            }
        }

        public void Delete(string Name)
        {
            Node Current = head;

            while (Current != null)
            {
                //NAME IS FIRST IN LIST
                if (Current.name == Name)
                {
                    head = Current.next;
                    return;
                }
                //NAME IS MIDDLE OF LIST
                if (Current.next.name == Name && Current.next.next != null)
                {
                    Current.next = Current.next.next;
                    return;
                }
                //NAME IS LAST OF LIST
                else if (Current.next.name == Name && Current.next.next == null)
                {
                    Current.next = null;
                    return;
                }
                Current = Current.next;
            }
        }

    }
}
