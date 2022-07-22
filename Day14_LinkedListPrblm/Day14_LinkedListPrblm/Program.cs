using Day14_LinkedListPrblm;

Console.WriteLine("Welcome to Data Structure Linked List :\n");
LinkedList list = new LinkedList();
list.Add(56);
list.Add(30);
list.Add(70);
Node insertData = new Node(40);
list.InsertAtParticularPosition(30, insertData);
Console.Write("After insert 40 after 30 in Linked List \nLinked List : ");
list.Display();
list.RemovaAtParticularNode(40);
Console.Write("\n\nAfter remove 40 from Linked List \nLinked List : ");
list.Display();


