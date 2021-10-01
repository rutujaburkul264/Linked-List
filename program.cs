using System;

namespace LinkListAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LinkedList
            UC7_LinkedList list = new UC7_LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.InsertAtParticularPosition(2, 30);
            list.RemoveFirstNode();
            list.Display();
            list.RemoveFirstNode();
            list.RemovaLastNode();
            list.Search(30);
            list.Display();
            Console.ReadKey();
            #endregion
        }
    }
}
