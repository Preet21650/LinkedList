using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList mylist = new LinkedList();

            mylist.Add("David");
            mylist.Add("Paul");
            mylist.Add("Tom");
            mylist.Add("Frank");

            mylist.PrintList();
            mylist.GetLength();

        }

    }
}
