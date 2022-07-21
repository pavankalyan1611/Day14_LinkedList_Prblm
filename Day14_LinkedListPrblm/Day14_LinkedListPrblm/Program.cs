using Day14_LinkedListPrblm;

Console.WriteLine("Welcome to Data Structure Linked List :\n");
LinkedList list = new LinkedList();
list.Add(56);
list.Add(30);
list.Add(70);
list.Display();
Console.Write("\n After Remove Last Node :\n Linked List : ");
list.RemovaLastNode();
list.Display();